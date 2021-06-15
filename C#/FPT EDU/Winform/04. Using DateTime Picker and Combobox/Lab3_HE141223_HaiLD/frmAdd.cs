using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Lab3_HE141223_HaiLD.Controllers;
using Lab3_HE141223_HaiLD.Models.Entity;

namespace Lab3_HE141223_HaiLD
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            //Regex Enter cant enter number and below 200 Character
            Regex nameRegex = new Regex(@"^[a-zA-Z]{1,200}$");

            //Check Empty
            if (firstName == String.Empty)
            {
                MessageBox.Show("You've enter nothing", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
            }
            //Check Regex
            else if (nameRegex.IsMatch(firstName))
            {
                DateTime birthDate = dtpBirthDate.Value;
                int selectedIndex = int.Parse(cbxReportTo.SelectedValue.ToString());
                ArrayList list = new ArrayList() {firstName, birthDate, selectedIndex};
                if (EmployeesControl.AddEmployee(list) > 0)
                {
                    //Show message if add success and list return value > 0
                    MessageBox.Show("Add Success!!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new frmEmployee().ShowDialog();
                    this.Close();
                }
            }
            else
            {
                //!regex
                MessageBox.Show("You've enter invalid data. DO NOT ENTER NUMBER AND < 200 Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
            }
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            //load data to combobox
            cbxReportTo.DataSource = EmployeesControl.GetEmployeesDT();
            cbxReportTo.ValueMember = "EmployeeID";
            cbxReportTo.DisplayMember = "FirstName";
        }
    }
}
