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
    public partial class PurchaseOrder : Form
    {
        readonly DbCon db = new DbCon();
        private string PurchaseOrderDate;
        private readonly string Collection = "PurchaseOrder";
        public PurchaseOrder()
        {
            InitializeComponent();
        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            dgvOrderedItems.DataSource = db.FormLoadOrderedItems(DateTime.Today.ToShortDateString());
            //dgvOrderedItems.DataSource = db.FormLoadOrderedItems(DateTime.Today.ToShortDateString());
            //db.FormLoadReceivedItems(DateTime.Today.ToShortDateString());
            //dgvItemsToOrder.DataSource =  db.FormLoadItems();
            //listBoxPendingOrders.DataSource = db.FormLoadPendingOrders();
        }

        private void AddToOrder()
        {
            string Date = dtpOrderDate.Value.ToShortDateString();
            if (dgvItemsToOrder.SelectedRows.Count > 0)
            {
                string Code = dgvItemsToOrder.SelectedRows[0].Cells[0].Value + string.Empty;

            }
        }
        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            try
            {
                PurchaseOrderDate = dtpOrderDate.Value.ToShortDateString();

                var CheckPurchaeOrderDate = db.CheckPurchaseOrderDate(PurchaseOrderDate);
                if (CheckPurchaeOrderDate == true)
                {
                    bool result = Info.YesNoConfirmation("For Selected date you have already created a purchase order, would you like to update again", "Confirmation");
                    if (result)
                    {
                        btnAddToOrder.Enabled = true;
                        btnRemoveFromOrder.Enabled = true;
                    }
                }
                else
                {
                    Model.PurchaseOrder PurO = new Model.PurchaseOrder
                    {
                        Date = PurchaseOrderDate,
                        CreatedDate = DateTime.Today
                    };
                    db.InsertPurchaseOrder(Collection, PurO);
                    btnAddToOrder.Enabled = true;
                    btnRemoveFromOrder.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgvItemsToOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
