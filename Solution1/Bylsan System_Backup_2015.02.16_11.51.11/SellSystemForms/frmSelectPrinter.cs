using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Bylsan_System.SellSystemForms
{
    public partial class frmSelectPrinter : RadForm
    {
        public frmSelectPrinter()
        {
            InitializeComponent();
        }

        private void frmSelectPrinter_Load(object sender, EventArgs e)
        {
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                comboBox1.Items.Add(printer);
            }
            comboBox1.Text = Properties.Settings.Default.SmallPrinter;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SmallPrinter = comboBox1.Text;
            Properties.Settings.Default.Save();
            RadMessageBox.ThemeName = this.ThemeName;
            RadMessageBox.Show("Saved");

        }
    }
}
