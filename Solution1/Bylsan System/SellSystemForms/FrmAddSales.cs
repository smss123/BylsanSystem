using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

using XamaDataLayer;
using XamaDataLayer.SellSystem;
using Bylsan_System.SellSystemForms;
using System.Threading;

namespace Bylsan_System.SellSystemForms
{
    public partial class FrmAddSales : Telerik.WinControls.UI.RadForm
    {
        public FrmAddSales()
        {
            InitializeComponent();
        }

        #region " ^^^ Populate ListView Items "
        void PopulateListItems()
        {
            ListItems.View = View.Details;
            ListItems.Columns.Add("ID", 50, HorizontalAlignment.Center);
            ListItems.Columns.Add("Item Name ", 150, HorizontalAlignment.Center);
            ListItems.Columns.Add("Description", 190, HorizontalAlignment.Center);
            ListItems.Columns.Add("Price", 100, HorizontalAlignment.Center);

            Operation.BeginOperation(this);

            var AllSellItems = SellItemsCmd.GetAllSellItems();

            ListItems.Items.Clear();

            this.Invoke((MethodInvoker)delegate {

                foreach (var item in AllSellItems)
                {
                     ListViewItem Itm = new ListViewItem(item .ID .ToString ());
                     Itm.SubItems.Add(item.ItemName.ToString());
                     Itm.SubItems.Add(item.Description.ToString());
                     Itm.SubItems.Add(item.ItemPrice.ToString());
                     ListItems.Items.Add(Itm);
                }
            });

            Operation.EndOperation(this);
        }
        #endregion 

        private void FrmAddSales_Load(object sender, EventArgs e)
       {
        //    Thread thr = new Thread(PopulateListItems);
        //    thr.Start();
           PopulateListItems();
        }

        public static Bill WaitingBill { get; set; }
        public static BillItem WaitingBillItem { get; set; }
        public  static SellItem WaitingSellItems { get; set; }
        private  int xItemID { get; set; }

        private int QtyCounter = 0;
        private void ListItems_MouseClick(object sender, MouseEventArgs e)
        {
            QtyCounter++;
            Operation.BeginOperation(this);
           
            try
            {
                if (ListItems.Items.Count != 0)
                {
                    xItemID = 0;
                    xItemID = ListItems .SelectedItems[0].Index;
                    var TheItem = SellItemsCmd.GetSellItemByID(int.Parse(ListItems.Items[xItemID].SubItems[0].Text));
                   


                    
                }          
           Operation.EndOperation(this);
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

    }
}
