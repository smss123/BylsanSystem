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

namespace Bylsan_System.SellSystemForms
{
    public partial class FrmAddSales : Telerik.WinControls.UI.RadForm
    {
        public FrmAddSales()
        {
            InitializeComponent();
            imageList1.ImageSize = new Size(70, 70);
        }

        private void LoadProduct()
        {
            Operation.BeginOperation(this);
            var q =  ProductsCmd.GetProductDetailsForSale();
            this.Invoke((MethodInvoker)delegate
            {
                productBindingSource.DataSource = q;
            });
            Operation.EndOperation(this);
            th.Abort();
        }
        private Thread th = null;
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
            SellStoreCmd.Sales_EditQtyInSellStore(stb, xStorID );
        }
        private void Okeybtn_Click(object sender, EventArgs e)
        {
            if (BillCostBox.Text.Todouble() > txtCustomerPay.Value.ToString().Todouble())
            {
                if (MessageBox.Show("The amount paid is less than the amount required \n The customer will be added in the box debts that continued operation .", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    SaveBill();
                    MessageBox.Show("Done");
                    NewBill();
                }
            }
            else
            {
                SaveBill();
                MessageBox.Show("Done");
                NewBill();
            }
        }

        private void SaveBill()
        {
            var q = new Customer();
            var billNumber = (DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond).ToString();
            var cmd = new BillReportCommand();
            var ls = new List<RptBillObj>();
            TxtBillNumber.Text = billNumber;
            try
            {
                q = Operation.AllCustomer.Where(p => p.PhoneNumber == txtCustomerPhoneNumber.Text).Take(1).Single();

                var bil = new Bill()
                { BillDate = DateTime.Now,
                    BillNumber = billNumber,
                    BillTotal = BillCostBox.Text.Todouble(),
                    paytype = CmbPaymentTypes.Text,
                    CustomerID = q.ID,
                    UserID = UserInfo.CurrentUserID
                };

                foreach (var row in DGVSellItems.Rows)
                {
                    bil.BillItems.Add(new BillItem()
                    {

                        ItemID = row.Cells[0].Value.ToString().ToInt(),
                        Qty = long.Parse(row.Cells[0].Value.ToString())

                    });
                    try
                    {
                        SellStoreCmd.EditQty(row.Cells[0].Value.ToString().ToInt(),
                        UserInfo.CurrnetUser.Branch_ID.ToString().ToInt(),
                        long.Parse(row.Cells[4].Value.ToString()));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                BillsCmd.AddBill(bil);
                try
                {
                    AccountDailyCmd.AddAccountDaily(new AccountDaily()
                    {
                        Account = bil.Customer.Account,
                        DateOfProcess = DateTime.Now,
                        CommandArg = Guid.NewGuid().ToString(),
                        Description = string.Format("عبارة عن مبلغ مطلوب من فاتورة رقم{0 } ", billNumber),
                        TotalIn = 0,
                        TotalOut = txtCustomerPay.Value.ToString().Todouble(),
                    });
                    AccountDailyCmd.AddAccountDaily(new AccountDaily()
                    {
                        Account = bil.Customer.Account,
                        DateOfProcess = DateTime.Now,
                        CommandArg = Guid.NewGuid().ToString(),
                        Description = string.Format("عبارة عن مبلغ مطلوب من فاتورة رقم{0 } ", billNumber),
                        TotalIn = txtCustomerPay.Value.ToString().Todouble(),
                        TotalOut = 0,
                    });
                    AccountDailyCmd.AddAccountDaily(new AccountDaily()
                    {
                        AccountID = 10,
                        DateOfProcess = DateTime.Now,
                        CommandArg = Guid.NewGuid().ToString(),
                        Description = "مبلغ مودع من فاتورة",
                        TotalIn = txtCustomerPay.Value.ToString().Todouble(),
                        TotalOut = 0,
                    });
                }
                catch (System.NullReferenceException ex)
                {
                }
                foreach (var row in DGVSellItems.Rows)
                {
                    ls.Add(new RptBillObj()
                    {
                        BillDate = bil.BillDate,
                        ItemName = row.Cells[1].Value.ToString(),
                        Qty = row.Cells[4].Value.ToString(),
                        ID = bil.BillNumber.ToInt(),
                        Amount = row.Cells[3].Value.ToString().Todouble(),
                        User = UserInfo.CurrnetUser.UserName,
                        Total = bil.BillTotal,


                    });
                }
                cmd.PrintBill(ls);
            }
            catch (Exception)
            {
                if (txtCustomerPhoneNumber.Text == string.Empty && txtCustomerName.Text == string.Empty)
                {
                    CustomerInformations.WatingCustomer = null;
                }
                else
                {
                    CustomerInformations.WatingCustomer = new Customer()
                    {
                        CustomerName = txtCustomerName.Text,
                        PhoneNumber = txtCustomerPhoneNumber.Text,
                        Points = 0
                    };
                }
                var bil = new Bill()
                { BillDate = DateTime.Now,
                    BillNumber = TxtBillNumber.Text,
                    BillTotal = BillCostBox.Text.Todouble(),
                    paytype = CmbPaymentTypes.Text,
                    Customer = CustomerInformations.WatingCustomer
                };

                foreach (var row in DGVSellItems.Rows)
                {
                    bil.BillItems.Add(new BillItem()
                    {

                        ItemID = row.Cells[0].Value.ToString().ToInt(),
                        Qty = long.Parse(row.Cells[0].Value.ToString())

                    });
                    try
                    {
                        SellStoreCmd.EditQty(row.Cells[0].Value.ToString().ToInt(),
                        UserInfo.CurrnetUser.Branch_ID.ToString().ToInt(),
                        long.Parse(row.Cells[4].Value.ToString()));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                BillsCmd.AddBill(bil);
                try
                {
                    AccountDailyCmd.AddAccountDaily(new AccountDaily()
                    {
                        Account = bil.Customer.Account,
                        DateOfProcess = DateTime.Now,
                        CommandArg = Guid.NewGuid().ToString(),
                        Description = string.Format("عبارة عن مبلغ مطلوب من فاتورة رقم{0 } ", billNumber),
                        TotalIn = 0,
                        TotalOut = txtCustomerPay.Value.ToString().Todouble(),
                    });
                    AccountDailyCmd.AddAccountDaily(new AccountDaily()
                    {
                        Account = bil.Customer.Account,
                        DateOfProcess = DateTime.Now,
                        CommandArg = Guid.NewGuid().ToString(),
                        Description = string.Format("عبارة عن مبلغ مطلوب من فاتورة رقم{0 } ", billNumber),
                        TotalIn = txtCustomerPay.Value.ToString().Todouble(),
                        TotalOut = 0,
                    });
                    AccountDailyCmd.AddAccountDaily(new AccountDaily()
                    {
                        AccountID = 10,
                        DateOfProcess = DateTime.Now,
                        CommandArg = Guid.NewGuid().ToString(),
                        Description = "مبلغ مودع من فاتورة",
                        TotalIn = txtCustomerPay.Value.ToString().Todouble(),
                        TotalOut = 0,
                    });
                }
                catch (System.NullReferenceException ex)
                {
                }

                foreach (var row in DGVSellItems.Rows)
                {
                    ls.Add(new RptBillObj()
                    {
                        BillDate = bil.BillDate,
                        ItemName = row.Cells[1].Value.ToString(),
                        Qty = row.Cells[4].Value.ToString(),
                        ID = bil.BillNumber.ToInt(),
                        Amount = row.Cells[3].Value.ToString().Todouble(),
                        User = UserInfo.CurrnetUser.UserName,
                        Total = bil.BillTotal,


                    });
                }
                cmd.PrintBill(ls);
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
            TxtBillNumber.Text = string.Empty;
        }







        private void TxtBillNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void CalcTotal()
        {
            var tot = 0;
            foreach (var rw in DGVSellItems.Rows)
            {
                tot += int.Parse(rw.Cells[3].Value.ToString());
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
                            DGVSellItems.Rows[i].Cells[3].Value = (double.Parse(radGridView1.CurrentRow.Cells[3].Value.ToString()) + double.Parse(DGVSellItems.Rows[i].Cells[3].Value.ToString()));
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
                               string.Empty,
                               q.ProductPrice.ToString(),
                                "1"
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

                var   GetItemPrice  =  SellItemsCmd .GetSellItemByID(int .Parse (DGVSellItems .CurrentRow .Cells [0].Value.ToString ()) )[0].ItemPrice ;

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
            var q = new Product();
            try
            {
                q = Operation.Allproducts.Where(p => p.ID == int.Parse(radGridView1.CurrentRow.Cells[0].Value.ToString())).Take(1).Single();
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
                        DGVSellItems.Rows[i].Cells[3].Value = (double.Parse(radGridView1.CurrentRow.Cells[3].Value.ToString()) + double.Parse(DGVSellItems.Rows[i].Cells[3].Value.ToString()));
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
                               string.Empty,
                               q.ProductPrice.ToString(),
                                "1"
                            });

            txtBarCode.Clear();
            txtBarCode.Focus();

            CalcTotal();
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
    }
}
