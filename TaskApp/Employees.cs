using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using static DAL.BusinessLogic.EmployeeProcessor;

namespace TaskApp
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           int res = CreateEmployee(
                Convert.ToInt32(txtEmployeeID.Text),
                txtFirstName.Text,
                txtLastName.Text,
                txtEmail.Text
                );
            if (res==1)
            {
                MessageBox.Show("Inserted Successfully");
                LoadEmployeeData();
            }
            else
            {
                MessageBox.Show("ErrorOccured");
            }
        }
        public void LoadEmployeeData()
        {
            dgvEmployees.DataSource = LoadEmployees();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }
    }
}
