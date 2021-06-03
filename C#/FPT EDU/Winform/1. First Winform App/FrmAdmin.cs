using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _1.First_Winform_App.DBContext.LoadData;
using _1.First_Winform_App.Models;

namespace _1.First_Winform_App
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            AccountDB accDB = new AccountDB();
            DataTable listAcc = accDB.GetHaveAccount();
           
            //Using Data GridView
            dgvAccount.DataSource = listAcc;
        }
    }
}
