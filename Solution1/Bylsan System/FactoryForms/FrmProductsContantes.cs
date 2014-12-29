using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XamaDataLayer;
using XamaDataLayer.Main_Store;
using System.Threading;
namespace Bylsan_System.FactoryForms
{
    public partial class FrmProductsContantes : Form
    {
        public FrmProductsContantes()
        {
            InitializeComponent();
        }


        void PopulateCmb()
        {
            Operation.BeginOperation(this);
            var AllItems = ItemsCmd.GetAllItemsMaterial();
            this .Invoke (( MethodInvoker) delegate 
        {
            CmbItems.Items.Clear();
            CmbItems .Items .AddRange (( from i in AllItems.ToList () select i .ItemName ).ToArray ());
        });
            Operation.EndOperation(this);
        }
        private void FrmProductsContantes_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(PopulateCmb);
            th.Start();

        }
    }
}
