using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QTS_ERP_Systems.Model;
namespace QTS_ERP_Systems.MasterForms
{
    public partial class ManageSupplier : Form
    {
        readonly DbCon db = new DbCon();
        private readonly string Collection = "Suppliers";

        private int supplierId_;
        private string name_;
        private string contact_;
        private string address_;
        private string email_;
        private float pendingAmount_;

        public ManageSupplier()
        {
            InitializeComponent();
        }

        private void ManageSupplier_Load(object sender, EventArgs e)
        {
            FormLoad();
        }
        public void FormLoad()
        {
            dgvSupplier.DataSource = db.FilterSupplier("");
            dgvSupplier.Columns[0].Visible = false;
        }

        private void ClearText()
        {
            TxtSupplierId.Clear();
            TxtSupplierId.Clear(); 
            txtSupplierName.Clear();
            txtSupplierContact.Clear();
            txtSupplierAddress.Clear();
            txtOpeningBalance.Clear();
            supplierEmail.Clear();
        }
        private void EnableTrue()
        {
            txtSupplierName.Enabled = true;
            txtSupplierContact.Enabled = true;
            txtSupplierAddress.Enabled = true;
            supplierEmail.Enabled = true;
            txtOpeningBalance.Enabled = true;
        }
        private void EnableFalse()
        {
            txtSupplierName.Enabled = false;
            txtSupplierContact.Enabled = false;
            txtSupplierAddress.Enabled = false;
            supplierEmail.Enabled = false;
            txtOpeningBalance.Enabled = false;
        }

        private void BTNADD_Click(object sender, EventArgs e)
        {
            EnableTrue();
            ClearText();
            txtSupplierName.Focus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Supplier supl = new Supplier {
            SupplierId= rnd.Next(),
                Name = txtSupplierName.Text.Trim(),
                Contact = txtSupplierContact.Text.Trim(),
                Address = txtSupplierAddress.Text.Trim(),
                Email= supplierEmail.Text.Trim(),
                PendingAmount = float.Parse(txtOpeningBalance.Text.Trim()),
            };
            db.InsertSupplier(Collection, supl);
            ClearText();
            FormLoad();
        }

        private void BTNUPDATE_Click(object sender, EventArgs e)
        {

            name_ = txtSupplierName.Text.Trim();

            contact_ = txtSupplierContact.Text.Trim();
            address_ = txtSupplierAddress.Text.Trim();
            email_ = supplierEmail.Text.Trim();
            pendingAmount_ = float.Parse(txtOpeningBalance.Text.Trim());
            db.UpdateSupplier(Collection, supplierId_, name_, contact_, address_, email_, pendingAmount_);
            ClearText();
            FormLoad();
        }

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
            db.DeleteSupplier(supplierId_);
            ClearText();
            FormLoad();
            EnableTrue();
        }

        private void BTNCANEL_Click(object sender, EventArgs e)
        {
            ClearText();
            EnableFalse();
        }

        private void Supplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtSupplierId.Text= dgvSupplier.CurrentRow.Cells[0].Value.ToString();
            supplierId_ = (int)dgvSupplier.CurrentRow.Cells[0].Value;
            txtSupplierName.Text = dgvSupplier.CurrentRow.Cells[1].Value.ToString();
            txtSupplierContact.Text = (string)dgvSupplier.CurrentRow.Cells[2].Value;
            txtSupplierAddress.Text = (string)dgvSupplier.CurrentRow.Cells[3].Value;
            supplierEmail.Text = (string)dgvSupplier.CurrentRow.Cells[4].Value;
            txtOpeningBalance.Text = dgvSupplier.CurrentRow.Cells[5].Value.ToString();
            EnableTrue();
        }

        private void txtSupplierName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        //private void txtSupplierContact_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        //}

        //private void txtSupplierAddress_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        //}

        private void txtOpeningBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSearchISupply_KeyUp(object sender, KeyEventArgs e)
        {
            string suplSearch = txtSearchISupply.Text.Trim();
            dgvSupplier.DataSource = db.FilterSupplier(suplSearch);
        }

        private void TxtSupplierId_TextChanged(object sender, EventArgs e)
        {

        }
    }




}
