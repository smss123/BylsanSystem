using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Bylsan_System.Reports.ReportCommand;
using Bylsan_System.Reports.ReportsObject;
using XamaDataLayer;
using XamaDataLayer.Security;
using XamaDataLayer.SellSystem;
using Xprema.XExtention;
using XamaDataLayer.BranchCmd;
using System.Threading;
using System.Linq;
using XamaDataLayer.Helper_Classes;
using XamaDataLayer.Accountant;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Data.Linq;

namespace Bylsan_System.SellSystemForms
{
    public partial class FrmAddSales : Telerik.WinControls.UI.RadForm
    {
          DbDataContext db = new DbDataContext();
        public FrmAddSales()
        {
            InitializeComponent();
            imageList1.ImageSize = new Size(70, 70);
        }

        private Thread th = null;
        List<Product> q = new List<Product>();
        private void LoadProduct()
        {
            Operation.BeginOperation(this);
            q = Operation.Allproducts;
             var s = LoadOrderID();
             var cust = Operation.AllCustomer;
            this.Invoke((MethodInvoker)delegate
            {
                txtOrderID.Text = s;
                foreach (var item in q)
                {
                   txtProductName.AutoCompleteCustomSource.Add(item.Product_Name); 
                }
                foreach (var item in cust)
                {
                    txtCustomerName.AutoCompleteCustomSource.Add(item.PhoneNumber);
                    txtCustomerPhoneNumber.AutoCompleteCustomSource.Add(item.CustomerName);
                }
            });
            
           
            Operation.EndOperation(this);
            th.Abort();
        }

        private static string LoadOrderID()
        {
            var s = BillsCmd.GetAllByDate(DateTime.Now).ToList().Count.ToString();
            return s;
        }
        private void FrmAddSales_Load(object sender, EventArgs e)
        {
            CmbPaymentTypes.Items.AddRange(new string[] { "Cash Onley", "Visa Card Onley", "Both" });
            th = new Thread(LoadProduct);
            th.Start();
            
        }

        private  int xItemID { get; set; }
        private int xStorID { get; set; }



        private void SalesIt()
        {
            var stb = new SellStore()
            { ItemID = xItemID ,
                Qty = -1, };
            SellStoreCmd.Sales_EditQtyInSellStore(stb, xStorID, UserInfo.CurrnetUser.Branch_ID.Value);
        }


