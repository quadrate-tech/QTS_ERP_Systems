using System;
using System.Windows.Forms;
using QTS_ERP_Systems.MasterForms;

namespace QTS_ERP_Systems
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ManageCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ManageCategory))
                {
                    form.Activate();
                    return;
                }
            }

            ManageCategory manageCategory = new ManageCategory
            {
                MdiParent = this
            };
            manageCategory.Show();
        }

        private void manageEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ManageEmployee))
                {
                    form.Activate();
                    return;
                }
            }
            ManageEmployee manageEmployee = new ManageEmployee
            {
                MdiParent = this
            };
            manageEmployee.Show();
        }

        private void manageChequesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ManageCheques))
                {
                    form.Activate();
                    return;
                }
            }

            ManageCheques manageChq = new ManageCheques
            {
                MdiParent = this
            };
            manageChq.Show();
        }
    }
}
