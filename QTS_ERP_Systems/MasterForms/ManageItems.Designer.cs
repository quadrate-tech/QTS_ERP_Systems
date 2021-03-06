﻿namespace QTS_ERP_Systems.MasterForms
{
    partial class ManageItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageItems));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.CmbCategories = new System.Windows.Forms.ComboBox();
            this.CmbShelf = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtItemId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblMessage = new System.Windows.Forms.Label();
            this.BtnAddCategory = new System.Windows.Forms.Button();
            this.BtnAddShelf = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtItemCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtItemName = new System.Windows.Forms.TextBox();
            this.TxtSellingPrice = new System.Windows.Forms.TextBox();
            this.TimerMessage = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.BaseLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelCRUD = new System.Windows.Forms.TableLayoutPanel();
            this.ChkBoxIsService = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtUnitCost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbUnit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtPrintableName = new System.Windows.Forms.TextBox();
            this.DGVItems = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtFilterItems = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.BaseLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(678, 602);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(488, 69);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.White;
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSave.Location = new System.Drawing.Point(391, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(94, 63);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.White;
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancel.Location = new System.Drawing.Point(294, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(91, 63);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.White;
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.Location = new System.Drawing.Point(197, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(91, 63);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.White;
            this.BtnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEdit.Location = new System.Drawing.Point(100, 3);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(91, 63);
            this.BtnEdit.TabIndex = 12;
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
            this.BtnAdd.Size = new System.Drawing.Size(91, 63);
            this.BtnAdd.TabIndex = 11;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // CmbCategories
            // 
            this.CmbCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategories.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmbCategories.FormattingEnabled = true;
            this.CmbCategories.Location = new System.Drawing.Point(117, 3);
            this.CmbCategories.Name = "CmbCategories";
            this.CmbCategories.Size = new System.Drawing.Size(318, 28);
            this.CmbCategories.TabIndex = 10;
            // 
            // CmbShelf
            // 
            this.CmbShelf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbShelf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbShelf.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmbShelf.FormattingEnabled = true;
            this.CmbShelf.Location = new System.Drawing.Point(117, 55);
            this.CmbShelf.Name = "CmbShelf";
            this.CmbShelf.Size = new System.Drawing.Size(318, 28);
            this.CmbShelf.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Categories";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(3, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Shelf";
            // 
            // TxtItemId
            // 
            this.TxtItemId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtItemId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtItemId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtItemId.Location = new System.Drawing.Point(117, 107);
            this.TxtItemId.Name = "TxtItemId";
            this.TxtItemId.ReadOnly = true;
            this.TxtItemId.Size = new System.Drawing.Size(318, 26);
            this.TxtItemId.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(3, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Selling Price";
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblMessage.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.ForeColor = System.Drawing.Color.LawnGreen;
            this.LblMessage.Location = new System.Drawing.Point(3, 599);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(669, 75);
            this.LblMessage.TabIndex = 3;
            this.LblMessage.Text = "Message";
            // 
            // BtnAddCategory
            // 
            this.BtnAddCategory.BackColor = System.Drawing.Color.White;
            this.BtnAddCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAddCategory.Location = new System.Drawing.Point(441, 3);
            this.BtnAddCategory.Name = "BtnAddCategory";
            this.BtnAddCategory.Size = new System.Drawing.Size(44, 46);
            this.BtnAddCategory.TabIndex = 13;
            this.BtnAddCategory.Text = "+";
            this.BtnAddCategory.UseVisualStyleBackColor = false;
            // 
            // BtnAddShelf
            // 
            this.BtnAddShelf.BackColor = System.Drawing.Color.White;
            this.BtnAddShelf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAddShelf.Location = new System.Drawing.Point(441, 55);
            this.BtnAddShelf.Name = "BtnAddShelf";
            this.BtnAddShelf.Size = new System.Drawing.Size(44, 46);
            this.BtnAddShelf.TabIndex = 18;
            this.BtnAddShelf.Text = "+";
            this.BtnAddShelf.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(3, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Item Id";
            // 
            // TxtItemCode
            // 
            this.TxtItemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtItemCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtItemCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtItemCode.Location = new System.Drawing.Point(117, 159);
            this.TxtItemCode.Name = "TxtItemCode";
            this.TxtItemCode.Size = new System.Drawing.Size(318, 26);
            this.TxtItemCode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Name";
            // 
            // TxtItemName
            // 
            this.TxtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtItemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtItemName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtItemName.Location = new System.Drawing.Point(117, 211);
            this.TxtItemName.Name = "TxtItemName";
            this.TxtItemName.Size = new System.Drawing.Size(318, 26);
            this.TxtItemName.TabIndex = 2;
            // 
            // TxtSellingPrice
            // 
            this.TxtSellingPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSellingPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtSellingPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSellingPrice.Location = new System.Drawing.Point(117, 419);
            this.TxtSellingPrice.Name = "TxtSellingPrice";
            this.TxtSellingPrice.Size = new System.Drawing.Size(318, 26);
            this.TxtSellingPrice.TabIndex = 5;
            // 
            // TimerMessage
            // 
            this.TimerMessage.Enabled = true;
            this.TimerMessage.Interval = 6000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Code";
            // 
            // BaseLayout
            // 
            this.BaseLayout.BackColor = System.Drawing.Color.DimGray;
            this.BaseLayout.ColumnCount = 2;
            this.BaseLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.76F));
            this.BaseLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.24F));
            this.BaseLayout.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.BaseLayout.Controls.Add(this.panel1, 1, 1);
            this.BaseLayout.Controls.Add(this.LblMessage, 0, 2);
            this.BaseLayout.Controls.Add(this.DGVItems, 0, 1);
            this.BaseLayout.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.BaseLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseLayout.Location = new System.Drawing.Point(0, 0);
            this.BaseLayout.Name = "BaseLayout";
            this.BaseLayout.RowCount = 3;
            this.BaseLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.90909F));
            this.BaseLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.18182F));
            this.BaseLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.90909F));
            this.BaseLayout.Size = new System.Drawing.Size(1169, 674);
            this.BaseLayout.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PanelCRUD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(678, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 520);
            this.panel1.TabIndex = 2;
            // 
            // PanelCRUD
            // 
            this.PanelCRUD.ColumnCount = 3;
            this.PanelCRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.54968F));
            this.PanelCRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.43692F));
            this.PanelCRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0134F));
            this.PanelCRUD.Controls.Add(this.CmbCategories, 1, 0);
            this.PanelCRUD.Controls.Add(this.CmbShelf, 1, 1);
            this.PanelCRUD.Controls.Add(this.label5, 0, 0);
            this.PanelCRUD.Controls.Add(this.label8, 0, 1);
            this.PanelCRUD.Controls.Add(this.TxtItemId, 1, 2);
            this.PanelCRUD.Controls.Add(this.label4, 0, 8);
            this.PanelCRUD.Controls.Add(this.BtnAddCategory, 2, 0);
            this.PanelCRUD.Controls.Add(this.BtnAddShelf, 2, 1);
            this.PanelCRUD.Controls.Add(this.label6, 0, 2);
            this.PanelCRUD.Controls.Add(this.TxtItemCode, 1, 3);
            this.PanelCRUD.Controls.Add(this.label2, 0, 4);
            this.PanelCRUD.Controls.Add(this.label1, 0, 3);
            this.PanelCRUD.Controls.Add(this.TxtItemName, 1, 4);
            this.PanelCRUD.Controls.Add(this.TxtSellingPrice, 1, 8);
            this.PanelCRUD.Controls.Add(this.ChkBoxIsService, 1, 9);
            this.PanelCRUD.Controls.Add(this.label9, 0, 9);
            this.PanelCRUD.Controls.Add(this.TxtUnitCost, 1, 7);
            this.PanelCRUD.Controls.Add(this.label7, 0, 7);
            this.PanelCRUD.Controls.Add(this.CmbUnit, 1, 6);
            this.PanelCRUD.Controls.Add(this.label3, 0, 6);
            this.PanelCRUD.Controls.Add(this.label10, 0, 5);
            this.PanelCRUD.Controls.Add(this.TxtPrintableName, 1, 5);
            this.PanelCRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCRUD.Location = new System.Drawing.Point(0, 0);
            this.PanelCRUD.Name = "PanelCRUD";
            this.PanelCRUD.RowCount = 10;
            this.PanelCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelCRUD.Size = new System.Drawing.Size(488, 520);
            this.PanelCRUD.TabIndex = 2;
            // 
            // ChkBoxIsService
            // 
            this.ChkBoxIsService.AutoSize = true;
            this.ChkBoxIsService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChkBoxIsService.ForeColor = System.Drawing.Color.White;
            this.ChkBoxIsService.Location = new System.Drawing.Point(117, 471);
            this.ChkBoxIsService.Name = "ChkBoxIsService";
            this.ChkBoxIsService.Size = new System.Drawing.Size(318, 46);
            this.ChkBoxIsService.TabIndex = 6;
            this.ChkBoxIsService.Text = "Check If Yes";
            this.ChkBoxIsService.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Is Service";
            // 
            // TxtUnitCost
            // 
            this.TxtUnitCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUnitCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtUnitCost.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUnitCost.Location = new System.Drawing.Point(117, 367);
            this.TxtUnitCost.Name = "TxtUnitCost";
            this.TxtUnitCost.Size = new System.Drawing.Size(318, 26);
            this.TxtUnitCost.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(3, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Unit Cost";
            // 
            // CmbUnit
            // 
            this.CmbUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUnit.FormattingEnabled = true;
            this.CmbUnit.Items.AddRange(new object[] {
            "PCS",
            "DRUM",
            "PAIL",
            "PCKT",
            "FEET",
            "INCHES",
            "LITRE",
            "KILO GRAM",
            "GRAM",
            "MILLI LITRE"});
            this.CmbUnit.Location = new System.Drawing.Point(117, 315);
            this.CmbUnit.Name = "CmbUnit";
            this.CmbUnit.Size = new System.Drawing.Size(318, 28);
            this.CmbUnit.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(3, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Unit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 40);
            this.label10.TabIndex = 21;
            this.label10.Text = "Printable Name";
            // 
            // TxtPrintableName
            // 
            this.TxtPrintableName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrintableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtPrintableName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrintableName.Location = new System.Drawing.Point(117, 263);
            this.TxtPrintableName.Name = "TxtPrintableName";
            this.TxtPrintableName.Size = new System.Drawing.Size(318, 26);
            this.TxtPrintableName.TabIndex = 3;
            // 
            // DGVItems
            // 
            this.DGVItems.AllowUserToAddRows = false;
            this.DGVItems.AllowUserToDeleteRows = false;
            this.DGVItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVItems.Location = new System.Drawing.Point(4, 78);
            this.DGVItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGVItems.Name = "DGVItems";
            this.DGVItems.ReadOnly = true;
            this.DGVItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVItems.Size = new System.Drawing.Size(667, 516);
            this.DGVItems.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtFilterItems, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(669, 67);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Right;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(93, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 47);
            this.label11.TabIndex = 0;
            this.label11.Text = "Search Items";
            // 
            // TxtFilterItems
            // 
            this.TxtFilterItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtFilterItems.Location = new System.Drawing.Point(203, 23);
            this.TxtFilterItems.Name = "TxtFilterItems";
            this.TxtFilterItems.Size = new System.Drawing.Size(463, 26);
            this.TxtFilterItems.TabIndex = 1;
            // 
            // ManageItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1169, 674);
            this.Controls.Add(this.BaseLayout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageItems";
            this.Text = "Manage Items";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.BaseLayout.ResumeLayout(false);
            this.BaseLayout.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.PanelCRUD.ResumeLayout(false);
            this.PanelCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ComboBox CmbCategories;
        private System.Windows.Forms.ComboBox CmbShelf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtItemId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.Button BtnAddCategory;
        private System.Windows.Forms.Button BtnAddShelf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtItemCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtItemName;
        private System.Windows.Forms.TextBox TxtSellingPrice;
        private System.Windows.Forms.Timer TimerMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel BaseLayout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel PanelCRUD;
        private System.Windows.Forms.CheckBox ChkBoxIsService;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtUnitCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtPrintableName;
        private System.Windows.Forms.DataGridView DGVItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtFilterItems;
    }
}