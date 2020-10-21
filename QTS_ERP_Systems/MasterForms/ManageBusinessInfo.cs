﻿using QTS_ERP_Systems.Model;
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
    public partial class ManageBusinessInfo : Form
    {
        readonly DbCon db = new DbCon();
        private int bId;
        private string bName;
        private string bAddress;
        private string bContact;
        private bool bIsActive;
        private readonly string Collection = "BusinessModels";
        public ManageBusinessInfo()
        {
            InitializeComponent();
        }

        private void ManageBusinessInfo_Load(object sender, EventArgs e)
        {
            FrmLoad();
        }
        private void FrmLoad()
        {

            DGVBusinessInfo.DataSource = db.FilterBusinessModel("");
           // DGVBusinessInfo.Columns[0].Visible = false;
        }
        private void ClearText()
        {

            TxtName.Clear();
            TxtAddress.Clear();
            TxtContact.Clear();

        }
        private void EnableTrue()
        {

            TxtName.Enabled = true;
            TxtAddress.Enabled = true;
            TxtContact.Enabled = true;

        }
        private void EnableFalse()
        {

            TxtName.Enabled = false;
            TxtAddress.Enabled = false;
            TxtContact.Enabled = false;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ClearText();
            EnableTrue();

            TxtName.Focus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            BusinessModel bm = new BusinessModel
            {
                Id = rnd.Next(),
                Name = TxtName.Text.Trim(),
                Address = TxtAddress.Text.Trim(),
                Contact = TxtContact.Text.Trim(),
                IsActive = Service()

            };
            db.InsertBusinessModel(Collection, bm);
            ClearText();
            FrmLoad();

        }
        private bool Service()
        {
            bool Service = false;
            if (chBox.Checked)
            {
                Service = true;
            }
            else
            {
                Service = true;
            }
            return Service;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            bName = TxtName.Text;
            bAddress = TxtAddress.Text;
            bContact = TxtContact.Text;
            bIsActive = Service();
            db.UpdateBusinessModel(Collection, bId, bName, bAddress, bContact, bIsActive);
            ClearText();
            FrmLoad();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            db.DeleteBusinessModel(bId);
            ClearText();
            FrmLoad();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearText();
            EnableFalse();
        }

        private void DGVBusinessInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            bId = Convert.ToInt32(DGVBusinessInfo.CurrentRow.Cells[0].Value);
            TxtName.Text = DGVBusinessInfo.CurrentRow.Cells[1].Value.ToString();
            TxtAddress.Text = DGVBusinessInfo.CurrentRow.Cells[2].Value.ToString();
            TxtContact.Text = DGVBusinessInfo.CurrentRow.Cells[3].Value.ToString();
            chBox.Enabled = Convert.ToBoolean(DGVBusinessInfo.CurrentRow.Cells[4].Value.ToString());
        }

        private void TxtName_KeyUp(object sender, KeyEventArgs e)
        {
            Info.ToCapital(TxtName);
        }

        private void TxtAddress_KeyUp(object sender, KeyEventArgs e)
        {
            Info.ToCapital(TxtName);
        }
    }
}
