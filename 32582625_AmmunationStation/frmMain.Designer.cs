
namespace _32582625_AmmunationStation
{
    partial class frmMain
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
            this.msMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placePurchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiveSellOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainSuppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenuStrip
            // 
            this.msMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.purchaseOrderToolStripMenuItem,
            this.sellOrderToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.msMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.msMenuStrip.Name = "msMenuStrip";
            this.msMenuStrip.Size = new System.Drawing.Size(1245, 24);
            this.msMenuStrip.TabIndex = 0;
            this.msMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintainClientsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.fileToolStripMenuItem.Text = "Maintenance";
            // 
            // maintainClientsToolStripMenuItem
            // 
            this.maintainClientsToolStripMenuItem.Name = "maintainClientsToolStripMenuItem";
            this.maintainClientsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.maintainClientsToolStripMenuItem.Text = "Maintain Clients";
            this.maintainClientsToolStripMenuItem.Click += new System.EventHandler(this.maintainClientsToolStripMenuItem_Click);
            // 
            // purchaseOrderToolStripMenuItem
            // 
            this.purchaseOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placePurchaseOrderToolStripMenuItem});
            this.purchaseOrderToolStripMenuItem.Name = "purchaseOrderToolStripMenuItem";
            this.purchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.purchaseOrderToolStripMenuItem.Text = "Purchase Order";
            // 
            // placePurchaseOrderToolStripMenuItem
            // 
            this.placePurchaseOrderToolStripMenuItem.Name = "placePurchaseOrderToolStripMenuItem";
            this.placePurchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.placePurchaseOrderToolStripMenuItem.Text = "Place Purchase Order";
            this.placePurchaseOrderToolStripMenuItem.Click += new System.EventHandler(this.placePurchaseOrderToolStripMenuItem_Click);
            // 
            // sellOrderToolStripMenuItem
            // 
            this.sellOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receiveSellOrderToolStripMenuItem});
            this.sellOrderToolStripMenuItem.Name = "sellOrderToolStripMenuItem";
            this.sellOrderToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.sellOrderToolStripMenuItem.Text = "Sell Order";
            // 
            // receiveSellOrderToolStripMenuItem
            // 
            this.receiveSellOrderToolStripMenuItem.Name = "receiveSellOrderToolStripMenuItem";
            this.receiveSellOrderToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.receiveSellOrderToolStripMenuItem.Text = "Receive Sell Order";
            this.receiveSellOrderToolStripMenuItem.Click += new System.EventHandler(this.receiveSellOrderToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateReportsToolStripMenuItem,
            this.maintainSuppliersToolStripMenuItem,
            this.maintainInventoryToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // generateReportsToolStripMenuItem
            // 
            this.generateReportsToolStripMenuItem.Name = "generateReportsToolStripMenuItem";
            this.generateReportsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generateReportsToolStripMenuItem.Text = "Generate Reports";
            // 
            // maintainSuppliersToolStripMenuItem
            // 
            this.maintainSuppliersToolStripMenuItem.Name = "maintainSuppliersToolStripMenuItem";
            this.maintainSuppliersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maintainSuppliersToolStripMenuItem.Text = "Maintain Suppliers";
            this.maintainSuppliersToolStripMenuItem.Click += new System.EventHandler(this.maintainSuppliersToolStripMenuItem_Click);
            // 
            // maintainInventoryToolStripMenuItem
            // 
            this.maintainInventoryToolStripMenuItem.Name = "maintainInventoryToolStripMenuItem";
            this.maintainInventoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maintainInventoryToolStripMenuItem.Text = "Maintain Inventory";
            this.maintainInventoryToolStripMenuItem.Click += new System.EventHandler(this.maintainInventoryToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 615);
            this.Controls.Add(this.msMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenuStrip;
            this.Name = "frmMain";
            this.Text = "Ammunation POS";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.msMenuStrip.ResumeLayout(false);
            this.msMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placePurchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiveSellOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainSuppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainInventoryToolStripMenuItem;
    }
}

