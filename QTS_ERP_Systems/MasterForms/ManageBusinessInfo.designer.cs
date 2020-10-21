namespace QTS_ERP_Systems.MasterForms
{
    partial class ManageBusinessInfo
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
            this.BaseLayout = new System.Windows.Forms.TableLayoutPanel();
            this.DGVBusinessInfo = new System.Windows.Forms.DataGridView();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CRUDLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TxtContact = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BaseLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBusinessInfo)).BeginInit();
            this.CRUDLayout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseLayout
            // 
            this.BaseLayout.ColumnCount = 2;
            this.BaseLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.BaseLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BaseLayout.Controls.Add(this.DGVBusinessInfo, 0, 0);
            this.BaseLayout.Controls.Add(this.CRUDLayout, 0, 1);
            this.BaseLayout.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.BaseLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseLayout.Location = new System.Drawing.Point(0, 0);
            this.BaseLayout.Name = "BaseLayout";
            this.BaseLayout.RowCount = 2;
            this.BaseLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.31963F));
            this.BaseLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.68036F));
            this.BaseLayout.Size = new System.Drawing.Size(800, 450);
            this.BaseLayout.TabIndex = 2;
            // 
            // DGVBusinessInfo
            // 
            this.DGVBusinessInfo.AllowUserToAddRows = false;
            this.DGVBusinessInfo.AllowUserToDeleteRows = false;
            this.DGVBusinessInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVBusinessInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVBusinessInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVBusinessInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBusinessInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsActive});
            this.DGVBusinessInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVBusinessInfo.Location = new System.Drawing.Point(3, 3);
            this.DGVBusinessInfo.Name = "DGVBusinessInfo";
            this.DGVBusinessInfo.ReadOnly = true;
            this.DGVBusinessInfo.Size = new System.Drawing.Size(594, 310);
            this.DGVBusinessInfo.TabIndex = 0;
            this.DGVBusinessInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVBusinessInfo_CellClick);
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "Active";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            // 
            // CRUDLayout
            // 
            this.CRUDLayout.ColumnCount = 2;
            this.CRUDLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.09877F));
            this.CRUDLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.90124F));
            this.CRUDLayout.Controls.Add(this.TxtContact, 1, 3);
            this.CRUDLayout.Controls.Add(this.TxtAddress, 1, 2);
            this.CRUDLayout.Controls.Add(this.TxtName, 1, 1);
            this.CRUDLayout.Controls.Add(this.label3, 0, 1);
            this.CRUDLayout.Controls.Add(this.label1, 0, 0);
            this.CRUDLayout.Controls.Add(this.label2, 0, 2);
            this.CRUDLayout.Controls.Add(this.label4, 0, 3);
            this.CRUDLayout.Controls.Add(this.chBox, 1, 0);
            this.CRUDLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRUDLayout.Location = new System.Drawing.Point(3, 319);
            this.CRUDLayout.Name = "CRUDLayout";
            this.CRUDLayout.RowCount = 4;
            this.CRUDLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CRUDLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CRUDLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CRUDLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CRUDLayout.Size = new System.Drawing.Size(594, 128);
            this.CRUDLayout.TabIndex = 1;
            // 
            // TxtContact
            // 
            this.TxtContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtContact.Location = new System.Drawing.Point(193, 99);
            this.TxtContact.Name = "TxtContact";
            this.TxtContact.Size = new System.Drawing.Size(398, 20);
            this.TxtContact.TabIndex = 7;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtAddress.Location = new System.Drawing.Point(193, 67);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(398, 20);
            this.TxtAddress.TabIndex = 6;
            this.TxtAddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtAddress_KeyUp);
            // 
            // TxtName
            // 
            this.TxtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtName.Location = new System.Drawing.Point(193, 35);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(398, 20);
            this.TxtName.TabIndex = 5;
            this.TxtName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtName_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Business Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact";
            // 
            // chBox
            // 
            this.chBox.AutoSize = true;
            this.chBox.Location = new System.Drawing.Point(193, 3);
            this.chBox.Name = "chBox";
            this.chBox.Size = new System.Drawing.Size(80, 17);
            this.chBox.TabIndex = 8;
            this.chBox.Text = "checkBox1";
            this.chBox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.BtnSave, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.BtnDelete, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.BtnEdit, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnCancel, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(603, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(194, 310);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.White;
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSave.Location = new System.Drawing.Point(3, 251);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(188, 56);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.White;
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.Location = new System.Drawing.Point(3, 127);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(188, 56);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.White;
            this.BtnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEdit.Location = new System.Drawing.Point(3, 65);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(188, 56);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.White;
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAdd.Location = new System.Drawing.Point(3, 3);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(188, 56);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.White;
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancel.Location = new System.Drawing.Point(3, 189);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(188, 56);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // ManageBusinessInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BaseLayout);
            this.Name = "ManageBusinessInfo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ManageBusinessInfo_Load);
            this.BaseLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBusinessInfo)).EndInit();
            this.CRUDLayout.ResumeLayout(false);
            this.CRUDLayout.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BaseLayout;
        private System.Windows.Forms.DataGridView DGVBusinessInfo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.TableLayoutPanel CRUDLayout;
        private System.Windows.Forms.TextBox TxtContact;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnCancel;
    }
}