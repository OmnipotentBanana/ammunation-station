using _32582625_AmmunationStation.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32582625_AmmunationStation
{
    public partial class frmMain : Form
    {
        frmMaintainClients frmMaintainClients = new frmMaintainClients();
        frmPurchaseOrder frmPurchaseOrder = new frmPurchaseOrder();
        frmSalesOrder frmSellOrder = new frmSalesOrder();
        frmMaintainSuppliers frmMaintainSuppliers = new frmMaintainSuppliers();
        frmMaintainInventory frmMaintainInventory = new frmMaintainInventory();

        public frmMain()
        {
            InitializeComponent();
        }

        #region Close all forms code
        public void closeForms()
        {
            frmPurchaseOrder.Close();
            frmMaintainClients.Close();
            frmSellOrder.Close();
            frmMaintainSuppliers.Close();
            frmMaintainInventory.Close();
        }
        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            Employee employee = new Employee();
            if (!employee.getIsAdmin())
            {
                adminToolStripMenuItem.Visible = false;
            }
            this.MaximizeBox = false;
        }

        private void maintainClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaintainClients.Close();
            frmMaintainClients = new frmMaintainClients();
            frmMaintainClients.MdiParent = this;
            frmPurchaseOrder.Close();
            frmMaintainClients.Show();
        }

        private void placePurchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeForms();
            frmPurchaseOrder = new frmPurchaseOrder();
            frmPurchaseOrder.MdiParent = this;
            frmPurchaseOrder.Show();
        }

        private void receiveSellOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeForms();
            frmSellOrder = new frmSalesOrder();
            frmSellOrder.MdiParent = this;
            frmSellOrder.Show();
        }

        private void maintainSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeForms();
            frmMaintainSuppliers = new frmMaintainSuppliers();
            frmMaintainSuppliers.MdiParent = this;
            frmMaintainSuppliers.Show();
        }

        private void maintainInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeForms();
            frmMaintainInventory = new frmMaintainInventory();
            frmMaintainInventory.MdiParent = this;
            frmMaintainInventory.Show();
        }
    }
}
