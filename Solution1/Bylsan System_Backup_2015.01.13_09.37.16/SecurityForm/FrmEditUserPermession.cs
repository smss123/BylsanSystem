using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
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
        UserPermession px = new UserPermession();
        private void ReFrishData()
        {

            px = new UserPermession();
            XUserId = TragetUser.ID;
            this.userNameTextBox.Text = TragetUser.UserName;
            this.passwordsTextBox.Text = TragetUser.Passwords;
            var q = TragetUser.UserPermessions;



            var xData = PermessionsCmd.GetAllSystemPermession();
            foreach (var item in xData)
            {

                dataGridView1.Rows.Add(new string[] { item.ID.ToString(), item.Permession, item.Description });
            }
            //==========================================================
            var lst = PermessionsCmd.GetAllUserPermissonsByUserID(XUserId);
            int rw = 0;
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

            string xValue = "";


            //==========================================
            PermessionsCmd.ClearAllUserPermessions(XUserId);
            //===========================================
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                px = new UserPermession();
                DataGridViewCheckBoxCell chkchecking = dataGridView1.Rows[i].Cells[3] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(chkchecking.Value) == true)
                { xValue = "True"; }
                else { xValue = "False"; }

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
