namespace QTS_ERP_Systems.MasterForms
{
    partial class ManageSupplier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.BTNCANEL = new System.Windows.Forms.Button();
            this.BTNUPDATE = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BTNADD = new System.Windows.Forms.Button();
            this.BTNDELETE = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearchISupply = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtOpeningBalance = new System.Windows.Forms.TextBox();
            this.supplierEmail = new System.Windows.Forms.TextBox();
            this.txtSupplierAddress = new System.Windows.Forms.TextBox();
            this.txtSupplierContact = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSupplierId = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tableLayoutPanel4.Controls.Add(this.BTNCANEL, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.BTNUPDATE, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtnSave, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.BTNADD, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.BTNDELETE, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 450);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(929, 86);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // BTNCANEL
            // 
            this.BTNCANEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNCANEL.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.BTNCANEL.Location = new System.Drawing.Point(714, 3);
            this.BTNCANEL.Name = "BTNCANEL";
            this.BTNCANEL.Size = new System.Drawing.Size(212, 80);
            this.BTNCANEL.TabIndex = 4;
            this.BTNCANEL.Text = "CANCEL";
            this.BTNCANEL.UseVisualStyleBackColor = true;
            this.BTNCANEL.Click += new System.EventHandler(this.BTNCANEL_Click);
            // 
            // BTNUPDATE
            // 
            this.BTNUPDATE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNUPDATE.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.BTNUPDATE.Location = new System.Drawing.Point(345, 3);
            this.BTNUPDATE.Name = "BTNUPDATE";
            this.BTNUPDATE.Size = new System.Drawing.Size(179, 80);
            this.BTNUPDATE.TabIndex = 2;
            this.BTNUPDATE.Text = "UPDATE";
            this.BTNUPDATE.UseVisualStyleBackColor = true;
            this.BTNUPDATE.Click += new System.EventHandler(this.BTNUPDATE_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSave.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(173, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(166, 80);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "SAVE";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BTNADD
            // 
            this.BTNADD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNADD.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.BTNADD.Location = new System.Drawing.Point(3, 3);
            this.BTNADD.Name = "BTNADD";
            this.BTNADD.Size = new System.Drawing.Size(164, 80);
            this.BTNADD.TabIndex = 0;
            this.BTNADD.Text = "ADD";
            this.BTNADD.UseVisualStyleBackColor = true;
            this.BTNADD.Click += new System.EventHandler(this.BTNADD_Click);
            // 
            // BTNDELETE
            // 
            this.BTNDELETE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNDELETE.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.BTNDELETE.Location = new System.Drawing.Point(530, 3);
            this.BTNDELETE.Name = "BTNDELETE";
            this.BTNDELETE.Size = new System.Drawing.Size(178, 80);
            this.BTNDELETE.TabIndex = 3;
            this.BTNDELETE.Text = "DELETE";
            this.BTNDELETE.UseVisualStyleBackColor = true;
            this.BTNDELETE.Click += new System.EventHandler(this.BTNDELETE_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.55422F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 312F));
            this.tableLayoutPanel5.Controls.Add(this.txtSearchISupply, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(493, 33);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // txtSearchISupply
            // 
            this.txtSearchISupply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchISupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchISupply.Location = new System.Drawing.Point(184, 3);
            this.txtSearchISupply.Name = "txtSearchISupply";
            this.txtSearchISupply.Size = new System.Drawing.Size(306, 26);
            this.txtSearchISupply.TabIndex = 15;
            this.txtSearchISupply.TabStop = false;
            this.txtSearchISupply.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchISupply_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 33);
            this.label10.TabIndex = 16;
            this.label10.Text = "Search Suppliers";
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSupplier.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSupplier.Location = new System.Drawing.Point(3, 46);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.Size = new System.Drawing.Size(929, 262);
            this.dgvSupplier.TabIndex = 3;
            this.dgvSupplier.TabStop = false;
            this.dgvSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Supplier_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.27988F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.720122F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvSupplier, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 268F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(992, 539);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.txtOpeningBalance, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.supplierEmail, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtSupplierAddress, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtSupplierContact, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtSupplierName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.TxtSupplierId, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 314);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(929, 130);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // txtOpeningBalance
            // 
            this.txtOpeningBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOpeningBalance.Location = new System.Drawing.Point(621, 99);
            this.txtOpeningBalance.Name = "txtOpeningBalance";
            this.txtOpeningBalance.Size = new System.Drawing.Size(305, 20);
            this.txtOpeningBalance.TabIndex = 11;
            // 
            // supplierEmail
            // 
            this.supplierEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplierEmail.Location = new System.Drawing.Point(312, 99);
            this.supplierEmail.Name = "supplierEmail";
            this.supplierEmail.Size = new System.Drawing.Size(303, 20);
            this.supplierEmail.TabIndex = 10;
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSupplierAddress.Location = new System.Drawing.Point(3, 99);
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.Size = new System.Drawing.Size(303, 20);
            this.txtSupplierAddress.TabIndex = 9;
            // 
            // txtSupplierContact
            // 
            this.txtSupplierContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSupplierContact.Location = new System.Drawing.Point(621, 35);
            this.txtSupplierContact.Name = "txtSupplierContact";
            this.txtSupplierContact.Size = new System.Drawing.Size(305, 20);
            this.txtSupplierContact.TabIndex = 8;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSupplierName.Location = new System.Drawing.Point(312, 35);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(303, 20);
            this.txtSupplierName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(621, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(312, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(312, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(621, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Opening Balance";
            // 
            // TxtSupplierId
            // 
            this.TxtSupplierId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtSupplierId.Location = new System.Drawing.Point(3, 35);
            this.TxtSupplierId.Name = "TxtSupplierId";
            this.TxtSupplierId.ReadOnly = true;
            this.TxtSupplierId.Size = new System.Drawing.Size(303, 20);
            this.TxtSupplierId.TabIndex = 6;
            this.TxtSupplierId.TextChanged += new System.EventHandler(this.TxtSupplierId_TextChanged);
            // 
            // ManageSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 539);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ManageSupplier";
            this.Text = "ManageSupplier";
            this.Load += new System.EventHandler(this.ManageSupplier_Load);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button BTNCANEL;
        private System.Windows.Forms.Button BTNUPDATE;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BTNADD;
        private System.Windows.Forms.Button BTNDELETE;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearchISupply;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtOpeningBalance;
        private System.Windows.Forms.TextBox supplierEmail;
        private System.Windows.Forms.TextBox txtSupplierAddress;
        private System.Windows.Forms.TextBox txtSupplierContact;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSupplierId;
    }
}