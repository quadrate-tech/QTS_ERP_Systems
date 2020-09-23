namespace QTS_ERP_Systems
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterFormsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1172, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterFormsToolStripMenuItem
            // 
            this.masterFormsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageCategoryToolStripMenuItem,
            this.ManageItemsToolStripMenuItem});
            this.masterFormsToolStripMenuItem.Name = "masterFormsToolStripMenuItem";
            this.masterFormsToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.masterFormsToolStripMenuItem.Text = "Master Forms";
            // 
            // ManageCategoryToolStripMenuItem
            // 
            this.ManageCategoryToolStripMenuItem.Name = "ManageCategoryToolStripMenuItem";
            this.ManageCategoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ManageCategoryToolStripMenuItem.Text = "Manage Category";
            this.ManageCategoryToolStripMenuItem.Click += new System.EventHandler(this.ManageCategoryToolStripMenuItem_Click);
            // 
            // ManageItemsToolStripMenuItem
            // 
            this.ManageItemsToolStripMenuItem.Name = "ManageItemsToolStripMenuItem";
            this.ManageItemsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ManageItemsToolStripMenuItem.Text = "Manage Items";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1172, 747);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Text = "Master";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterFormsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageItemsToolStripMenuItem;
    }
}

