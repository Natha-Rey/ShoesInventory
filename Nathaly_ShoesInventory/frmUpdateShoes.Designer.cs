namespace Nathaly_ShoesInventory
{
    partial class frmUpdateShoes
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
            this.mnuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateShoe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptionsChangeFC = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuOptionsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.picShoes = new System.Windows.Forms.PictureBox();
            this.lblShoeStyle = new System.Windows.Forms.Label();
            this.cmbShoeStyles = new System.Windows.Forms.ComboBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lstShoesStock = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShoes)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUpdate,
            this.mnuOptions});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(415, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuUpdate
            // 
            this.mnuUpdate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUpdateShoe});
            this.mnuUpdate.Name = "mnuUpdate";
            this.mnuUpdate.Size = new System.Drawing.Size(57, 20);
            this.mnuUpdate.Text = "&Update";
            // 
            // mnuUpdateShoe
            // 
            this.mnuUpdateShoe.Name = "mnuUpdateShoe";
            this.mnuUpdateShoe.Size = new System.Drawing.Size(180, 22);
            this.mnuUpdateShoe.Text = "&Shoe...";
            this.mnuUpdateShoe.Click += new System.EventHandler(this.mnuUpdateShoe_Click);
            // 
            // mnuOptions
            // 
            this.mnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptionsChangeFC,
            this.toolStripSeparator1,
            this.mnuOptionsExit});
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(61, 20);
            this.mnuOptions.Text = "&Options";
            // 
            // mnuOptionsChangeFC
            // 
            this.mnuOptionsChangeFC.Name = "mnuOptionsChangeFC";
            this.mnuOptionsChangeFC.Size = new System.Drawing.Size(180, 22);
            this.mnuOptionsChangeFC.Text = "&Change Forecolor...";
            this.mnuOptionsChangeFC.Click += new System.EventHandler(this.mnuOptionsChangeFC_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // mnuOptionsExit
            // 
            this.mnuOptionsExit.Name = "mnuOptionsExit";
            this.mnuOptionsExit.ShowShortcutKeys = false;
            this.mnuOptionsExit.Size = new System.Drawing.Size(180, 22);
            this.mnuOptionsExit.Text = "&Exit";
            this.mnuOptionsExit.Click += new System.EventHandler(this.mnuOptionsExit_Click);
            // 
            // picShoes
            // 
            this.picShoes.Location = new System.Drawing.Point(161, 37);
            this.picShoes.Name = "picShoes";
            this.picShoes.Size = new System.Drawing.Size(226, 177);
            this.picShoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShoes.TabIndex = 1;
            this.picShoes.TabStop = false;
            // 
            // lblShoeStyle
            // 
            this.lblShoeStyle.AutoSize = true;
            this.lblShoeStyle.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoeStyle.Location = new System.Drawing.Point(12, 47);
            this.lblShoeStyle.Name = "lblShoeStyle";
            this.lblShoeStyle.Size = new System.Drawing.Size(100, 18);
            this.lblShoeStyle.TabIndex = 2;
            this.lblShoeStyle.Text = "Shoe Styles";
            // 
            // cmbShoeStyles
            // 
            this.cmbShoeStyles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShoeStyles.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbShoeStyles.FormattingEnabled = true;
            this.cmbShoeStyles.Location = new System.Drawing.Point(12, 77);
            this.cmbShoeStyles.Name = "cmbShoeStyles";
            this.cmbShoeStyles.Size = new System.Drawing.Size(121, 23);
            this.cmbShoeStyles.TabIndex = 3;
            this.cmbShoeStyles.SelectedIndexChanged += new System.EventHandler(this.cmbShoeStyles_SelectedIndexChanged);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.SystemColors.Control;
            this.lblStock.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(12, 197);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(73, 17);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "In stock:";
            // 
            // lstShoesStock
            // 
            this.lstShoesStock.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstShoesStock.FormattingEnabled = true;
            this.lstShoesStock.ItemHeight = 17;
            this.lstShoesStock.Location = new System.Drawing.Point(12, 233);
            this.lstShoesStock.Name = "lstShoesStock";
            this.lstShoesStock.Size = new System.Drawing.Size(383, 140);
            this.lstShoesStock.TabIndex = 5;
           
            // 
            // frmUpdateShoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 393);
            this.Controls.Add(this.lstShoesStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.cmbShoeStyles);
            this.Controls.Add(this.lblShoeStyle);
            this.Controls.Add(this.picShoes);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmUpdateShoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Shoes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateShoe;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuOptionsChangeFC;
        private System.Windows.Forms.ToolStripMenuItem mnuOptionsExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox picShoes;
        private System.Windows.Forms.Label lblShoeStyle;
        private System.Windows.Forms.ComboBox cmbShoeStyles;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.ListBox lstShoesStock;
    }
}

