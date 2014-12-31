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
using Bylsan_System.Reports.ReportCommand;
using Bylsan_System.Reports.ReportsObject;
namespace Bylsan_System.SellSystemForms
{
    public partial class FrmAddSales : Telerik.WinControls.UI.RadForm
    {
        public FrmAddSales()
        {
            InitializeComponent();
            imageList1.ImageSize = new Size(70, 70);
        }

        #region " ^^^ Populate ListView Items "
        void PopulateListItems()
        {
            ListItems.View = View.Tile ;
            ListItems.Columns.Add("ID", 50, HorizontalAlignment.Center);
            ListItems.Columns.Add("Item Name ", 270, HorizontalAlignment.Center);
            ListItems.Columns.Add("Description", 300, HorizontalAlignment.Center);
            ListItems.Columns.Add("Price", 100, HorizontalAlignment.Center);

            ListItems.LargeImageList = imageList1;

            Operation.BeginOperation(this);
            int ImgIndx = 0;
            var AllSellItems = Operation.AllSellItems;

            ListItems.Items.Clear();

            this.Invoke((MethodInvoker)delegate
            {

                foreach (var item in AllSellItems)
                {
                    ListViewItem Itm = new ListViewItem(item.ID.ToString(), ImgIndx);
                    Itm.SubItems.Add(item.ItemName.ToString());
                    Itm.SubItems.Add(item.Description.ToString());
                    Itm.SubItems.Add(item.ItemPrice.ToString());
                    imageList1.Images.Add(item.ItemIcon);
                    ListItems.Items.Add(Itm);
                    ImgIndx++;
                }
            });

            Operation.EndOperation(this);
        }
        #endregion 

        private void FrmAddSales_Load(object sender, EventArgs e)
       {
           CmbPaymentTypes.Items.AddRange(new string[] {"Cash Onley","Visa Card Onley","Both" });
           txtCash.Enabled = false; txtVisaCard.Enabled = false;
           PopulateListItems();
        }

        private  int xItemID { get; set; }
        private int xStorID { get; set; }
        private void ListItems_MouseClick(object sender, MouseEventArgs e)
        {
           
          

                if (ListItems.Items.Count != 0)
                {
                    xItemID = 0;
                    xItemID = int.Parse(ListItems.SelectedItems[0].Text);
                    //===================================================

                    var ChkAvailable = SellStoreCmd.GetSellStoreByItemID(xItemID);
                    xStorID = ChkAvailable.ID;
                    if (ChkAvailable.Qty == 0)
                    {
                        Operation.ShowToustOk("Not Available .. Qty = 0 ", this);
                        return;
                    }

                    //===================================================
                    Application.DoEvents(); 
                    //==================================================

                    if (DGVSellItems.Rows.Count != 0)
                    {
                        for (int i = 0; i < DGVSellItems.Rows.Count; i++)
                        {
                            if (int.Parse(DGVSellItems.Rows[i].Cells[0].Value.ToString()) == xItemID)
                            {
                                DGVSellItems.Rows[i].Cells[4].Value = int.Parse(DGVSellItems.Rows[i].Cells[4].Value.ToString()) + 1;
                                DGVSellItems.Rows[i].Cells[3].Value = (int.Parse(ListItems.SelectedItems[0].SubItems[3].Text) + int.Parse(DGVSellItems.Rows[i].Cells[3].Value.ToString()));
                                CalcTotal();
                                SalesIt ();
                                return;
                            }
                        }
                    }
            

                        DGVSellItems.Rows.Add(new string[] 
                            {
                                xItemID.ToString(),
                                ListItems.SelectedItems[0].SubItems[1].Text,
                                ListItems.SelectedItems[0].SubItems[2].Text,
                                ListItems.SelectedItems[0].SubItems[3].Text,
                                "1"
                               
                            });
                        SalesIt();
                        CalcTotal();
                }
               
                                                
       
           
        }


        void SalesIt()
        {
            SellStore stb = new SellStore()
            {
                ItemID = xItemID ,
                Qty = -1,
            };
            SellStoreCmd.Sales_EditQtyInSellStore(stb, xStorID );
        }

