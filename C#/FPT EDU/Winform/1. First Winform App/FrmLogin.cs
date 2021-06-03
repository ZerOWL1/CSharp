using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using _1.First_Winform_App.Models;
using System.Data.SqlClient;
using System.Configuration;
using _1.First_Winform_App.DBContext.LoadData;

namespace _1.First_Winform_App
{
    public partial class FrmLogin : Form
    {


        public FrmLogin()
        {
            InitializeComponent();
            //Set default input is txtUserName while open forms
            this.ActiveControl = txtUserName;
            txtUserName.Focus();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        public bool ValidAcc()
        {
            string user = txtUserName.Text.Trim();
            string pass = txtPasswords.Text.Trim();

            //Check userName or Pass null or not
            if (user == "" || pass == "")
            {
                return false;
            }

            Regex regex = new Regex(@"^([a-zA-Z0-9_\.]+)$");
            if (!regex.IsMatch(user) || !regex.IsMatch(pass))
            {
                return false;
            }

            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AccountDB acDB = new AccountDB();
            /* Yeu Cau:
             * 1. UserName & Passwords is not empty
             *      Loai bo cu phap SQL Injection - tao Parrtern
             * 2. Kiem tra su ton tai cua Account duoi DB (GiaDinh, user, pass, lan luot la Admin, 123456)
             * 3. Dieu huong toi FrmMain. Dong thoi, dong FrmLogin hien tai
             * 4. Thong bao loi neu vi pham yeu cau 1. 2
             */
            string user = txtUserName.Text.Trim();
            string pass = txtPasswords.Text.Trim();
            //if userName and Passwords is valid
            if (ValidAcc())
            {
                //If Exist check account in DB
                if (acDB.GetAccountAdmin(user, pass).Rows.Count > 0)
                {
                    //Send User to Other Form
                    //Hide Form Login
                    this.Hide();

                    //Show Form Main
                    new FrmAdmin().ShowDialog();

                    //Close form login
                    this.Close();
                }
                else if (acDB.GetAccountMod(user, pass).Rows.Count > 0)
                {
                    this.Hide();
                    new FrmModerator().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("This account not exist!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                }
            }
            else
            {
                //If Exist check account in DB or enter something invalid
                MessageBox.Show("You've Enter Invalid Account",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
            }


        }
    }
}
