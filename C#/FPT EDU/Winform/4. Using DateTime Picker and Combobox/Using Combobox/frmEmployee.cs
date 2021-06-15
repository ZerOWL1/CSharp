using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Lab3_HE141223_HaiLD.Controllers;

namespace Lab3_HE141223_HaiLD
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        public void RefreshDgv()
        {
            dgvEmployee.DataSource = EmployeesControl.GetEmployees();
            //Change Header Text for DataGridView
            dgvEmployee.Columns[1].HeaderText = "EID";
            dgvEmployee.Columns[2].HeaderText = "First Name";
            dgvEmployee.Columns[3].HeaderText = "Birth Date";
            dgvEmployee.Columns[4].HeaderText = "Reports To";
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            //Add Checkbox in dgvCate
            DataGridViewCheckBoxColumn select = new DataGridViewCheckBoxColumn();
            select.Name = "selectColumn";
            select.HeaderText = "Options";
            select.ValueType = typeof(bool);
            dgvEmployee.Columns.Add(select);

            //Refresh dgv
            RefreshDgv();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Show frmAdd and close frmEmployee
            this.Hide();
            new frmAdd().ShowDialog();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Check delete want to delete or not
            DialogResult m = MessageBox.Show("Do you want to delete this record?", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            //OK
            if (m == DialogResult.OK)
            {
                int count = 0;
                foreach (DataGridViewRow row in dgvEmployee.Rows)
                {
                    DataGridViewCheckBoxCell chk = row.Cells[0] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(chk.Value) == true)
                    {
                        //Delete
                        string eId = row.Cells[1].Value.ToString();
                        count = EmployeesControl.DeleteEmployees(eId);
                    }
                }
                //Count > 0 Delete Success
                if (count > 0)
                {
                    MessageBox.Show("Delete Success!!");
                    RefreshDgv();
                }
                //Count = -1 Cant Delete Cause that ID is Manager
                else if (count == -1)
                {
                    MessageBox.Show("This ID is Manager!!");
                    RefreshDgv();
                }
                //Count = 0 Data relate to other table
                else if(count == 0)
                {
                    MessageBox.Show("This ID Relate to Order or Territory!!");
                    RefreshDgv();
                }
            }
            //Cancel
            else if(m == DialogResult.Cancel)
            {
            }
        }
    }
}
