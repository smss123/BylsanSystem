﻿using System;
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
            var AllSellItems = SellItemsCmd.GetAllSellItems();

            ListItems.Items.Clear();

            this.Invoke((MethodInvoker)delegate {

                foreach (var item in AllSellItems)
                {
                     ListViewItem Itm = new ListViewItem(item .ID .ToString () , ImgIndx );
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
     
           PopulateListItems();
        }

        private  int xItemID { get; set; }

        private void ListItems_MouseClick(object sender, MouseEventArgs e)
        {
           
            try
            {

                if (ListItems.Items.Count != 0)
                {
                    xItemID = 0;
                    xItemID = int.Parse(ListItems.SelectedItems[0].Text);

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
                                ListItems.SelectedItems[0].SubItems[1].Text,
                                ListItems.SelectedItems[0].SubItems[2].Text,
                                ListItems.SelectedItems[0].SubItems[3].Text,
                                "1"
                            });

                        CalcTotal();
                }
               
                                                
       
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
                    xItemID = GetItem[1].ID;
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
                                ListItems.SelectedItems[0].SubItems[1].Text,
                                ListItems.SelectedItems[0].SubItems[2].Text,
                                ListItems.SelectedItems[0].SubItems[3].Text,
                                "1"
                            });

                    CalcTotal();
                }

            }            
        }

    }
}
