using System;
using System.Windows.Forms;
using QTS_ERP_Systems.Model;

namespace QTS_ERP_Systems.MasterForms
{
    public partial class ManageCategory : Form
    {

        public ManageCategory()
        {
            InitializeComponent();
        }

        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            Category c = new Category
            {
                Category_Name = TxtCategory.Text.Trim()
            };

            DbCon db = new DbCon();
            db.InsertRecord("Category", c);
            MessageBox.Show("Category Added");
        }
    }
}
