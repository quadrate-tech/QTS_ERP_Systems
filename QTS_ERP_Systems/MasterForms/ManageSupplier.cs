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
            dgvItem.DataSource = db.FilterSupplier("");
            dgvItem.Columns[0].Visible = false;
        }

        private void ClearText()
        {
            txtSupplierName.Clear();
            txtSupplierContact.Clear();
            txtSupplierAddress.Clear();
            txtOpeningBalance.Clear();
        }
        private void EnableTrue()
        {
            txtSupplierName.Enabled = true;
            txtSupplierContact.Enabled = true;
            txtSupplierAddress.Enabled = true;
            txtOpeningBalance.Enabled = true;
        }
        private void EnableFalse()
        {
            txtSupplierName.Enabled = false;
            txtSupplierContact.Enabled = false;
            txtSupplierAddress.Enabled = false;
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
            Random suply = new Random();
        }
    }




}
