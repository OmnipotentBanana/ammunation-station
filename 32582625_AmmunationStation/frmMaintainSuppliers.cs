using _32582625_AmmunationStation.Classes.SalesRelated;
using _32582625_AmmunationStation.Classes.SqlFunctions;
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
    public partial class frmMaintainSuppliers : Form
    {
        SqlCommands sqlCommands = new SqlCommands();
        Supplier supplier;
        Supplier newSupplier = new Supplier();
        bool isValid = false;

        public frmMaintainSuppliers()
        {
            InitializeComponent();
        }

        private void frmMaintainSuppliers_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;

            refreshDGV();

            foreach (DataGridViewColumn column in dgvSuppliers.Columns)
            {
                cmbSupplierColumns.Items.Add(column.HeaderText.ToString());
            }
            cmbSupplierColumns.SelectedIndex = 0;

            disableEditing();
            disableTXTBoxes();
            btnEditSupplier.Enabled = false;
        }

        public void disableTXTBoxes()
        {
            txtLocation.Enabled = false;
            txtEmail.Enabled = false;
            txtSupplierName.Enabled = false;
        }

        public void enableTXTBoxes()
        {
            txtLocation.Enabled = true;
            txtEmail.Enabled = true;
            txtSupplierName.Enabled = true;   
        }

        public void enableEditing()
        {
            enableTXTBoxes();
            btnConfirmEdit.Visible = true;
            btnConfirmEdit.Enabled = false;
            btnCancelEdit.Visible = true;
            btnEditSupplier.Visible = false;
            dgvSuppliers.Enabled = false;
        }

        public void disableEditing()
        {
            disableTXTBoxes();
            btnConfirmEdit.Visible = false;
            btnConfirmEdit.Enabled = true;
            btnCancelEdit.Visible = false;
            btnEditSupplier.Visible = true;
            dgvSuppliers.Enabled = true;
        }

        public void clearDetails()
        {
            refreshDGV();

            lblSupplierIDNumber.Text = "";
            txtSupplierName.Text = "";
            txtLocation.Text = "";
            txtEmail.Text = "";
            btnEditSupplier.Enabled = false;

            supplier = new Supplier();
        }

        public void refreshDGV()
        {
            dgvSuppliers.DataSource = sqlCommands.sqlSelect("SELECT * FROM Supplier").Tables[0].DefaultView;
            txtSearchSupplier.Text = "";
        }

        public void fillTextBoxes(Supplier supplier)
        {
            txtSupplierName.Text = supplier.supplierName;
            txtLocation.Text = supplier.supplierLocation;
            txtEmail.Text = supplier.supplierEmail;
        }

        private void txtSearchSupplier_TextChanged(object sender, EventArgs e)
        {
            dgvSuppliers.DataSource = sqlCommands.sqlSelect($"SELECT * FROM Supplier WHERE {cmbSupplierColumns.Text} LIKE '%{txtSearchSupplier.Text}%'").Tables[0].DefaultView;
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            enableEditing();
        }

        private void dgvSuppliers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEditSupplier.Enabled = true;

            if (dgvSuppliers.SelectedRows.Count != 0)
            {
                try
                {
                    int index = dgvSuppliers.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvSuppliers.Rows[index];
                    supplier = new Supplier(Convert.ToInt32(selectedRow.Cells[0].Value), selectedRow.Cells[1].Value.ToString(), selectedRow.Cells[2].Value.ToString(), selectedRow.Cells[3].Value.ToString());
                    
                    lblSupplierIDNumber.Text = supplier.supplierID.ToString();
                    txtLocation.Text = supplier.supplierLocation; // my naming is so redundant :\ i'll stick with it but in the future i will refrain from making everything unnecessarily disambiguous
                    txtEmail.Text = supplier.supplierEmail;
                    txtSupplierName.Text = supplier.supplierName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnRefreshSuppliers_Click(object sender, EventArgs e)
        {
            refreshDGV();
        }

        private void txtSupplierName_TextChanged(object sender, EventArgs e)
        {
            btnConfirmEdit.Enabled = true;

            if (txtSupplierName.Text.Length == 0)
            {
                lblNameWarning.Text = "Name length cannot be zero";
                isValid = false;
            }
            else
            {
                lblNameWarning.Text = "";
                isValid = true;
            }
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            btnConfirmEdit.Enabled = true;

            if (txtLocation.Text.Length == 0)
            {
                lblLocationWarning.Text = "Location cannot be empty";
                isValid = false;
            }
            else
            {
                lblLocationWarning.Text = "";
                isValid = true;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            btnConfirmEdit.Enabled = true;

            if (txtEmail.Text.Length == 0)
            {
                lblEmailWarning.Text = "Email length cannot be zero";
                isValid = false;
            }
            else
            {
                lblEmailWarning.Text = "";
                isValid = true;
            }
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            disableEditing();

            txtSupplierName.Text = supplier.supplierName;
            txtLocation.Text = supplier.supplierLocation;
            txtEmail.Text = supplier.supplierEmail;
        }

        private void btnClearSupplierDetails_Click(object sender, EventArgs e)
        {
            clearDetails();

            supplier = new Supplier();
        }

        private void btnConfirmEdit_Click(object sender, EventArgs e) // why is this code much more compact than the maintain clients section ? :( Less textboxes I suppose?
        {
            if (isValid)                                              // looks like 2 different people's code in my eyes
            {
                if (MessageBox.Show("Are you sure you want to update the selected supplier with the updated values? This action cannot be reverted.", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        Supplier newSupplier = new Supplier(supplier.supplierID, txtSupplierName.Text, txtLocation.Text, txtEmail.Text);
                        string sql = $"UPDATE Supplier SET SupplierName = '{newSupplier.supplierName}', SupplierLocation = '{newSupplier.supplierLocation}', SupplierEmail = '{newSupplier.supplierEmail}' WHERE SupplierID = {newSupplier.supplierID}";
                        sqlCommands.sqlUpdate(sql);
                        refreshDGV();
                        disableEditing();
                        MessageBox.Show("Update Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Some values are not valid. Please re-enter the values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Values cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            if (supplier != null)
            {
                if (MessageBox.Show($"Are you sure you want to delete {supplier.supplierName}? This action cannot be reverted.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    sqlCommands.sqlDelete($"DELETE FROM Supplier WHERE SupplierID = {supplier.supplierID}");
                    refreshDGV();
                    clearDetails();
                    MessageBox.Show("Delete Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a supplier first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void enableAddition()
        {
            btnConfirmAddition.Visible = true;
            btnCancelAddition.Visible = true;
            dgvSuppliers.Enabled = false;
        }

        public void disableAddition()
        {
            btnConfirmAddition.Visible = false;
            btnCancelAddition.Visible = false;
            dgvSuppliers.Enabled = true;
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            enableTXTBoxes();
            clearDetails();
            enableAddition();
            

            try
            {
                string sql = "SELECT TOP 1 SupplierID FROM Supplier ORDER BY SupplierID DESC";
                newSupplier.supplierID = Convert.ToInt32(sqlCommands.sqlSelect(sql).Tables[0].Rows[0][0]) + 1;
                lblSupplierIDNumber.Text = newSupplier.supplierID.ToString();
            }
            catch (Exception)
            {
                newSupplier.supplierID = 1;
                lblSupplierIDNumber.Text = newSupplier.supplierID.ToString();
            }
        }

        private void btnConfirmAddition_Click(object sender, EventArgs e)
        {
            if (isValid)
            {
                newSupplier.supplierName = txtSupplierName.Text;
                newSupplier.supplierLocation = txtLocation.Text;
                newSupplier.supplierEmail = txtEmail.Text;

                sqlCommands.sqlInsert($"INSERT INTO Supplier (SupplierName, SupplierLocation, SupplierEmail) VALUES ('{newSupplier.supplierName}', '{newSupplier.supplierLocation}', '{newSupplier.supplierEmail}')");
                MessageBox.Show("Addition Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                refreshDGV();
                clearDetails();
                disableTXTBoxes();
                disableAddition();
                fillTextBoxes(newSupplier);
            }
            else
            {
                MessageBox.Show("Values cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelAddition_Click(object sender, EventArgs e)
        {
            newSupplier = new Supplier();
            clearDetails();
            disableTXTBoxes();
            disableAddition();
        }
    }
}
