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
    public partial class bank : Form
    {
        readonly DbCon db = new DbCon();
        private string BankId;
        private string BankName;
        private readonly string Collection = "Bank";
        public bank()
        {
            InitializeComponent();
        }

        public void frmLoad()
        {
            dgvBank.DataSource = db.FilterEmployee("");
            dgvBank.Columns[0].Visible = false;
        }
        private void ManageBank_Load(object sender, EventArgs e)
        {
            frmLoad();
        }

        private void ClearText()
        {
            txtBank.Clear();
            txtSearchBank.Clear();
        }
        private void EnableFalse()
        {
            txtBank.Enabled = false;
        }
        private void EnableTrue()
        {
            txtBank.Enabled = true;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            ClearText();
            EnableFalse();
        }

        private void add_Click(object sender, EventArgs e)
        {
            ClearText();
            EnableTrue();
            txtBank.Focus();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Bank bank = new Bank
            {
                bank_id = RandomString.RandString(15),
                bank_name = txtBank.Text.Trim(),
            };
            db.InsertBank(Collection, bank);
            ClearText();
            frmLoad();
        }

        private void update_Click(object sender, EventArgs e)
        {
            BankName = txtBank.Text.Trim();
            db.UpdateBank(Collection, BankId, BankName);
            ClearText();
            frmLoad();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BankId = dgvBank.CurrentRow.Cells[0].Value.ToString();
            txtBank.Text = dgvBank.CurrentRow.Cells[1].Value.ToString();
            EnableTrue();
        }

        private void txtSearchBank_KeyUp(object sender, KeyEventArgs e)
        {
            string bank = txtSearchBank.Text.Trim();
            dgvBank.DataSource = db.FilterBank(bank);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            db.DeleteBank(BankId);
            ClearText();
            frmLoad();
        }
    }
}
