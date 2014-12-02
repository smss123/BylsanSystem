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
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
namespace Bylsan_System.EmployeeForms
{
    public partial class FrmEmployeeManage : RadForm
    {
        public FrmEmployeeManage()
        {
            InitializeComponent();
            EmployeeGridView.CommandCellClick += radGridView1_CommandCellClick;
        }

        void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            var col = EmployeeGridView.CurrentColumn.Index;
            if (col == 9)
            {
                FrmEmployeeEdit frm = new FrmEmployeeEdit();
                frm.TragetEmployee = (Employee)EmployeeGridView.CurrentRow.DataBoundItem;
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
          
                Application.DoEvents();
               var q = EmployeesCmd.GetAllEmployees();
                Application.DoEvents();
           
            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {
                EmployeeGridView.DataSource = q;
                toolStrip1.Text = "Compelete Load .... ";

            });
        }
    }
}
