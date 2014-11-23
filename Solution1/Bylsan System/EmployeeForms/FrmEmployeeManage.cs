using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
namespace Bylsan_System.EmployeeForms
{
    public partial class FrmEmployeeManage : Form
    {
        public FrmEmployeeManage()
        {
            InitializeComponent();
            radGridView1.CommandCellClick += radGridView1_CommandCellClick;
        }

        void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            var col = radGridView1.CurrentColumn.Index;
            if (col == 9)
            {
                FrmEmployeeEdit frm = new FrmEmployeeEdit();
                frm.TragetEmployee = (Employee)radGridView1.CurrentRow.DataBoundItem;
                frm.ShowDialog();
                LoadEmployee();
            }
        }

        private void FrmEmployeeManage_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(LoadEmployee);
            th.Start();
        }

        private void LoadEmployee()
        {
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                toolStrip1.Text = "Loading .. ";

            });
            Operation.BeginOperation(this);
            try
            {
                Application.DoEvents();
                radGridView1.DataSource = EmployeesCmd.GetAllEmployees();
                Application.DoEvents();
            }
            catch (System.InvalidOperationException ex)
            {

                Application.DoEvents();
                radGridView1.DataSource = EmployeesCmd.GetAllEmployees();
                Application.DoEvents();
            }
           
            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                toolStrip1.Text = "Compelete Load .... ";

            });
        }
    }
}