        public void DiscountFromStore()
        {
             var com = CompiledQuery.Compile(
             (DbDataContext dbx, int id) =>
              ( 
                    (from i in dbx.SellStores
                    where i.ItemID==id
                    select i).SingleOrDefault()

              )
            );
            foreach (GridViewRowInfo item in DGVSellItems.Rows)
            {
                try
                {
                    var q = com(db, item.Cells[0].Value.ToString().ToInt());
                    if (q.Qty<0)
                    {
                        RadMessageBox.Show(string.Format("The Item {0} is Low Stock now But Process Well be Continue!",q.Product.PublicName));
                    }
                    q.Qty = q.Qty - (long)item.Cells[4].Value.ToString().Todouble();
                }
                catch (Exception ex)
                {
                    RadMessageBox.Show(string.Format("The Item {0} not found ",item.Cells[1].Value.ToString()));
                    db = new DbDataContext();
                    throw new Exception("The Process Well be Stop Now");

                }
               

                
            }
        }
        private void Okeybtn_Click(object sender, EventArgs e)
        {
            try
            {
                int status = 0;
                double remaring = double.Parse(txtReaming.Text);

                if (txtCustomerPhoneNumber.Text == "" && txtCustomerName.Text == "")
                {

                    if (remaring > 0)
                    {
                        RadMessageBox.Show("Please Fill Customer Info");
                        return;
                    }
                    var q = Operation.AllCustomer.Where(cust => cust.PhoneNumber == txtCustomerPhoneNumber.Text).ToList();
                    if (q.Count == 0)
                    {
                        CustomerInformations.WatingCustomer = new Customer()
                        {
                            PhoneNumber = txtCustomerPhoneNumber.Text,
                            CreateDate = DateTime.Now,
                            CustomerName = txtCustomerName.Text,
                            Points = 0,
                            ID = ApiCounter.GetNumber(),

                        };
                        db.Customers.InsertOnSubmit(CustomerInformations.WatingCustomer);
                        db.SubmitChanges();
                        status = 1;
                    }
                    else
                    {
                        CustomerInformations.WatingCustomer = q[0];
                        status = 2;
                    }

                }
                else
                {
                    var q = Operation.AllCustomer.Where(cust => cust.PhoneNumber == txtCustomerPhoneNumber.Text).ToList();
                    if (q.Count == 0)
                    {
                        CustomerInformations.WatingCustomer = new Customer()
                        {
                            PhoneNumber = txtCustomerPhoneNumber.Text,
                            CreateDate = DateTime.Now,
                            CustomerName = txtCustomerName.Text,
                            Points = 0,
                            ID = ApiCounter.GetNumber(),

                        };
                        db.Customers.InsertOnSubmit(CustomerInformations.WatingCustomer);
                        db.SubmitChanges();
                        status = 1;
                    }
                    else
                    {
                        CustomerInformations.WatingCustomer = q[0];
                        status = 2;
                    }
                }
                if (remaring > 0)
                {

                    DiscountFromStore();
                    Bill p = new Bill()
                    {
                        BillDate = DateTime.Now,
                        BillNumber = ApiCounter.GetNumber().ToString(),
                        BillTotal = BillCostBox.Text.Todouble(),
                        paytype = CmbPaymentTypes.Text,
                        UserID = UserInfo.CurrnetUser.ID,
                        description = "Bill In Branch " + UserInfo.CurrnetUser.Branch.Branch_Name,
                        ID = ApiCounter.GetNumber(),

                    };
                    int productID = 0;
                    foreach (GridViewRowInfo item in DGVSellItems.Rows)
                    {
                        productID = item.Cells[0].Value.ToString().ToInt();

                        p.BillItems.Add(new BillItem()
                        {

                            ProductID = productID,
                            Qty = long.Parse(item.Cells[4].Value.ToString()),
                            Status = "Done",

                            ID = ApiCounter.GetNumber()
                        });
                    }
                    if (status != 0)
                    {
                        p.CustomerID = CustomerInformations.WatingCustomer.ID;
                    }
                    IEnumerable<Debtor> operationAllDebetorWhere = Operation.AllDebetor.Where(px => px.AccountID == CustomerInformations.WatingCustomer.AccountID);
                    if (operationAllDebetorWhere.Count() == 0)
                    {
                        db.Debtors.InsertOnSubmit(new Debtor()
                        {
                            DebtorName = txtCustomerName.Text,
                            PhoneNumber = txtCustomerPhoneNumber.Text,
                            AccountID = CustomerInformations.WatingCustomer.AccountID,
                            ID = ApiCounter.GetNumber(),
                        });
                    }
                    db.AccountDailies.InsertOnSubmit(new AccountDaily()
                    {
                        AccountID = CustomerInformations.WatingCustomer.AccountID,
                        DateOfProcess = DateTime.Now,
                        CommandArg = "",
                        Description = string.Format("Bill from Branch {0} in time {1} and userlogin is {2}", UserInfo.CurrnetUser.Branch.Branch_Name, DateTime.Now.ToString(), UserInfo.CurrnetUser.UserName),
                        TotalIn = double.Parse(BillCostBox.Text),
                        TotalOut = double.Parse(txtCustomerPay.Value.ToString()),
                        ID = ApiCounter.GetNumber()
                    });
                    db.AccountDailies.InsertOnSubmit(new AccountDaily()
                    {
                        AccountID = UserInfo.CurrnetUser.Branch.AccountID,
                        DateOfProcess = DateTime.Now,
                        CommandArg = "",
                        Description = string.Format("Bill from Branch {0} in time {1} and userlogin is {2}", UserInfo.CurrnetUser.Branch.Branch_Name, DateTime.Now.ToString(), UserInfo.CurrnetUser.UserName),
                        TotalIn = double.Parse(txtCustomerPay.Value.ToString()),
                        TotalOut = 0,
                        ID = ApiCounter.GetNumber()
                    });
                    db.Bills.InsertOnSubmit(p);
                    BillReportCommand cmd = new BillReportCommand();

                    List<RptBillObj> ls = new List<RptBillObj>();
                    foreach (var item in p.BillItems)
                    {
                        ls.Add(new RptBillObj()
                        {
                            Amount = p.BillTotal,
                            BillDate = p.BillDate,
                            ID = p.ID,
                            ItemName = Operation.Allproducts.Where(px => px.ID == item.ProductID).SingleOrDefault().PublicName,
                            Payment = txtCustomerPay.Value.ToString(),
                            Qty = item.Qty.ToString(),
                            Total = p.BillTotal,
                            UnitPrice = Operation.Allproducts.Where(px => px.ID == item.ProductID).SingleOrDefault().ProductUnit.Todouble(),
                            User = UserInfo.CurrnetUser.UserName

                        }
                        );

                    }

                    cmd.PrintBill(ls);



                }
                else
                {
                    Bill p = new Bill()
                    {
                        BillDate = DateTime.Now,
                        BillNumber = ApiCounter.GetNumber().ToString(),
                        BillTotal = BillCostBox.Text.Todouble(),
                        paytype = CmbPaymentTypes.Text,
                        UserID = UserInfo.CurrnetUser.ID,
                        description = "Bill In Branch " + UserInfo.CurrnetUser.Branch.Branch_Name,
                        ID = ApiCounter.GetNumber(),

                    };
                    int productID = 0;
                    foreach (GridViewRowInfo item in DGVSellItems.Rows)
                    {
                        productID = item.Cells[0].Value.ToString().ToInt();
                        p.BillItems.Add(new BillItem()
                        {
                            ProductID = productID,
                            Qty = long.Parse(item.Cells[4].Value.ToString()),
                            Status = "Done",
                            ID = ApiCounter.GetNumber()
                        });
                    }
                    if (status != 0)
                    {
                        p.CustomerID = CustomerInformations.WatingCustomer.ID;
                    }
                    db.AccountDailies.InsertOnSubmit(new AccountDaily()
                    {
                        AccountID = UserInfo.CurrnetUser.Branch.AccountID,
                        DateOfProcess = DateTime.Now,
                        CommandArg = "",
                        Description = string.Format("Bill from Branch {0} in time {1} and userlogin is {2}", UserInfo.CurrnetUser.Branch.Branch_Name, DateTime.Now.ToString(), UserInfo.CurrnetUser.UserName),
                        TotalIn = double.Parse(BillCostBox.Text),
                        TotalOut = 0,
                        ID = ApiCounter.GetNumber()
                    });
                    db.Bills.InsertOnSubmit(p);
                    BillReportCommand cmd = new BillReportCommand();

                    List<RptBillObj> ls = new List<RptBillObj>();
                    foreach (var item in p.BillItems)
                    {
                        ls.Add(new RptBillObj()
                        {
                            Amount = p.BillTotal,
                            BillDate = p.BillDate,
                            ID = p.ID,
                            ItemName = Operation.Allproducts.Where(px => px.ID == item.ProductID).SingleOrDefault().PublicName,
                            Payment = txtCustomerPay.Value.ToString(),
                            Qty = item.Qty.ToString(),
                            Total = p.BillTotal,
                            UnitPrice = Operation.Allproducts.Where(px => px.ID == item.ProductID).SingleOrDefault().ProductUnit.Todouble(),
                            User = UserInfo.CurrnetUser.UserName

                        }
                        );

                    }
                    DiscountFromStore();
                    cmd.PrintBill(ls);


                }



                db.SubmitChanges();

                MessageBox.Show("Done");

                txtOrderID.Text = LoadOrderID();
                NewBill();
            }catch(Exception exx)
            {
                RadMessageBox.Show(exx.Message);
            }
        }

      
          

