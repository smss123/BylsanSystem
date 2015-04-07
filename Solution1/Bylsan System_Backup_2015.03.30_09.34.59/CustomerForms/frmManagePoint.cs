using System;
using System.Linq;
using Telerik.WinControls.UI;
using XamaDataLayer.SettingX;
using Xprema.XExtention;

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
            var q = SettingCmd.GetSettingByID(2);
            return q;
        }
        private XamaDataLayer.SystemSetting q;
        private void frmManagePoint_Load(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            q = GetQ();
            settingNameLabel1.Text = q.SettingName;
            LBLid.Text = q.ID.ToString();
            settingValueTextBox.Text = q.SettingValue;
            Operation.EndOperation(this);
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            SettingCmd.EditSettingValue(settingValueTextBox.Text, LBLid.Text.ToInt());
        }
    }
}
