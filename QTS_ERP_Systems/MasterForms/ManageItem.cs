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
    public partial class ManageItem : Form
    {
        readonly DbCon db = new DbCon();

     
       
        private string itemId;
        private int itemCode;
        private string itemName;
        private string printableName;
        private string unittype;
        private int unitCost;
        private int sellingPrice;
        private bool isService;
        private readonly string Collection = "Items";
        public ManageItem()
        {
            InitializeComponent();
        }
        public void FormLoad()
        {
            dgvItem.DataSource = db.FilterItem("");
            dgvItem.Columns[0].Visible = false;
        }
        private void ManageItem_Load(object sender, EventArgs e)
        {
            FormLoad();
        }
        private void ClearText()
        {
           // txtItemNo.Clear();
            txtItemCode.Clear();
            txtItemName.Clear();
            txtPrintName.Clear();
            txtUnitType.Clear();
            txtUnitCost.Clear();
            yesBtn.Checked = false;
            txtSellingPrice.Clear();
        }
        private void EnableTrue()
        {
           // txtItemNo.Enabled = true;
            txtItemCode.Enabled = true;
            txtItemName.Enabled = true;
            txtPrintName.Enabled = true;
            txtUnitType.Enabled = true;
            txtUnitCost.Enabled = true;
            yesBtn.Checked = true;
            txtSellingPrice.Enabled = true;
        }
        private void EnableFalse()
        {
            //txtItemNo.Enabled = false;
            txtItemCode.Enabled = false;
            txtItemName.Enabled = false;
            txtPrintName.Enabled = false;
            txtUnitType.Enabled = false;
            txtUnitCost.Enabled = false;
            yesBtn.Checked = false;
            txtSellingPrice.Enabled = false;

        }
        private void BtnAdd_Click1(object sender, EventArgs e)
        {
            EnableTrue();
            ClearText();
            txtItemCode.Focus();
        }
        //SAVE BUTTON 
        private void BtnSave_Click_1(object sender, EventArgs e)
        {
          
            {
                Random rnd = new Random();
                Item itm = new Item
                {
                item_id = rnd.Next(),
                item_code = Convert.ToInt32(txtItemCode.Text.Trim()),
                    item_name = txtItemName.Text.Trim(),
                    printable_name = txtPrintName.Text.Trim(),
                    unit_type = txtUnitType.Text.Trim(),
                    unit_cost = Convert.ToInt32(txtUnitCost.Text.Trim()),
                    selling_price = Convert.ToInt32(txtSellingPrice.Text),
                    is_service = Service()

                };
                db.InsertItem(Collection, itm);
                ClearText();
                FormLoad();

            }
        }
        
        private bool Service()
        {
            bool Service = false;
            if (yesBtn.Checked)
            {
                Service = true;
            }
            else
            {
                Service = true;
            }
            return Service;
        }
        //UPDATE BUTTON 
        private void BtnUpdate_Click_1(object sender, EventArgs e)
        {
       
            itemCode = Convert.ToInt32(txtItemCode.Text.Trim());
            itemName = txtItemName.Text.Trim();
            printableName = txtPrintName.Text.Trim();
            unittype = txtUnitType.Text.Trim();
            unitCost = Convert.ToInt32(txtUnitCost.Text.Trim());
            sellingPrice = Convert.ToInt32(txtSellingPrice.Text);
            isService = Service();

            db.UpdateItem(Collection, itemId, itemCode, itemName, printableName, unittype, unitCost, sellingPrice, isService);
            ClearText();


            FormLoad();
        }


        private void TxtSearchItem_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSearchItem_keyup(object sender, KeyEventArgs e)
        {
            string IEM = txtSearchItem.Text.Trim();
            dgvItem.DataSource = db.FilterItem(IEM);

        }
        //DELETE BUTTON 
        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
        
            db.DeleteItem(Convert.ToInt32(itemId));
            ClearText();
            FormLoad();
            EnableTrue();
        }

        private void DgvItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            itemId = dgvItem.CurrentRow.Cells[0].Value.ToString();//txtItemNo.Text
            txtItemCode.Text = dgvItem.CurrentRow.Cells[1].Value.ToString();
            txtItemName.Text = dgvItem.CurrentRow.Cells[2].Value.ToString();
            txtPrintName.Text = dgvItem.CurrentRow.Cells[3].Value.ToString();
            txtUnitType.Text = dgvItem.CurrentRow.Cells[4].Value.ToString();
            txtUnitCost.Text = dgvItem.CurrentRow.Cells[5].Value.ToString();
            txtSellingPrice.Text = dgvItem.CurrentRow.Cells[6].Value.ToString();
            yesBtn.Enabled = Convert.ToBoolean(dgvItem.CurrentRow.Cells[7].Value.ToString());
            EnableTrue();
            

        }


        //CANCEL BUTTON 
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearText();
            EnableFalse();
        }

        private void TxtUnitCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtSellingPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtItemCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}