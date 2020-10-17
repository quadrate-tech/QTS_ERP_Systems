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
    public partial class ManageVehicle : Form
    {
        readonly DbCon db = new DbCon();
        private string VehicleNo;
        private string Brand;
        private string Model;
        private string Type;
        private int CurrentMileage;
        private int ServiceMileageDue;
        private string Owner;
        private DateTime AddedDate;
        private readonly string Collection = "Vehicle";
        public ManageVehicle()
        {
            InitializeComponent();
        }
        private void LoadForm()
        {
            dgvVehicles.DataSource = db.FilterVehicle("");
        }
        private void ManageVehicle_Load(object sender, EventArgs e)
        {
            LoadForm();
            dtpAddedDate.CustomFormat = "dd-MM-yyyy";
            EnableFalse();
        }
        private void EnableFalse()
        {
            txtVehicleNo.Enabled = false;
            txtBrand.Enabled = false;
            txtModel.Enabled = false;
            txtType.Enabled = false;
            txtCurrentMileage.Enabled = false;
            txtServiceMileageDue.Enabled = false;
            txtOwnerName.Enabled = false;
            dtpAddedDate.Enabled = false;
        }
        private void EnableTrue()
        {
            txtVehicleNo.Enabled = true;
            txtBrand.Enabled = true;
            txtModel.Enabled = true;
            txtType.Enabled = true;
            txtCurrentMileage.Enabled = true;
            txtServiceMileageDue.Enabled = true;
            txtOwnerName.Enabled = true;
            dtpAddedDate.Enabled = true;
        }
        private void ClearText()
        {
            txtVehicleNo.Clear();
            txtBrand.Clear();
            txtModel.Clear();
            txtType.Clear();
            txtCurrentMileage.Clear();
            txtServiceMileageDue.Clear();
            txtOwnerName.Clear();
            dtpAddedDate.Value = DateTime.Now;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearText();
            EnableTrue();
            txtVehicleNo.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string VehicleNo = txtVehicleNo.Text.Trim();
            bool CheckVehicleNo = db.CheckVehicleNo(VehicleNo);

            if (CheckVehicleNo == true)
            {
                MessageBox.Show("This Vehicle No already added to Vehicle List");
            }
            else
            {
                Vehicle Vehi = new Vehicle
                {
                    vehicle_no = txtVehicleNo.Text.Trim(),
                    brand = txtBrand.Text.Trim(),
                    model = txtModel.Text.Trim(),
                    type = txtType.Text.Trim(),
                    current_mileage = Convert.ToInt32(txtCurrentMileage.Text),
                    service_mileage_due = Convert.ToInt32(txtServiceMileageDue.Text),
                    owner = txtOwnerName.Text.Trim(),
                    added_date = dtpAddedDate.Value
                };
                db.InsertVehicle(Collection, Vehi);
                ClearText();
                LoadForm();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            VehicleNo = txtVehicleNo.Text.Trim();
            Brand = txtBrand.Text.Trim();
            Model = txtModel.Text.Trim();
            Type = txtType.Text.Trim();
            CurrentMileage = Convert.ToInt32(txtCurrentMileage.Text);
            ServiceMileageDue = Convert.ToInt32(txtServiceMileageDue.Text);
            Owner = txtOwnerName.Text.Trim();
            AddedDate = dtpAddedDate.Value;

            db.UpdateVehicle(Collection, VehicleNo, Brand, Model, Type, CurrentMileage, ServiceMileageDue, AddedDate);
            ClearText();
            LoadForm();
            EnableFalse();
        }

        private void dgvVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtVehicleNo.Text = dgvVehicles.CurrentRow.Cells[0].Value.ToString();
            txtBrand.Text = dgvVehicles.CurrentRow.Cells[1].Value.ToString();
            txtModel.Text = dgvVehicles.CurrentRow.Cells[2].Value.ToString();
            txtType.Text = dgvVehicles.CurrentRow.Cells[3].Value.ToString();
            txtCurrentMileage.Text = dgvVehicles.CurrentRow.Cells[4].Value.ToString();
            txtServiceMileageDue.Text = dgvVehicles.CurrentRow.Cells[5].Value.ToString();
            txtOwnerName.Text = dgvVehicles.CurrentRow.Cells[6].Value.ToString();
            dtpAddedDate.Value = DateTime.Parse(dgvVehicles.CurrentRow.Cells[7].Value.ToString());
            EnableTrue();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.DeleteVehicle(txtVehicleNo.Text.Trim());
            LoadForm();
            ClearText();
            EnableFalse();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnableFalse();
            ClearText();
        }

        private void txtSearchVehicle_KeyUp(object sender, KeyEventArgs e)
        {
            string VehicleSearch = txtSearchVehicle.Text.Trim();
            dgvVehicles.DataSource = db.FilterVehicle(VehicleSearch);
        }
    }
}
