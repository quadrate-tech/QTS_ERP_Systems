using System;
using System.Drawing.Design;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using QTS_ERP_Systems.Model;

namespace QTS_ERP_Systems.MasterForms
{
    public partial class ManageCategory : Form
    {
        readonly DbCon db = new DbCon();
        private string CategoryId;
        private string CategoryName;
        private readonly string Collection = "Category";
        public ManageCategory()
        {
            InitializeComponent();
        }

        public void FrmLoad()
        {
            DGVCategory.DataSource = db.FilterCategory("");
        }
        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            Category c = new Category
            {
                Category_Id = RandomString.RandString(15),
                Category_Name = TxtCategory.Text.Trim()
            };

            db.InsertCategory(Collection, c);
            FrmLoad();
        }

        private void ManageCategory_Load(object sender, EventArgs e)
        {
            FrmLoad();
        }

        private void DGVCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoryId = DGVCategory.SelectedRows[0].Cells[0].Value.ToString();
            TxtCategory.Text = DGVCategory.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            CategoryName = TxtCategory.Text.Trim();
            db.UpdateCategory(Collection, CategoryId, CategoryName);
            FrmLoad();
        }
        private void TxtFilter_KeyUp(object sender, KeyEventArgs e)
        {
            string Cat = TxtFilter.Text.Trim();
            DGVCategory.DataSource = db.FilterCategory(Cat);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            db.DeleteOne(CategoryId);
            FrmLoad();
        }
    }
}
