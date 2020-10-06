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
    public partial class ManageEmployee : Form
    {
        readonly DbCon db = new DbCon();
        private string EmployeeId;
        private string EmployeeName;
        private int ContactNo;
        private string Address;
        private string Email;
        private string SecretCode;
        private readonly string Collection = "Employees";
        public ManageEmployee()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void frmLoad()
        {
            dgvEmployee.DataSource = db.FilterEmployee("");
            dgvEmployee.Columns[0].Visible = false;
        }
        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            frmLoad();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearText();
            EnableTrue();
            txtEmployeeName.Focus();
        }
        private void ClearText()
        {
            txtEmployeeName.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtSecretCode.Clear();
        }
        private void EnableFalse()
        {
            txtEmployeeName.Enabled = false;
            txtContact.Enabled = false;
            txtAddress.Enabled = false;
            txtEmail.Enabled = false;
            txtSecretCode.Enabled = false;
        }
        private void EnableTrue()
        {
            txtEmployeeName.Enabled = true;
            txtContact.Enabled = true;
            txtAddress.Enabled = true;
            txtEmail.Enabled = true;
            txtSecretCode.Enabled = true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee Emp = new Employee
            {
                Employee_Id = RandomString.RandString(15),
                Employee_Name = txtEmployeeName.Text.Trim(),
                Contact_No = txtContact.Text,
                Address = txtAddress.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                SecretCode = txtSecretCode.Text.Trim()
            };
            db.InsertEmployee(Collection, Emp);
            ClearText();
            frmLoad();
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.DeleteEmployee(EmployeeId);
            ClearText();
            frmLoad();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearText();
            EnableFalse();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EmployeeId = dgvEmployee.CurrentRow.Cells[0].Value.ToString();
            txtEmployeeName.Text = dgvEmployee.CurrentRow.Cells[1].Value.ToString();
            txtContact.Text = dgvEmployee.CurrentRow.Cells[2].Value.ToString();
            txtAddress.Text = dgvEmployee.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvEmployee.CurrentRow.Cells[4].Value.ToString();
            txtSecretCode.Text = dgvEmployee.CurrentRow.Cells[5].Value.ToString();
            EnableTrue();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EmployeeName = txtEmployeeName.Text.Trim();
            ContactNo = Convert.ToInt32(txtContact.Text);
            Address = txtAddress.Text.Trim();
            Email = txtEmail.Text.Trim();
            SecretCode = txtSecretCode.Text.Trim();
            db.UpdateEmployee(Collection, EmployeeId, EmployeeName, ContactNo, Address, Email, SecretCode);
            ClearText();
            frmLoad();
        }

        private void txtSearchEmployee_KeyUp(object sender, KeyEventArgs e)
        {
            string Emp = txtSearchEmployee.Text.Trim();
            dgvEmployee.DataSource = db.FilterEmployee(Emp);
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
