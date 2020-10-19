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
    public partial class ManageItems : Form
    {
        public ManageItems()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ResetFeilds();
            PanelCRUD.Enabled = true;
            BtnCancel.Enabled = true;
            BtnSave.Enabled = true;
            TxtItemId.Text = "0";
            TxtItemCode.Focus();
        }

        private void ResetFeilds()
        {
            TxtItemCode.Text = string.Empty;
            TxtItemName.Text = string.Empty;
            TxtPrintableName.Text = string.Empty;
            CmbUnit.Text = string.Empty;
            TxtUnitCost.Text = string.Empty;
            TxtSellingPrice.Text = string.Empty;

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            PanelCRUD.Enabled = true;
            BtnCancel.Enabled = true;
            TxtItemCode.Focus();
            BtnSave.Enabled = true;
        }

        private bool GetIsService()
        {
            if (ChkBoxIsService.Checked)
                return true;
            else
                return false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            PanelCRUD.Enabled = false;
            BtnCancel.Enabled = false;
        }

        private void CmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