        StoreOperationManager OptrTb = new StoreOperationManager();
        private void Okeybtn_Click(object sender, EventArgs e)
        {
            if (CmbPaymentTypes.Text == "Both")
            {
                if (txtVisaCard.Text == "" || txtCash.Text == "") { Operation.ShowToustOk("Enter the apportionment payment", this); return; }
            }
            try
            {
                if (DGVSellItems.Rows.Count != 0)
                {


                    TxtBillNumber.Text = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();
                    if (TxtBillNumber.Text == "")
                    {
                        Operation.ShowToustOk("Insert Bill Number ", this);
                        return;
                    }
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
                        BillNumber =  TxtBillNumber.Text ,// شوف طريقة لأدخال رقم الفاتورة سواء كان يدوي  أو تلقائي يعني عداد 
                        UserID = UserInfo.CurrentUserID,
                        BillTotal =  tot ,
                        paytype =  CmbPaymentTypes .Text  ,
                        description = string .Format ( " Pay by Cash : {0}  , pay by visa card :  {1}  ", txtCash .Text ,txtVisaCard .Text )

                    };
                    BillsCmd.AddBill(btb);

                    // Save At BillItem :
                    BillItem billtb = new BillItem();
                    List<BillItem> billItem = new List<BillItem>();
                    foreach (var rw in DGVSellItems.Rows)
                    {
                        billtb = new BillItem()
                        {
                            ItemID = int.Parse(rw.Cells[0].Value.ToString()),
                            Qty = int.Parse(rw.Cells[4].Value.ToString()),
                            Bill_ID = BillsCmd.GetMaxBill(),
                        };
                        billItem.Add(billtb);
                        BillItemsCmd.AddBillItmes(billtb);
                        //=======================================================
                        // Save At : StoreOperationManager

                         var xSellStore =   SellStoreCmd .GetSellStoreByItemID (int.Parse(rw.Cells[0].Value.ToString()));
                        
                         OptrTb = new StoreOperationManager()
                         {                            
                             StoreID = xSellStore .ID  ,
                             ProcessType = "Darwal", // ســحب
                             ProcessDate = DateTime .Now ,
                             Qty = int.Parse(rw.Cells[4].Value.ToString()),
                             UserID = XamaDataLayer.Security .UserInfo .CurrentUserID 
                         };
                         StoreOperationManagerCmd.AddStoreOperationManager(OptrTb);
                        //=======================================================
                    }
                    Operation.ShowToustOk("Bill Has Been Saved ..", this);
                    BillReportCommand printBill = new BillReportCommand();
                    btb.BillItems.AddRange(billItem);
                    List<RptBillObj> ls = new List<RptBillObj>();

                    foreach (var item in btb.BillItems)
                    {
                        ls.Add(new RptBillObj() { 
                         ID = btb.ID,
                          Total = btb.BillTotal,
                           BillDate= DateTime.Now,
                            ItemName = item.SellItem.ItemName,
                             Qty = item.Qty.ToString(),
                              Amount  = item.Qty* item.SellItem.ItemPrice,
                               UnitPrice= item.SellItem.ItemPrice,
                         User = UserInfo.CurrnetUser.UserName
                        
                        
                        });
                    }
                    printBill.PrintBill(ls);
                    DGVSellItems.Rows.Clear();
                    BillCostBox.Text = "";
                    txtBarCode.Text = "";
                    TxtBillNumber.Text = "";
                }
            }
            catch (Exception)
            {


            }
        }

        private void TxtBillNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void CalcTotal()
        {
            double tot = 0;
            foreach (var rw in DGVSellItems.Rows)
            {
                tot += int.Parse(rw.Cells[3].Value.ToString());
            }
            // Just Display Total Cost To User Onley :
            BillCostBox.Text = tot.ToString();
        }

        private void ListItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (ListItems.Items.Count != 0)
                {
                    xItemID = 0;

                    var GetItem = SellItemsCmd.GetSellItemByID(int.Parse(txtBarCode.Text.ToString()));
                    if (GetItem.Count == 0)
                    {
                        Operation.ShowToustOk("This Item Not Found ", this);

                    }
                    else
                    {


                        xItemID = GetItem[0].ID;
                        Application.DoEvents();
                        //==================================================

                        if (DGVSellItems.Rows.Count != 0)
                        {
                            for (int i = 0; i < DGVSellItems.Rows.Count; i++)
                            {
                                if (int.Parse(DGVSellItems.Rows[i].Cells[0].Value.ToString()) == xItemID)
                                {
                                    DGVSellItems.Rows[i].Cells[4].Value = int.Parse(DGVSellItems.Rows[i].Cells[4].Value.ToString()) + 1;
                                    DGVSellItems.Rows[i].Cells[3].Value = (int.Parse(ListItems.SelectedItems[0].SubItems[3].Text) + int.Parse(DGVSellItems.Rows[i].Cells[3].Value.ToString()));
                                    CalcTotal();
                                    return;
                                }
                            }
                        }


                        DGVSellItems.Rows.Add(new string[] 
                            {
                                xItemID.ToString(),
                               GetItem[0].ItemName,// ListItems.SelectedItems[0].SubItems[1].Text,
                                GetItem[0].Description,//ListItems.SelectedItems[0].SubItems[2].Text,
                               GetItem[0].ItemPrice.ToString(), //ListItems.SelectedItems[0].SubItems[3].Text,
                                "1"
                            });

                        CalcTotal();
                       
                    }
                }

                txtBarCode.Clear();
                txtBarCode.Focus();

            }
            

        }

        private void txtBarCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void MasterTemplate_CommandCellClick(object sender, EventArgs e)
        {
            var col = DGVSellItems.CurrentColumn.Index;
            if (col == 5)
            {
                Operation.BeginOperation(this);
                
             var   GetItemPrice  =  SellItemsCmd .GetSellItemByID(int .Parse (DGVSellItems .CurrentRow .Cells [0].Value.ToString ()) )[0].ItemPrice ;

             DGVSellItems.CurrentRow.Cells[4].Value = int.Parse(DGVSellItems.CurrentRow.Cells[4].Value.ToString()) - 1;
             DGVSellItems.CurrentRow.Cells[3].Value = int.Parse(DGVSellItems.CurrentRow.Cells[3].Value.ToString()) - GetItemPrice ;
             CalcTotal();
                int Indx = 0 ; 
                Indx = DGVSellItems .CurrentRow .Index ;
             if (int.Parse(DGVSellItems.CurrentRow.Cells[4].Value.ToString()) == 0)
             {
                 DGVSellItems.Rows.RemoveAt(Indx);
             }
             Operation.EndOperation(this);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void CmbPaymentTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbPaymentTypes.Text == "Both")
            {
                txtCash.Enabled = true ; txtVisaCard.Enabled = true ;
            }
            else
            {
                txtCash.Enabled = false; txtVisaCard.Enabled = false;
            }
        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtVisaCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

       

    }
}
