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
using XamaDataLayer.Security;
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
            ListItems.Columns.Add("Item Name ", 270, HorizontalAlignment.Center);
            ListItems.Columns.Add("Description", 300, HorizontalAlignment.Center);
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

        //public static Bill WaitingBill { get; set; }
        //public static BillItem WaitingBillItem { get; set; }
        //public  static SellItem WaitingSellItems { get; set; }
        private  int xItemID { get; set; }

        private int QtyCounter = 0;
        private void ListItems_MouseClick(object sender, MouseEventArgs e)
        {
           
            Operation.BeginOperation(this);
           QtyCounter = 1 ;
            try
            {
               
                if (ListItems.Items.Count != 0)
                {
                    xItemID = 0;
                    xItemID = int .Parse (ListItems .SelectedItems[0].Text ) ;

                    Application.DoEvents();

                    //foreach (var rw  in  DGVSellItems .Rows )
                    //{
                       
                    //    if(int .Parse (rw.Cells [0].Value.ToString ()) != xItemID )
                    //    {
                             // Add New Item :
                         
               
                            DGVSellItems.Rows.Add(new string[] 
                            {
                                xItemID.ToString(),
                                ListItems.SelectedItems[0].SubItems[1].Text,
                                ListItems.SelectedItems[0].SubItems[2].Text,
                                ListItems.SelectedItems[0].SubItems[3].Text,
                                "1"
                            });
                      
                        //}
                        //else
                        //{
                        //    rw.Cells[4].Value = QtyCounter++;
                        //    rw.Cells[3].Value  =  (int .Parse ( ListItems.SelectedItems[0].SubItems[3].Text) + int .Parse (rw.Cells[3].Value.ToString () ));
                        //}




                   // }
                

                    

                    
                }          
           Operation.EndOperation(this);
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
      
        private void Okeybtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVSellItems.Rows.Count != 0)
                {
                    // Compute Total Bill Cost :
                    double tot = 0;
                    foreach (var rw  in DGVSellItems .Rows )
                    {
                        tot += int.Parse(rw.Cells[3].Value.ToString()); 
                    }
                    // Just Display Total Cost To User Onley :
                    BillCostBox.Text =  tot.ToString ();


                    // Save bill :
                    Bill btb = new Bill()
                    {
                        BillDate = DateTime.Now,
                        BillNumber = "111111",// شوف طريقة لأدخال رقم الفاتورة سواء كان يدوي  أو تلقائي يعني عداد 
                        UserID = UserInfo.CurrentUserID,
                        BillTotal =  tot ,

                    };
                    BillsCmd.AddBill(btb);

                    // Save At BillItem :
                    BillItem billtb = new BillItem();
                    foreach (var rw in DGVSellItems.Rows)
                    {
                        billtb = new BillItem()
                        {
                            ItemID = int.Parse(rw.Cells[0].Value.ToString()),
                            Qty = int.Parse(rw.Cells[4].Value.ToString()),
                            Bill_ID = BillsCmd.GetMaxBill(),
                        };
                        BillItemsCmd.AddBillItmes(billtb);

                    }
                    Operation.ShowToustOk("Bill Has Been Saved ..", this);
                }
            }
            catch (Exception)
            {
                
                
            }
        }

    }
}
