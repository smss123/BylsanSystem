using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using XamaDataLayer.SettingX;

namespace Bylsan_System.CustomerForms
{
    public partial class frmManagePoint : RadForm
    {
        public frmManagePoint()
        {
            InitializeComponent();
        }
        private static XamaDataLayer.SystemSetting GetQ()
        {
            var q = SettingCmd.GetSettingBySerialNumber("c5f0243f-711c-4f94-81b8-03c3bc03ebf7");
            return q;
        }
        XamaDataLayer.SystemSetting q;
        private void frmManagePoint_Load(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
           q = GetQ();
            settingNameLabel1.Text = q.SettingName;
            settingValueTextBox.Text = q.SettingValue;
            Operation.EndOperation(this);
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            SettingCmd.EditSettingValue(settingValueTextBox.Text, q.SerialNumber.ToString());
        }
    }
}
