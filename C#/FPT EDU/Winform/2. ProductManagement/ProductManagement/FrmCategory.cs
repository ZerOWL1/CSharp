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
using ProductManagement.DAO;
using ProductManagement.Models;

namespace ProductManagement
{
    public partial class FrmCategory : Form
    {
        private bool statusAdd = false;
        public FrmCategory()
        {
            InitializeComponent();
        }

        private void RefreshDgvCategory()
        {
            dgvCategory.DataSource = Categories.GetCategories();
            //Change Header Text for DataGridView
            dgvCategory.Columns[1].HeaderText = "ID";
            dgvCategory.Columns[2].HeaderText = "Name";
            dgvCategory.Columns[3].HeaderText = "Desc";

        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            //Add Checkbox in dgvCate
            DataGridViewCheckBoxColumn select = new DataGridViewCheckBoxColumn();
            select.Name = "selectColumn";
            select.HeaderText = "Options";
            select.ValueType = typeof(bool);
            dgvCategory.Columns.Add(select);

            RefreshDgvCategory();

            txtCatId.Enabled = false;
            txtCatName.Enabled = false;
            txtDescription.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            statusAdd = false;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            statusAdd = true;
            txtCatId.Enabled = true;
            txtCatName.Enabled = true;
            txtDescription.Enabled = true;
            btnSave.Enabled = true;
            txtCatId.Text = String.Empty;
            txtCatName.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtCatId.Focus();
        }

        private bool Validate()
        {
            string id = txtCatId.Text.Trim();
            string name = txtCatName.Text.Trim();


            Regex regexID = new Regex(@"^[C]([0-9]){4}$");
            if (!regexID.IsMatch(id))
            {
                MessageBox.Show(@"You've Enter Invalid ID!! Format CXXXX - Number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCatId.Focus();
                return false;
            }
            //Check duplicate / Neu Trung
            else if (name == String.Empty)
            {
                MessageBox.Show(@"You not enter Name infor!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCatId.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtCatId.Text.Trim();
            string name = txtCatName.Text.Trim();
            string desc = txtDescription.Text.Trim();

            ArrayList arrayList = new ArrayList()
            {
                new Categories()
                {
                    CateID = id,
                    CateName = name,
                    CateDescription = desc
                }
            };

            if (statusAdd == true)
            {
                //Add new Category
                if (Validate())
                {
                    Categories.AddCategory(arrayList);
                    MessageBox.Show("Add Success!!", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvCategory.DataSource = Categories.GetCategories();
                    txtCatId.Text = String.Empty;
                    txtCatName.Text = String.Empty;
                    txtDescription.Text = String.Empty;
                    txtCatId.Focus();
                }
            }
            else
            {
                //Update new Category
                Categories.UpdateCategory(arrayList);
                MessageBox.Show("Update Success!!", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvCategory.DataSource = Categories.GetCategories();
                txtCatId.Text = String.Empty;
                txtCatName.Text = String.Empty;
                txtDescription.Text = String.Empty;
                txtCatId.Focus();
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string input = txtSearch.Text;
            DataTable tableName = Categories.getCategoryByName(input);
            DataTable tableID = Categories.getCategoryByID(input);

            int countName = tableName.Rows.Count;
            int countID = tableID.Rows.Count;


            if (countName >= 1)
            {
                dgvCategory.DataSource = null;
                dgvCategory.DataSource = tableName;
                txtSearch.Focus();
            }
            else if (countID >= 1)
            {
                dgvCategory.DataSource = null;
                dgvCategory.DataSource = tableID;
                txtSearch.Focus();
            }
            else if (input == "all" || input == "ALL")
            {
                dgvCategory.DataSource = null;
                dgvCategory.DataSource = Categories.GetCategories();
                txtSearch.Focus();
            }
            else if(countName == 0)
            {
                MessageBox.Show(@"No data of that NAME!!", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Focus();
            }else if (countID == 0)
            {
                MessageBox.Show(@"No data of that ID!!", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Focus();
            }



        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategory.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvCategory.CurrentRow.Selected = true;
                txtCatId.Text = dgvCategory.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtCatName.Text = dgvCategory.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtDescription.Text = dgvCategory.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            }
            btnDelete.Enabled = true;
            statusAdd = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtCatId.Text.Trim();

            DialogResult m = MessageBox.Show("Do you want to delete this record?", "Warning", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (m == DialogResult.OK)
            {
                Categories.DeleteCategory(id);
                dgvCategory.DataSource = Categories.GetCategories();
                txtCatId.Text = String.Empty;
                txtCatName.Text = String.Empty;
                txtDescription.Text = String.Empty;
                txtCatId.Focus();
            }
            else if(m == DialogResult.Cancel)
            {

            }
        }
    }
}
