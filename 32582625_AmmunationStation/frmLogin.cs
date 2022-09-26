using _32582625_AmmunationStation.Classes;
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
    public partial class frmLogin : Form
    {
        SqlCommands sqlCommands = new SqlCommands();
        bool success = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {      
            if (txtEmployeeID.Text != "" && txtPassword.Text != "")
            {
                string sql = $"SELECT * FROM Employee WHERE EmployeeID = {txtEmployeeID.Text} AND LoginPassword = '{txtPassword.Text}'";

                DataSet ds = new DataSet();
                ds = sqlCommands.sqlSelect(sql);
                
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Login Successful!");
                    Employee employee = new Employee(Convert.ToInt32(ds.Tables[0].Rows[0][0]), ds.Tables[0].Rows[0][1].ToString(), ds.Tables[0].Rows[0][2].ToString(), Convert.ToBoolean(ds.Tables[0].Rows[0][4]));
                    success = true;
                    this.Close();
                }
                else
                {
                    lblPasswordError.Text = "Employee ID or Password is incorrect";
                }
            }
            else
            {
                lblPasswordError.Text = "Fields should not be empty";
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!success)
            {
                Application.Exit();
            }
            
        }
    }
}
