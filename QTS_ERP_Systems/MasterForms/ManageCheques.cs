using QTS_ERP_Systems.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QTS_ERP_Systems.MasterForms
{
    public partial class ManageCheques : Form
    {
        readonly DbCon db = new DbCon();
        private int ChequeNo;
        private string Payee;
        private int Amount;
        private DateTime DueDate;
        private string PaidBy;
        private string BankName;
        private readonly string Collection = "Cheques";
        public ManageCheques()
        {
            InitializeComponent();
        }
        public void FormLoad()
        {
            dgvCheques.DataSource = db.FilterCheque("");
        }
        private void ManageCheques_Load(object sender, EventArgs e)
        {
            FormLoad();
            dtpDueDate.CustomFormat = "dd-MM-yyyy";
            EnableFalse();
        }
        private void ClearText()
        {
            txtChequeNo.Clear();
            txtPayee.Clear();
            txtAmount.Clear();
            dtpDueDate.Value = DateTime.Today;
            txtPaidBy.Clear();
            txtBankName.Clear();
        }
        private void EnableTrue()
        {
            txtChequeNo.Enabled = true;
            txtPayee.Enabled = true;
            txtAmount.Enabled = true;
            dtpDueDate.Enabled = true;
            txtPaidBy.Enabled = true;
            txtBankName.Enabled = true;
        }
        private void EnableFalse()
        {
            txtChequeNo.Enabled = false;
            txtPayee.Enabled = false;
            txtAmount.Enabled = false;
            dtpDueDate.Enabled = false;
            txtPaidBy.Enabled = false;
            txtBankName.Enabled = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            EnableTrue();
            ClearText();
            txtChequeNo.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int ChqNo = Convert.ToInt32(txtChequeNo.Text);
            bool CheckChqNo = db.CheckChequeNo(ChqNo);
            if (CheckChqNo == true)
            {
                MessageBox.Show("This Cheque No Already Added");
            }
            else
            {
                Cheque Chq = new Cheque
                {
                    ChequeNumber = Convert.ToInt32(txtChequeNo.Text),
                    Payee = txtPayee.Text.Trim(),
                    Amount = Convert.ToInt32(txtAmount.Text),
                    DueDate = dtpDueDate.Value,
                    PaidBy = txtPaidBy.Text.Trim(),
                    BankName = txtBankName.Text.Trim()
                };
                db.InsertCheque(Collection, Chq);
                ClearText();
                FormLoad();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ChequeNo = Convert.ToInt32(txtChequeNo.Text);
            Payee = txtPayee.Text.Trim();
            Amount = Convert.ToInt32(txtAmount.Text);
            DueDate = dtpDueDate.Value;
            PaidBy = txtPaidBy.Text.Trim();
            BankName = txtBankName.Text.Trim();

            db.UpdateCheque(Collection,ChequeNo,Payee,Amount,DueDate,PaidBy,BankName);
            ClearText();
            FormLoad();
            EnableTrue();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ChequeNo = Convert.ToInt32(txtChequeNo.Text);
            db.DeleteCheque(ChequeNo);
            ClearText();
            FormLoad();
            EnableTrue();
            
        }
       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearText();
            EnableFalse();
        }

        private void dgvCheques_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtChequeNo.Text = dgvCheques.CurrentRow.Cells[0].Value.ToString();
            txtPayee.Text = dgvCheques.CurrentRow.Cells[1].Value.ToString();
            txtAmount.Text = dgvCheques.CurrentRow.Cells[2].Value.ToString();
            dtpDueDate.Value = DateTime.Parse(dgvCheques.CurrentRow.Cells[3].Value.ToString());
            txtPaidBy.Text = dgvCheques.CurrentRow.Cells[4].Value.ToString();
            txtBankName.Text = dgvCheques.CurrentRow.Cells[5].Value.ToString();
            EnableTrue();
            txtChequeNo.Enabled = false;
        }

        private void txtSearchCheque_KeyUp(object sender, KeyEventArgs e)
        {
            string Chq = txtSearchCheque.Text;
            dgvCheques.DataSource = db.FilterCheque(Chq);
        }

        private void txtChequeNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSearchCheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

      

     

       
    }
}
