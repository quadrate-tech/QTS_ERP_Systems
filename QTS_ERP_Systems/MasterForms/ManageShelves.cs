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
    public partial class ManageShelves : Form
    {
        readonly DbCon db = new DbCon();
        private string ShelveId;
        private string ShelveName;
        private readonly string Collection = "Shelves";
        public ManageShelves()
        {
            InitializeComponent();
        }

        private void ClearText()
        {
            txtShelve_Id.Clear();
            txtShelve_Name.Clear();
        }
        public void frmLoad()
        {
            dgvShelve.DataSource = db.FilterCustomer("");
            dgvShelve.Columns[0].Visible = false;
        }
        private void ManageShelve_Load(object sender, EventArgs e)
        {
            frmLoad();
        }
        private void EnableFalse()
        {
            txtShelve_Id.Enabled = false;
            txtShelve_Name.Enabled = false;
        }
        private void EnableTrue()
        {
            txtShelve_Name.Enabled = true;
            txtShelve_Id.Enabled = true;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            ClearText();
            EnableFalse();
        }
    }
}
