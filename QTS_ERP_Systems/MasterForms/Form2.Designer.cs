namespace QTS_ERP_Systems.MasterForms
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TxtSearchSuppliers = new System.Windows.Forms.TextBox();
            this.MessageTimer = new System.Windows.Forms.Timer(this.components);
            this.LblMessage = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtCodeNumber = new System.Windows.Forms.TextBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtContact = new System.Windows.Forms.TextBox();
            this.TxtSupplierName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSupplierId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CRUDPanel = new System.Windows.Forms.Panel();
            this.DGVSupplier = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.CRUDPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSupplier)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtSearchSuppliers
            // 
            this.TxtSearchSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtSearchSuppliers.Location = new System.Drawing.Point(246, 3);
            this.TxtSearchSuppliers.Name = "TxtSearchSuppliers";
            this.TxtSearchSuppliers.Size = new System.Drawing.Size(237, 20);
            this.TxtSearchSuppliers.TabIndex = 1;
            // 
            // MessageTimer
            // 
            this.MessageTimer.Enabled = true;
            this.MessageTimer.Interval = 6000;
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.ForeColor = System.Drawing.Color.Lime;
            this.LblMessage.Location = new System.Drawing.Point(-22, 476);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(35, 13);
            this.LblMessage.TabIndex = 8;
            this.LblMessage.Text = "label7";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(345, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(165, 73);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(174, 3);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(165, 73);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(3, 3);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(165, 73);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // TxtCodeNumber
            // 
            this.TxtCodeNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "CodeNumber", true));
            this.TxtCodeNumber.Location = new System.Drawing.Point(573, 93);
            this.TxtCodeNumber.Name = "TxtCodeNumber";
            this.TxtCodeNumber.Size = new System.Drawing.Size(278, 20);
            this.TxtCodeNumber.TabIndex = 11;
            // 
            // TxtEmail
            // 
            this.TxtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Email", true));
            this.TxtEmail.Location = new System.Drawing.Point(288, 93);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(278, 20);
            this.TxtEmail.TabIndex = 10;
            // 
            // TxtAddress
            // 
            this.TxtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Address", true));
            this.TxtAddress.Location = new System.Drawing.Point(3, 93);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(278, 20);
            this.TxtAddress.TabIndex = 9;
            // 
            // TxtContact
            // 
            this.TxtContact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Contact", true));
            this.TxtContact.Location = new System.Drawing.Point(573, 33);
            this.TxtContact.Name = "TxtContact";
            this.TxtContact.Size = new System.Drawing.Size(278, 20);
            this.TxtContact.TabIndex = 8;
            // 
            // TxtSupplierName
            // 
            this.TxtSupplierName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Name", true));
            this.TxtSupplierName.Location = new System.Drawing.Point(288, 33);
            this.TxtSupplierName.Name = "TxtSupplierName";
            this.TxtSupplierName.Size = new System.Drawing.Size(278, 20);
            this.TxtSupplierName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(573, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(288, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier Name";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(687, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(165, 73);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(516, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(165, 73);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(573, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Opening Balance";
            // 
            // TxtSupplierId
            // 
            this.TxtSupplierId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "SupplierId", true));
            this.TxtSupplierId.Location = new System.Drawing.Point(3, 33);
            this.TxtSupplierId.Name = "TxtSupplierId";
            this.TxtSupplierId.ReadOnly = true;
            this.TxtSupplierId.Size = new System.Drawing.Size(278, 20);
            this.TxtSupplierId.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(153, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 41);
            this.label7.TabIndex = 0;
            this.label7.Text = "Search Suppliers";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.TxtCodeNumber, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtEmail, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtAddress, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtContact, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtSupplierName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtSupplierId, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(855, 123);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(288, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.BtnSave, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnCancel, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnDelete, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnEdit, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnAdd, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(37, 403);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(855, 79);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // CRUDPanel
            // 
            this.CRUDPanel.Controls.Add(this.tableLayoutPanel1);
            this.CRUDPanel.Location = new System.Drawing.Point(37, 275);
            this.CRUDPanel.Name = "CRUDPanel";
            this.CRUDPanel.Size = new System.Drawing.Size(855, 135);
            this.CRUDPanel.TabIndex = 6;
            // 
            // DGVSupplier
            // 
            this.DGVSupplier.AllowUserToAddRows = false;
            this.DGVSupplier.AllowUserToDeleteRows = false;
            this.DGVSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSupplier.Location = new System.Drawing.Point(0, 39);
            this.DGVSupplier.Name = "DGVSupplier";
            this.DGVSupplier.ReadOnly = true;
            this.DGVSupplier.Size = new System.Drawing.Size(845, 230);
            this.DGVSupplier.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.TxtSearchSuppliers, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(973, 41);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 494);
            this.Controls.Add(this.LblMessage);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.CRUDPanel);
            this.Controls.Add(this.DGVSupplier);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.CRUDPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSupplier)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSearchSuppliers;
        private System.Windows.Forms.Timer MessageTimer;
        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtCodeNumber;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtContact;
        private System.Windows.Forms.TextBox TxtSupplierName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSupplierId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel CRUDPanel;
        private System.Windows.Forms.DataGridView DGVSupplier;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}