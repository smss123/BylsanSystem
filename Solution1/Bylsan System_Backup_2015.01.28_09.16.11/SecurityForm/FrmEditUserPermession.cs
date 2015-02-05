using System;
using System.Collections.Generic;
using System.Windows.Forms;
using XamaDataLayer;
using XamaDataLayer.Security;

namespace Bylsan_System.SecurityForm
{
    public partial class FrmEditUserPermession : Telerik.WinControls.UI.RadForm
    {
        public FrmEditUserPermession()
        {
            InitializeComponent();
        }
        public User TragetUser { get; set; }
        public int XUserId { get; set; }
        private void FrmEditUserPermession_Load(object sender, EventArgs e)
        {
            ReFrishData();
        }
        private UserPermession px = new UserPermession();
        private void ReFrishData()
        {
            px = new UserPermession();
            XUserId = TragetUser.ID;
            userNameTextBox.Text = TragetUser.UserName;
            passwordsTextBox.Text = TragetUser.Passwords;



            var xData = PermessionsCmd.GetAllSystemPermession();
            foreach (var item in xData)
            {
                dataGridView1.Rows.Add(new string[] { item.ID.ToString(), item.Permession, item.Description });
            }

            var lst = PermessionsCmd.GetAllUserPermissonsByUserID(XUserId);
            var rw = 0;
            foreach (var i in lst)
            {
                if (i.PermessionValue.ToString() == "True")
                {
                    dataGridView1.Rows[rw].Cells[3].Value = "True";
                }
                rw++;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var xValue = string.Empty;



            PermessionsCmd.ClearAllUserPermessions(XUserId);

            for (var i = 0; i < dataGridView1.Rows.Count; i++)
            {
                px = new UserPermession();
                var chkchecking = dataGridView1.Rows[i].Cells[3] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(chkchecking.Value) == true)
                {
                    xValue = "True";
                }
                else
                {
                    xValue = "False";
                }

                px.SystemPermessionID = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                px.PermessionValue = xValue;
                px.UserID = XUserId;
                PermessionsCmd.AddUserPermessions(px);
            }


            MessageBox.Show(" Changes Was Saved ..");

            this.Hide();
        }
    }
}