        private void NewBill()
        {
            DGVSellItems.Rows.Clear();
            txtCustomerName.Text = string.Empty;
            txtCustomerPhoneNumber.Text = string.Empty;
            txtCustomerPay.Value = 0;
            txtBarCode.Text = string.Empty;
            txtCash.Text = string.Empty;
            txtVisaCard.Text = string.Empty;
            BillCostBox.Text = string.Empty;
            txtReaming.Text = string.Empty;
          
        }







        private void TxtBillNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void CalcTotal()
        {
            var tot = 0d;
            foreach (var rw in DGVSellItems.Rows)
            {
                tot += double.Parse(rw.Cells[3].Value.ToString())*rw.Cells[4].Value.ToString().Todouble();
            }

            BillCostBox.Text = tot.ToString();
        }

        private void ListItems_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                var q = new Product();
                try
                {
                    q = Operation.Allproducts.Where(p => p.ID == int.Parse(txtBarCode.Text)).Take(1).Single();
                }
                catch (Exception)
                {
                    MessageBox.Show("Item Not Found");
                    txtBarCode.Text = string.Empty;
                    return;
                }


                if (DGVSellItems.Rows.Count != 0)
                {
                    for (var i = 0; i < DGVSellItems.Rows.Count; i++)
                    {
                        if (int.Parse(DGVSellItems.Rows[i].Cells[0].Value.ToString()) == q.ID)
                        {
                            DGVSellItems.Rows[i].Cells[4].Value = int.Parse(DGVSellItems.Rows[i].Cells[4].Value.ToString()) + 1;
                          //  DGVSellItems.Rows[i].Cells[3].Value = (double.Parse(radGridView1.CurrentRow.Cells[3].Value.ToString()) + double.Parse(DGVSellItems.Rows[i].Cells[3].Value.ToString()));
                            CalcTotal();
                            txtBarCode.Clear();
                            txtBarCode.Focus();
                            return;
                        }
                    }
                }


