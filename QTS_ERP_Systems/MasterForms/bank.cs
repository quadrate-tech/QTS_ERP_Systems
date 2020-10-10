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
    }
}
