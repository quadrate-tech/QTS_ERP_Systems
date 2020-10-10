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
    public partial class ManageShelves : Form
    {
        readonly DbCon db = new DbCon();
        private string Shelveid;
        private string Shelvename;
        private readonly string Collection = "Shelves";
        public ManageShelves()
        {
            InitializeComponent();
        }

        private void ClearText()
        {
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
            txtShelve_Name.Enabled = false;
        }
        private void EnableTrue()
        {
            txtShelve_Name.Enabled = true;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            ClearText();
            EnableFalse();
        }

        private void add_Click(object sender, EventArgs e)
        {
            EnableTrue();
            ClearText();
            txtShelve_Name.Focus();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Shelve shelve = new Shelve
            {
                ShelveId = RandomString.RandString(15),
                ShelveName = txtShelve_Name.Text.Trim()
            };
            db.InsertShelve(Collection, shelve);
            ClearText();
            frmLoad();
        }

        private void update_Click(object sender, EventArgs e)
        {
            Shelvename = txtShelve_Name.Text.Trim();
            db.UpdateShelve(Collection, Shelveid, Shelvename);
            ClearText();
            frmLoad();
        }

        private void dgvShelve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Shelveid = dgvShelve.CurrentRow.Cells[0].Value.ToString();
            txtShelve_Name.Text = dgvShelve.CurrentRow.Cells[1].Value.ToString();
            EnableTrue();
        }

        private void txtSearchShelve_KeyUp(object sender, KeyEventArgs e)
        {
            string SheSearch = txt_searchShelve.Text.Trim();
            dgvShelve.DataSource = db.FilterShelve(SheSearch);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            db.DeleteShelve(Shelveid);
            frmLoad();
            ClearText();
        }
    }
}
