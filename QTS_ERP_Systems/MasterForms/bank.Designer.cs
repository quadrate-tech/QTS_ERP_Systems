﻿namespace QTS_ERP_Systems.MasterForms
{
    partial class bank
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
            this.dgvBank = new System.Windows.Forms.DataGridView();
            this.BanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bankname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancel = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.txtSearchBank = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBank)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBank
            // 
            this.dgvBank.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BanID,
            this.Bankname});
            this.dgvBank.Location = new System.Drawing.Point(23, 48);
            this.dgvBank.Name = "dgvBank";
            this.dgvBank.Size = new System.Drawing.Size(754, 237);
            this.dgvBank.TabIndex = 3;
            this.dgvBank.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
            // 
            // BanID
            // 
            this.BanID.HeaderText = "Bank ID";
            this.BanID.Name = "BanID";
            // 
            // Bankname
            // 
            this.Bankname.HeaderText = "Bank Name";
            this.Bankname.Name = "Bankname";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(638, 380);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(139, 40);
            this.cancel.TabIndex = 16;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(486, 381);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(146, 40);
            this.delete.TabIndex = 15;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(341, 381);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(139, 40);
            this.update.TabIndex = 14;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(176, 380);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(159, 41);
            this.save.TabIndex = 13;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(23, 380);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(147, 41);
            this.add.TabIndex = 12;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBank, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 291);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(754, 83);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank Name";
            // 
            // txtBank
            // 
            this.txtBank.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBank.Location = new System.Drawing.Point(380, 31);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(100, 20);
            this.txtBank.TabIndex = 1;
            // 
            // txtSearchBank
            // 
            this.txtSearchBank.Location = new System.Drawing.Point(123, 20);
            this.txtSearchBank.Name = "txtSearchBank";
            this.txtSearchBank.Size = new System.Drawing.Size(100, 20);
            this.txtSearchBank.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Search Bank";
            // 
            // bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSearchBank);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.save);
            this.Controls.Add(this.add);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvBank);
            this.Name = "bank";
            this.Text = "bank";
            this.Load += new System.EventHandler(this.ManageBank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBank)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn BanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bankname;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.TextBox txtSearchBank;
        private System.Windows.Forms.Label label2;
    }
}