                DGVSellItems.Rows.Add(new string[] {
                               q.ID.ToString(),
                               q.PublicName,
                               q.Product_Description,
                               q.ProductPrice.ToString(),
                                "1",
                                 q.ProductUnit
                            });

                txtBarCode.Clear();
                txtBarCode.Focus();

                CalcTotal();
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

                var GetItemPrice = 0;// SellItemsCmd .GetSellItemByID(int .Parse (DGVSellItems .CurrentRow .Cells [0].Value.ToString ()) )[0].ItemPrice ;

                DGVSellItems.CurrentRow.Cells[4].Value = int.Parse(DGVSellItems.CurrentRow.Cells[4].Value.ToString()) - 1;
                DGVSellItems.CurrentRow.Cells[3].Value = int.Parse(DGVSellItems.CurrentRow.Cells[3].Value.ToString()) - GetItemPrice ;
                CalcTotal();
                var Indx = 0 ;
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
        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtVisaCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void radGridView1_DoubleClick(object sender, EventArgs e)
        {
            //var q = new Product();
            //try
            //{
            //    q = Operation.Allproducts.Where(p => p.ID == int.Parse(radGridView1.CurrentRow.Cells[0].Value.ToString())).Take(1).Single();
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Item Not Found");
            //    txtBarCode.Text = string.Empty;
            //    return;
            //}


            //if (DGVSellItems.Rows.Count != 0)
            //{
            //    for (var i = 0; i < DGVSellItems.Rows.Count; i++)
            //    {
            //        if (int.Parse(DGVSellItems.Rows[i].Cells[0].Value.ToString()) == q.ID)
            //        {
            //            DGVSellItems.Rows[i].Cells[4].Value = int.Parse(DGVSellItems.Rows[i].Cells[4].Value.ToString()) + 1;
            //            DGVSellItems.Rows[i].Cells[3].Value = (double.Parse(radGridView1.CurrentRow.Cells[3].Value.ToString()) + double.Parse(DGVSellItems.Rows[i].Cells[3].Value.ToString()));
            //            CalcTotal();
            //            txtBarCode.Clear();
            //            txtBarCode.Focus();
            //            return;
            //        }
            //    }
            //}


            //DGVSellItems.Rows.Add(new string[] {
            //                   q.ID.ToString(),
            //                   q.PublicName,
            //                   string.Empty,
            //                   q.ProductPrice.ToString(),
            //                    "1"
            //                });

            //txtBarCode.Clear();
            //txtBarCode.Focus();

            //CalcTotal();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void BillCostBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            txtCustomerPay.Value = decimal.Parse( (txtCash.Text.Todouble() + txtVisaCard.Text.Todouble()).ToString());
        }

