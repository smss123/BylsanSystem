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

namespace WindowsFormsApplication1
{
    public partial class frmSynic : Form
    {
        public frmSynic()
        {
            InitializeComponent();
        }

        private void frmSynic_Load(object sender, EventArgs e)
        {
          txtLocal.Text=  Properties.Settings.Default.LocalConnection;
          txtRemote.Text = Properties.Settings.Default.RemoteConnection;

        }

        private void button1_Click(object sender, EventArgs e)
        {
             Properties.Settings.Default.LocalConnection= txtLocal.Text;
             Properties.Settings.Default.RemoteConnection = txtRemote.Text;
             Properties.Settings.Default.Save();
             MessageBox.Show("saved");
            Thread th = new Thread(()=>
            
                     {

                         SynicLoadFromRemote r = new SynicLoadFromRemote();
                         SynicLoadFromLocal l = new SynicLoadFromLocal();

                         while (true)
                         {

                             r.LoadFromLocal();
                             this.Invoke((MethodInvoker)delegate {

                                 progressBar1.Value = 50;
                             
                             });
                             l.LoadFromRemote();
                             this.Invoke((MethodInvoker)delegate
                             {

                                 progressBar1.Value = 100;

                             });
                         }
            
            
                     }
           
           );
           th.Start();
        }
    }
}
