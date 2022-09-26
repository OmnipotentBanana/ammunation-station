
namespace _32582625_AmmunationStation
{
    partial class frmPurchaseOrder
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
            this.grpPurchaseDetails = new System.Windows.Forms.GroupBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalQuantity = new System.Windows.Forms.Label();
            this.lblSupplierHelp = new System.Windows.Forms.Label();
            this.btnAddPurchaseOrder = new System.Windows.Forms.Button();
            this.lblPurchaseOrderNUM = new System.Windows.Forms.Label();
            this.lblTotalPricePaid = new System.Windows.Forms.Label();
            this.lblTotalQuantityOrdered = new System.Windows.Forms.Label();
            this.lblPurchaseOrderDate = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblPruchaseOrderNumber = new System.Windows.Forms.Label();
            this.txtPurchaseOrderDate = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.grpPurchaseOrderDGV = new System.Windows.Forms.GroupBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.btnClearList = new System.Windows.Forms.Button();
            this.lstItems = new System.Windows.Forms.ListView();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblItemCaliber = new System.Windows.Forms.Label();
            this.txtCaliber = new System.Windows.Forms.TextBox();
            this.lblItemMake = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.lblItemSerialNumber = new System.Windows.Forms.Label();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.lblInsertItems = new System.Windows.Forms.Label();
            this.lblSelectSupplier = new System.Windows.Forms.Label();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.btnCancelPurchaseOrder = new System.Windows.Forms.Button();
            this.grpPurchaseDetails.SuspendLayout();
            this.grpPurchaseOrderDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPurchaseDetails
            // 
            this.grpPurchaseDetails.Controls.Add(this.btnCancelPurchaseOrder);
            this.grpPurchaseDetails.Controls.Add(this.lblTotalPrice);
            this.grpPurchaseDetails.Controls.Add(this.lblTotalQuantity);
            this.grpPurchaseDetails.Controls.Add(this.lblSupplierHelp);
            this.grpPurchaseDetails.Controls.Add(this.btnAddPurchaseOrder);
            this.grpPurchaseDetails.Controls.Add(this.lblPurchaseOrderNUM);
            this.grpPurchaseDetails.Controls.Add(this.lblTotalPricePaid);
            this.grpPurchaseDetails.Controls.Add(this.lblTotalQuantityOrdered);
            this.grpPurchaseDetails.Controls.Add(this.lblPurchaseOrderDate);
            this.grpPurchaseDetails.Controls.Add(this.lblSupplierName);
            this.grpPurchaseDetails.Controls.Add(this.lblPruchaseOrderNumber);
            this.grpPurchaseDetails.Controls.Add(this.txtPurchaseOrderDate);
            this.grpPurchaseDetails.Controls.Add(this.txtSupplierName);
            this.grpPurchaseDetails.Location = new System.Drawing.Point(12, 12);
            this.grpPurchaseDetails.Name = "grpPurchaseDetails";
            this.grpPurchaseDetails.Size = new System.Drawing.Size(427, 563);
            this.grpPurchaseDetails.TabIndex = 0;
            this.grpPurchaseDetails.TabStop = false;
            this.grpPurchaseDetails.Text = "Purchase Order Details";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(204, 349);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(184, 23);
            this.lblTotalPrice.TabIndex = 6;
            // 
            // lblTotalQuantity
            // 
            this.lblTotalQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQuantity.Location = new System.Drawing.Point(204, 288);
            this.lblTotalQuantity.Name = "lblTotalQuantity";
            this.lblTotalQuantity.Size = new System.Drawing.Size(184, 23);
            this.lblTotalQuantity.TabIndex = 6;
            // 
            // lblSupplierHelp
            // 
            this.lblSupplierHelp.AutoSize = true;
            this.lblSupplierHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierHelp.ForeColor = System.Drawing.Color.Blue;
            this.lblSupplierHelp.Location = new System.Drawing.Point(395, 180);
            this.lblSupplierHelp.Name = "lblSupplierHelp";
            this.lblSupplierHelp.Size = new System.Drawing.Size(13, 13);
            this.lblSupplierHelp.TabIndex = 5;
            this.lblSupplierHelp.Text = "?";
            this.lblSupplierHelp.Click += new System.EventHandler(this.lblSupplierHelp_Click);
            // 
            // btnAddPurchaseOrder
            // 
            this.btnAddPurchaseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPurchaseOrder.Location = new System.Drawing.Point(142, 420);
            this.btnAddPurchaseOrder.Name = "btnAddPurchaseOrder";
            this.btnAddPurchaseOrder.Size = new System.Drawing.Size(155, 39);
            this.btnAddPurchaseOrder.TabIndex = 4;
            this.btnAddPurchaseOrder.Text = "Add Purchase Order";
            this.btnAddPurchaseOrder.UseVisualStyleBackColor = true;
            this.btnAddPurchaseOrder.Click += new System.EventHandler(this.btnAddPurchaseOrder_Click);
            // 
            // lblPurchaseOrderNUM
            // 
            this.lblPurchaseOrderNUM.AutoSize = true;
            this.lblPurchaseOrderNUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseOrderNUM.Location = new System.Drawing.Point(297, 116);
            this.lblPurchaseOrderNUM.Name = "lblPurchaseOrderNUM";
            this.lblPurchaseOrderNUM.Size = new System.Drawing.Size(0, 17);
            this.lblPurchaseOrderNUM.TabIndex = 3;
            // 
            // lblTotalPricePaid
            // 
            this.lblTotalPricePaid.AutoSize = true;
            this.lblTotalPricePaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPricePaid.Location = new System.Drawing.Point(69, 350);
            this.lblTotalPricePaid.Name = "lblTotalPricePaid";
            this.lblTotalPricePaid.Size = new System.Drawing.Size(112, 17);
            this.lblTotalPricePaid.TabIndex = 2;
            this.lblTotalPricePaid.Text = "Total Price Paid:";
            // 
            // lblTotalQuantityOrdered
            // 
            this.lblTotalQuantityOrdered.AutoSize = true;
            this.lblTotalQuantityOrdered.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQuantityOrdered.Location = new System.Drawing.Point(80, 288);
            this.lblTotalQuantityOrdered.Name = "lblTotalQuantityOrdered";
            this.lblTotalQuantityOrdered.Size = new System.Drawing.Size(101, 17);
            this.lblTotalQuantityOrdered.TabIndex = 2;
            this.lblTotalQuantityOrdered.Text = "Total Quantity:";
            // 
            // lblPurchaseOrderDate
            // 
            this.lblPurchaseOrderDate.AutoSize = true;
            this.lblPurchaseOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseOrderDate.Location = new System.Drawing.Point(34, 229);
            this.lblPurchaseOrderDate.Name = "lblPurchaseOrderDate";
            this.lblPurchaseOrderDate.Size = new System.Drawing.Size(147, 17);
            this.lblPurchaseOrderDate.TabIndex = 2;
            this.lblPurchaseOrderDate.Text = "Purchase Order Date:";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.Location = new System.Drawing.Point(159, 155);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(105, 17);
            this.lblSupplierName.TabIndex = 2;
            this.lblSupplierName.Text = "Supplier Name:";
            // 
            // lblPruchaseOrderNumber
            // 
            this.lblPruchaseOrderNumber.AutoSize = true;
            this.lblPruchaseOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPruchaseOrderNumber.Location = new System.Drawing.Point(124, 116);
            this.lblPruchaseOrderNumber.Name = "lblPruchaseOrderNumber";
            this.lblPruchaseOrderNumber.Size = new System.Drawing.Size(167, 17);
            this.lblPruchaseOrderNumber.TabIndex = 1;
            this.lblPruchaseOrderNumber.Text = "Purchase Order Number:";
            // 
            // txtPurchaseOrderDate
            // 
            this.txtPurchaseOrderDate.Enabled = false;
            this.txtPurchaseOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchaseOrderDate.Location = new System.Drawing.Point(204, 226);
            this.txtPurchaseOrderDate.Name = "txtPurchaseOrderDate";
            this.txtPurchaseOrderDate.Size = new System.Drawing.Size(184, 23);
            this.txtPurchaseOrderDate.TabIndex = 0;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.Location = new System.Drawing.Point(37, 175);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(351, 23);
            this.txtSupplierName.TabIndex = 0;
            this.txtSupplierName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSupplierName.TextChanged += new System.EventHandler(this.txtSupplierName_TextChanged);
            // 
            // grpPurchaseOrderDGV
            // 
            this.grpPurchaseOrderDGV.Controls.Add(this.txtModel);
            this.grpPurchaseOrderDGV.Controls.Add(this.lblModel);
            this.grpPurchaseOrderDGV.Controls.Add(this.btnClearList);
            this.grpPurchaseOrderDGV.Controls.Add(this.lstItems);
            this.grpPurchaseOrderDGV.Controls.Add(this.numQuantity);
            this.grpPurchaseOrderDGV.Controls.Add(this.btnAddItem);
            this.grpPurchaseOrderDGV.Controls.Add(this.label6);
            this.grpPurchaseOrderDGV.Controls.Add(this.label5);
            this.grpPurchaseOrderDGV.Controls.Add(this.txtCost);
            this.grpPurchaseOrderDGV.Controls.Add(this.lblType);
            this.grpPurchaseOrderDGV.Controls.Add(this.txtType);
            this.grpPurchaseOrderDGV.Controls.Add(this.lblItemCaliber);
            this.grpPurchaseOrderDGV.Controls.Add(this.txtCaliber);
            this.grpPurchaseOrderDGV.Controls.Add(this.lblItemMake);
            this.grpPurchaseOrderDGV.Controls.Add(this.txtMake);
            this.grpPurchaseOrderDGV.Controls.Add(this.lblItemSerialNumber);
            this.grpPurchaseOrderDGV.Controls.Add(this.txtSerialNumber);
            this.grpPurchaseOrderDGV.Controls.Add(this.lblInsertItems);
            this.grpPurchaseOrderDGV.Controls.Add(this.lblSelectSupplier);
            this.grpPurchaseOrderDGV.Controls.Add(this.dgvSuppliers);
            this.grpPurchaseOrderDGV.Location = new System.Drawing.Point(455, 12);
            this.grpPurchaseOrderDGV.Name = "grpPurchaseOrderDGV";
            this.grpPurchaseOrderDGV.Size = new System.Drawing.Size(774, 563);
            this.grpPurchaseOrderDGV.TabIndex = 1;
            this.grpPurchaseOrderDGV.TabStop = false;
            this.grpPurchaseOrderDGV.Text = "Purchase Order Data";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(548, 319);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(132, 20);
            this.txtModel.TabIndex = 22;
            this.txtModel.Text = "Model 1866";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(503, 322);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 21;
            this.lblModel.Text = "Model:";
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(390, 391);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(75, 23);
            this.btnClearList.TabIndex = 19;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // lstItems
            // 
            this.lstItems.HideSelection = false;
            this.lstItems.Location = new System.Drawing.Point(26, 420);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(724, 137);
            this.lstItems.TabIndex = 18;
            this.lstItems.UseCompatibleStateImageBehavior = false;
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(232, 394);
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(41, 20);
            this.numQuantity.TabIndex = 17;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(289, 391);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 15;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cost:";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(548, 361);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(132, 20);
            this.txtCost.TabIndex = 11;
            this.txtCost.Text = "2500";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(311, 364);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 10;
            this.lblType.Text = "Type:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(351, 358);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(132, 20);
            this.txtType.TabIndex = 9;
            this.txtType.Text = "Lever-Action Rifle";
            // 
            // lblItemCaliber
            // 
            this.lblItemCaliber.AutoSize = true;
            this.lblItemCaliber.Location = new System.Drawing.Point(111, 361);
            this.lblItemCaliber.Name = "lblItemCaliber";
            this.lblItemCaliber.Size = new System.Drawing.Size(42, 13);
            this.lblItemCaliber.TabIndex = 8;
            this.lblItemCaliber.Text = "Caliber:";
            // 
            // txtCaliber
            // 
            this.txtCaliber.Location = new System.Drawing.Point(159, 358);
            this.txtCaliber.Name = "txtCaliber";
            this.txtCaliber.Size = new System.Drawing.Size(132, 20);
            this.txtCaliber.TabIndex = 7;
            this.txtCaliber.Text = ".44 Henry";
            // 
            // lblItemMake
            // 
            this.lblItemMake.AutoSize = true;
            this.lblItemMake.Location = new System.Drawing.Point(308, 322);
            this.lblItemMake.Name = "lblItemMake";
            this.lblItemMake.Size = new System.Drawing.Size(37, 13);
            this.lblItemMake.TabIndex = 6;
            this.lblItemMake.Text = "Make:";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(351, 319);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(132, 20);
            this.txtMake.TabIndex = 5;
            this.txtMake.Text = "Winchester";
            // 
            // lblItemSerialNumber
            // 
            this.lblItemSerialNumber.AutoSize = true;
            this.lblItemSerialNumber.Location = new System.Drawing.Point(77, 322);
            this.lblItemSerialNumber.Name = "lblItemSerialNumber";
            this.lblItemSerialNumber.Size = new System.Drawing.Size(76, 13);
            this.lblItemSerialNumber.TabIndex = 4;
            this.lblItemSerialNumber.Text = "Serial Number:";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(159, 319);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(132, 20);
            this.txtSerialNumber.TabIndex = 3;
            this.txtSerialNumber.Text = "2148ABD12";
            // 
            // lblInsertItems
            // 
            this.lblInsertItems.AutoSize = true;
            this.lblInsertItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertItems.Location = new System.Drawing.Point(68, 303);
            this.lblInsertItems.Name = "lblInsertItems";
            this.lblInsertItems.Size = new System.Drawing.Size(205, 13);
            this.lblInsertItems.TabIndex = 2;
            this.lblInsertItems.Text = "Insert Items to Order from Supplier:";
            // 
            // lblSelectSupplier
            // 
            this.lblSelectSupplier.AutoSize = true;
            this.lblSelectSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSupplier.Location = new System.Drawing.Point(23, 27);
            this.lblSelectSupplier.Name = "lblSelectSupplier";
            this.lblSelectSupplier.Size = new System.Drawing.Size(106, 13);
            this.lblSelectSupplier.TabIndex = 1;
            this.lblSelectSupplier.Text = "Select a supplier:";
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.AllowUserToDeleteRows = false;
            this.dgvSuppliers.AllowUserToResizeColumns = false;
            this.dgvSuppliers.AllowUserToResizeRows = false;
            this.dgvSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.Location = new System.Drawing.Point(26, 43);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliers.Size = new System.Drawing.Size(724, 254);
            this.dgvSuppliers.TabIndex = 0;
            this.dgvSuppliers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSuppliers_CellMouseClick);
            // 
            // btnCancelPurchaseOrder
            // 
            this.btnCancelPurchaseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelPurchaseOrder.Location = new System.Drawing.Point(142, 488);
            this.btnCancelPurchaseOrder.Name = "btnCancelPurchaseOrder";
            this.btnCancelPurchaseOrder.Size = new System.Drawing.Size(155, 38);
            this.btnCancelPurchaseOrder.TabIndex = 7;
            this.btnCancelPurchaseOrder.Text = "Clear Order";
            this.btnCancelPurchaseOrder.UseVisualStyleBackColor = true;
            this.btnCancelPurchaseOrder.Click += new System.EventHandler(this.btnCancelPurchaseOrder_Click);
            // 
            // frmPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 587);
            this.Controls.Add(this.grpPurchaseOrderDGV);
            this.Controls.Add(this.grpPurchaseDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPurchaseOrder";
            this.Text = "frmPurchaseOrder";
            this.Load += new System.EventHandler(this.frmPurchaseOrder_Load);
            this.grpPurchaseDetails.ResumeLayout(false);
            this.grpPurchaseDetails.PerformLayout();
            this.grpPurchaseOrderDGV.ResumeLayout(false);
            this.grpPurchaseOrderDGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPurchaseDetails;
        private System.Windows.Forms.GroupBox grpPurchaseOrderDGV;
        private System.Windows.Forms.TextBox txtPurchaseOrderDate;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label lblPruchaseOrderNumber;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblTotalPricePaid;
        private System.Windows.Forms.Label lblTotalQuantityOrdered;
        private System.Windows.Forms.Label lblPurchaseOrderDate;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.Label lblSelectSupplier;
        private System.Windows.Forms.Label lblPurchaseOrderNUM;
        private System.Windows.Forms.Label lblInsertItems;
        private System.Windows.Forms.Label lblItemSerialNumber;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblItemCaliber;
        private System.Windows.Forms.TextBox txtCaliber;
        private System.Windows.Forms.Label lblItemMake;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.ListView lstItems;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnAddPurchaseOrder;
        private System.Windows.Forms.Label lblSupplierHelp;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblTotalQuantity;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnCancelPurchaseOrder;
    }
}