using QTS_ERP_Systems.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QTS_ERP_Systems.MasterForms
{
    public partial class ManageCustomers : Form
    {
        readonly DbCon db = new DbCon();
        private string CustomerId;
        private string CustomerName;
        private int ContactNo;
        private string Address;
        private string Email;
        private readonly string Collection = "Customers";

        public ManageCustomers()
        {
            InitializeComponent();
        }
        public void frmLoad()
        {
            dgvCustomers.DataSource = db.FilterCustomer("");
            dgvCustomers.Columns[0].Visible = false;
        }
        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            frmLoad();
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void ClearText()
        {
            CustomerId = String.Empty;
            txtCustomerName.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
        }
        private void EnableFalse()
        {
            txtCustomerName.Enabled = false;
            txtContact.Enabled = false;
            txtAddress.Enabled = false;
            txtEmail.Enabled = false;
        }
        private void EnableTrue()
        {
            txtCustomerName.Enabled = true;
            txtContact.Enabled = true;
            txtAddress.Enabled = true;
            txtEmail.Enabled = true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            EnableTrue();
            ClearText();
            txtCustomerName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer Cus = new Customer
            {
                CustomerId = RandomString.RandString(15),
                CustomerName = txtCustomerName.Text.Trim(),
                ContactNo = Convert.ToInt32(txtContact.Text),
                Address = txtAddress.Text.Trim(),
                Email = txtEmail.Text.Trim()
            };
            db.InsertCustomer(Collection, Cus);
            ClearText();
            frmLoad();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CustomerName = txtCustomerName.Text.Trim();
            ContactNo = Convert.ToInt32(txtContact.Text);
            Address = txtAddress.Text.Trim();
            Email = txtEmail.Text.Trim();
            db.UpdateCustomers(Collection, CustomerId, CustomerName, Address, Email, ContactNo);
            ClearText();
            frmLoad();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.DeleteCustomer(CustomerId);
            frmLoad();
            ClearText();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnableFalse();
            ClearText();
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerId = dgvCustomers.CurrentRow.Cells[0].Value.ToString();
            txtCustomerName.Text = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
            txtAddress.Text = dgvCustomers.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgvCustomers.CurrentRow.Cells[3].Value.ToString();
            txtContact.Text = dgvCustomers.CurrentRow.Cells[4].Value.ToString();
            EnableTrue();
        }

        private void txtSearchCustomers_KeyUp(object sender, KeyEventArgs e)
        {
            string CusSearch = txtSearchCustomers.Text.Trim();
            dgvCustomers.DataSource = db.FilterCustomer(CusSearch);
        }
    }
}
