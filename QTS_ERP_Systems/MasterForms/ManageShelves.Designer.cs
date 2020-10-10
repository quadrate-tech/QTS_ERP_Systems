namespace QTS_ERP_Systems.MasterForms
{
    partial class ManageShelves
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtShelve_Name = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.dgvShelve = new System.Windows.Forms.DataGridView();
            this.ShelveId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShelveName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_searchShelve = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShelve)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtShelve_Name, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(691, 65);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Shelve Name";
            // 
            // txtShelve_Name
            // 
            this.txtShelve_Name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtShelve_Name.Location = new System.Drawing.Point(348, 22);
            this.txtShelve_Name.Name = "txtShelve_Name";
            this.txtShelve_Name.Size = new System.Drawing.Size(197, 20);
            this.txtShelve_Name.TabIndex = 3;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(380, 101);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 1;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(479, 134);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 2;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(573, 134);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // dgvShelve
            // 
            this.dgvShelve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShelve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShelve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShelveId,
            this.ShelveName});
            this.dgvShelve.Location = new System.Drawing.Point(32, 179);
            this.dgvShelve.Name = "dgvShelve";
            this.dgvShelve.Size = new System.Drawing.Size(745, 259);
            this.dgvShelve.TabIndex = 4;
            this.dgvShelve.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShelve_CellClick);
            // 
            // ShelveId
            // 
            this.ShelveId.HeaderText = "Shelve Id";
            this.ShelveId.Name = "ShelveId";
            // 
            // ShelveName
            // 
            this.ShelveName.HeaderText = "Shelve Name";
            this.ShelveName.Name = "ShelveName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search";
            // 
            // txt_searchShelve
            // 
            this.txt_searchShelve.Location = new System.Drawing.Point(123, 136);
            this.txt_searchShelve.Name = "txt_searchShelve";
            this.txt_searchShelve.Size = new System.Drawing.Size(100, 20);
            this.txt_searchShelve.TabIndex = 6;
            this.txt_searchShelve.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchShelve_KeyUp);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(253, 133);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 7;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(665, 134);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(380, 134);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 9;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // ManageShelves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.search);
            this.Controls.Add(this.txt_searchShelve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvShelve);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ManageShelves";
            this.Text = "ManageShelves";
            this.Load += new System.EventHandler(this.ManageShelve_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShelve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtShelve_Name;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView dgvShelve;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShelveId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShelveName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_searchShelve;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
    }
}