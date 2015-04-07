using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Bylsan_System.ManagmentOrderForms
{
    public partial class frmExperDate : RadForm
    {
        public frmExperDate()
        {
            InitializeComponent();
        }

        private void frmExperDate_Load(object sender, EventArgs e)
        {

        }
        public string  SelectedDate { get; set; }

        private void radButton1_Click(object sender, EventArgs e)
        {
            SelectedDate = dateTimePicker1.Value.ToShortDateString();
            Close();
        }
    }
}