        private void txtVisaCard_TextChanged(object sender, EventArgs e)
        {
            txtCustomerPay.Value = decimal.Parse((txtCash.Text.Todouble() + txtVisaCard.Text.Todouble()).ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var  selectedProduct = q.Where(p => p.Product_Name == txtProductName.Text).Single();
                 string qty;
                if (txtqty.Text==""||txtqty.Text==null)
                {
                    qty = "1";
                }
                else
                {
                  qty = txtqty.Text;
                }

                DGVSellItems.Rows.Add(new string[] { selectedProduct.ID.ToString(), txtProductName.Text, selectedProduct.Product_Description, selectedProduct.ProductPrice.ToString(), qty, selectedProduct.ProductUnit, (selectedProduct.ProductPrice * int.Parse(qty)).ToString() });
                txtProductName.Text = "";
                txtqty.Text = "";
                CalcTotal();
            }
            catch (Exception)
            {

                RadMessageBox.ThemeName = this.ThemeName;
                RadMessageBox.Show("Item Not Found");
            }
        }

        private void txtCustomerPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            
            {
                try
                {
                    var q = Operation.AllCustomer.Where(p => p.PhoneNumber == txtCustomerPhoneNumber.Text).Take(1).Single();
                    txtCustomerName.Text = q.CustomerName;
                }
                catch (Exception)
                {

                    MessageBox.Show("Noy Found");
                }
              
            }
        }

        private void MasterTemplate_Click(object sender, EventArgs e)
        {

        }

        private void CalcAmount()
        {
            double totalAmount = 0;

            foreach (GridViewRowInfo item in DGVSellItems.Rows)
            {
                totalAmount = totalAmount + double.Parse(item.Cells[3].Value.ToString()) * double.Parse(totalAmount + item.Cells[4].Value.ToString());
                BillCostBox.Text = totalAmount.ToString();
            }
        }

        private void MasterTemplate_RowsChanged(object sender, Telerik.WinControls.UI.GridViewCollectionChangedEventArgs e)
        {
            CalcAmount();
            
        }

        private void RefreshBTn_Click(object sender, EventArgs e)
        {

        }

        private void MasterTemplate_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void MasterTemplate_ValueChanging(object sender, Telerik.WinControls.UI.ValueChangingEventArgs e)
        {
            //DGVSellItems
           
        }

        private void txtCustomerPay_ValueChanged(object sender, EventArgs e)
        {
            txtReaming.Text = (BillCostBox.Text.Todouble() - double.Parse(txtCustomerPay.Value.ToString())).ToString(); 
        }

        private void txtCustomerPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    var q = Operation.AllCustomer.Where(p => p.CustomerName == txtCustomerName.Text).Take(1).Single();
                   txtCustomerPhoneNumber.Text = q.PhoneNumber;
                }
                catch (Exception)
                {

                    MessageBox.Show("Noy Found");
                }

            }
        }
    }
}
