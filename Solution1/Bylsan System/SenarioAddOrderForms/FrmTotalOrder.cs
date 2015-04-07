using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
using XamaDataLayer.Helper_Classes;
using XamaDataLayer.Security;
using Xprema.XExtention;
using Bylsan_System.Reports.ReportCommand;
using Telerik.WinControls.UI;
using XamaDataLayer.SettingX;
using Telerik.WinControls;

namespace Bylsan_System.SenarioAddOrderForms
{
    public partial class FrmTotalOrder : RadForm
    {
        public FrmTotalOrder()
        {
            InitializeComponent();


            
        }
        public string  TragetOrderType { get; set; }


        string orderID;
        private void FrmTotalOrder_Load_1(object sender, EventArgs e)
        {
            foreach (var item in UserInfo.CurrnetUser.UserPermessions)
            {
                if (item.SystemPermession.Permession == "New Order")
                {
                    txtDiscountBox.Enabled = bool.Parse(item.PermessionValue);
                }
            }
            Operation.BeginOperation(this);
            txtBranches.DataSource = Operation.AllBranches;
            txtBranches.DisplayMember = "Branch_Name";
            txtBranches.ValueMember = "ID";
            radGridView1.DataSource = CustomerInformations.CurOrder.OrderProducts.ToList();

            var totalPrice = 0f;

            foreach (var item in radGridView1.Rows)
            {
                totalPrice += item.Cells[3].Value.ToString().ToFloat();
            }
            TotalPriceBox.Text = totalPrice.ToString();

            Operation.EndOperation(this);
        }

        private void OkeyBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);

            double totalCost;
            if (txtDiscountBox.Text != string.Empty)
            {
                totalCost = ComputeDiscount(Convert.ToDouble(TotalPriceBox.Text.ToString()), Convert.ToDouble(txtDiscountBox.Text.ToString()));
            }
            else
            {
                totalCost = Convert.ToDouble(TotalPriceBox.Text.ToString());
            }
            //var currentBranch = Operation.AllBranches.Where(p => p.ID == txtBranches.SelectedValue.ToString().ToInt ()).Take(1).Single();
            //var custId = 0;
            //var custmerAccountID =(int?)0;

         //   CustomerInformations.CurOrder.Customer = CustomerInformations.CurrCustomer;
            CustomerInformations.CurOrder.OrderName = string.Format("Order_{0}_{1}",CustomerInformations.CurrCustomer.CustomerName,DateTime.Now.ToString());
            CustomerInformations.CurOrder.OrderDate= DateTime.Now;
            CustomerInformations.CurOrder.OrderDeliveryDate = receiptdateTimePicker.Value;
            CustomerInformations.CurOrder.Comment = txtCommint.Text;
            CustomerInformations.CurOrder.DeliverdToBranch = (int)txtBranches.SelectedValue;
            CustomerInformations.CurOrder.ID = ApiCounter.GetNumber();
            CustomerInformations.CurOrder.isOrderBranch = "No";
            CustomerInformations.CurOrder.OrderDelivery = AddresstextBox.Text;
            CustomerInformations.CurOrder.OrderStatus = "Ordered";
            
          ////Customer 
          //  var otb = new Order();
          //  var db = new DbDataContext();
          //  otb.OrderName = string.Format("{0}_{1}", CustomerInformations.WatingCustomer.CustomerName, DateTime.Now.ToString());
          //  otb.OrderDelivery = AddresstextBox.Text;

            switch  (CustomerInformations .OrdrType)
            {
                case "Special":
                    CustomerInformations.CurOrder.OrderStatus = "In Designer";
                    CustomerInformations.CurOrder.OrderType = "Special";
                    break;
                case "Normal":
                    CustomerInformations.CurOrder.OrderStatus = "in producting ";
                    CustomerInformations.CurOrder.OrderType = "Normal";
                    break;
            }

            CustomerInformations.CurOrder.OrderVerify = "from Branch";
            CustomerInformations.CurOrder.Branch_ID = UserInfo.CurrnetUser.Branch_ID;
            CustomerInformations.CurOrder.TotalAmount = (TotalPriceBox.Text).Todouble();
            CustomerInformations.CurOrder.ID = ApiCounter.GetNumber();
            foreach (var item in CustomerInformations.CurOrder.OrderProducts)
            {
                item.ID = ApiCounter.GetNumber();
                foreach (var itm in item.OrderProuctAttachments)
                {
                    itm.ID = ApiCounter.GetNumber();
                }
            }

            DbDataContext db = new DbDataContext();
            Order ord = new Order();
            int custmerAccountID = 0;
            try
            {
                var q = db.Customers.Where(p => p.ID == CustomerInformations.CurrCustomer.ID).SingleOrDefault();
               if (q!=null)
               {
                  
                   ord.ID = CustomerInformations.CurOrder.ID;
                   ord.Branch_ID = CustomerInformations.CurOrder.Branch_ID;
                   ord.Comment = CustomerInformations.CurOrder.Comment;
                   ord.DeliverdToBranch = CustomerInformations.CurOrder.DeliverdToBranch;
                   ord.isOrderBranch = CustomerInformations.CurOrder.isOrderBranch;
                   ord.OrderDate = CustomerInformations.CurOrder.OrderDate;
                   ord.OrderDelivery = CustomerInformations.CurOrder.OrderDelivery;
                   ord.OrderDeliveryDate = CustomerInformations.CurOrder.OrderDeliveryDate;
                   ord.OrderName = CustomerInformations.CurOrder.OrderName;
                   ord.OrderStatus = CustomerInformations.CurOrder.OrderStatus;
                   ord.OrderType = CustomerInformations.CurOrder.OrderType;
                   ord.OrderVerify = CustomerInformations.CurOrder.OrderVerify;
                   ord.TotalAmount = CustomerInformations.CurOrder.TotalAmount;
                   ord.ID = CustomerInformations.CurOrder.ID;
                   foreach (var item in CustomerInformations.CurOrder.OrderProducts)
                   {
                       var itm = new OrderProduct()
                       {
                            Description = item.Description,
                             ID = item.ID,
                              ImageX = item.ImageX,
                               ProductID= item.ProductID,
                                Qty = item.Qty,
                                 Status = item.Status,
                                 


                       };
                       foreach (var attach in item.OrderProuctAttachments)
                       {
                           OrderProuctAttachment px = new OrderProuctAttachment() { 
                            CustomerText = attach.CustomerText,
                             Description= attach.Description,
                              ID= attach.ID,
                               imageX = attach.imageX,
                              
                           };
                           itm.OrderProuctAttachments.Add(px);
                       }
                       ord.OrderProducts.Add(itm);
                   }
                   q.Orders.Add(ord);
                   db.SubmitChanges();
                   custmerAccountID = q.ID;
               }
               else
               {
                   q = new Customer();
                   q.ID = CustomerInformations.CurrCustomer.ID;
                   q.CreateDate = CustomerInformations.CurrCustomer.CreateDate;
                   q.CustomerName = CustomerInformations.CurrCustomer.CustomerName;
                   q.PhoneNumber = CustomerInformations.CurrCustomer.PhoneNumber;
                   q.Points = CustomerInformations.CurrCustomer.Points;

                   ord.ID = CustomerInformations.CurOrder.ID;
                   ord.Branch_ID = CustomerInformations.CurOrder.Branch_ID;
                   ord.Comment = CustomerInformations.CurOrder.Comment;
                   ord.DeliverdToBranch = CustomerInformations.CurOrder.DeliverdToBranch;
                   ord.isOrderBranch = CustomerInformations.CurOrder.isOrderBranch;
                   ord.OrderDate = CustomerInformations.CurOrder.OrderDate;
                   ord.OrderDelivery = CustomerInformations.CurOrder.OrderDelivery;
                   ord.OrderDeliveryDate = CustomerInformations.CurOrder.OrderDeliveryDate;
                   ord.OrderName = CustomerInformations.CurOrder.OrderName;
                   ord.OrderStatus = CustomerInformations.CurOrder.OrderStatus;
                   ord.OrderType = CustomerInformations.CurOrder.OrderType;
                   ord.OrderVerify = CustomerInformations.CurOrder.OrderVerify;
                   ord.TotalAmount = CustomerInformations.CurOrder.TotalAmount;
                   ord.ID = CustomerInformations.CurOrder.ID;
                   foreach (var item in CustomerInformations.CurOrder.OrderProducts)
                   {
                       var itm = new OrderProduct()
                       {
                           Description = item.Description,
                           ID = item.ID,
                           ImageX = item.ImageX,
                           ProductID = item.ProductID,
                           Qty = item.Qty,
                           Status = item.Status,



                       };
                       foreach (var attach in item.OrderProuctAttachments)
                       {
                           OrderProuctAttachment px = new OrderProuctAttachment()
                           {
                               CustomerText = attach.CustomerText,
                               Description = attach.Description,
                               ID = attach.ID,
                               imageX = attach.imageX,

                           };
                           itm.OrderProuctAttachments.Add(px);
                       }
                       ord.OrderProducts.Add(itm);
                   }

                   q.Orders.Add(ord);
                   db.Customers.InsertOnSubmit(q);
                   db.SubmitChanges();
                   custmerAccountID = q.ID;
               }
            }
            catch (Exception ex)
            {

                RadMessageBox.ThemeName = this.ThemeName;
                RadMessageBox.Show(ex.Message);
               
            }
            
           // OrdersCmd.AddNewOrder(CustomerInformations.CurOrder);

            //otb.OrderDate = DateTime.Now;
            //otb.TotalAmount =  (TotalPriceBox.Text).Todouble();
            //otb.Branch_ID = UserInfo.CurrnetUser.Branch_ID;
            //otb.Comment = txtCommint.Text;
            //otb.OrderVerify = "from Branch";
            ////otb.CustomerID = custId;
            //otb.OrderDeliveryDate = receiptdateTimePicker.Value;
            //otb.DeliverdToBranch =  (txtBranches.SelectedValue.ToString()).ToInt();
            //otb.CustomerID = custId;

           // if (otb.ID==0)
            
           //{
           //    otb.ID = ApiCounter.GetNumber();
           //     db.Orders.InsertOnSubmit(otb);
           //     db.SubmitChanges();
           // }
           // else
           // {
           //     db.Orders.Attach(otb, true);

           // }

           // orderID = otb.ID.ToString();
         


           // xLastOrderID = otb.ID;


            //var ordtb = new OrderProduct();
            //foreach (var item in CustomerInformations.WaitingOrder.OrderProducts.ToList())
            //{
            //    ordtb = new OrderProduct();
            //    ordtb.OrderID = otb.ID;
            //    ordtb.Description = item.Description;
            //    ordtb.ImageX = item.ImageX;
            //    ordtb.ProductID = item.ProductID;
            //    ordtb.Qty = item.Qty;
            //    ordtb.Status = item.Status;
            //    ordtb.ID = ApiCounter.GetNumber();
            //    OrderProductsCmd.AddOrderProduct(ordtb);
            //    foreach (var atta in item.OrderProuctAttachments.ToList())
            //    {

            //        var attb = new OrderProuctAttachment()
            //                     {
            //                         Description = atta.Description,
            //                          CustomerText = atta.CustomerText,
            //                         imageX = atta.imageX,
            //                         OrderProductID = ordtb.ID,
            //                          ID= ApiCounter.GetNumber()
            //                     };

            //        OrderProuctAttachmentCmd.AddOrderProductAttachment(attb);
                    
            //    }
                
                
            //}



            var addOrder = new AccountDaily()
            {
                ID = ApiCounter.GetNumber(),
                AccountID = ord.OrderAccount,
                TotalIn = totalCost,
                TotalOut = 0f,
                DateOfProcess = DateTime.Now,
                Description = string.Format("Total  Of  A  Order_ Name {0} at time {1}, branch Name {2}", ord.OrderName, DateTime.Now.ToString(), UserInfo.CurrnetUser.Branch.Branch_Name),
                CommandArg = ord.ID.ToString()
            };
            db.AccountDailies.InsertOnSubmit(addOrder);


            var ordertrs = new AccountDaily()
            {
                ID = ApiCounter.GetNumber(),
                AccountID = ord.OrderAccount,
                TotalIn = 0f,
                TotalOut = totalCost,
                DateOfProcess = DateTime.Now,
                Description = string.Format("Total  Of  A  Order_ Name {0} at time {1}, branch Name {2}", ord.OrderName, DateTime.Now.ToString(), UserInfo.CurrnetUser.Branch.Branch_Name),
                CommandArg = ord.ID.ToString()
            };
            db.AccountDailies.InsertOnSubmit(ordertrs);

            var CustomerDept = new AccountDaily()
            {
                ID = ApiCounter.GetNumber(),
                AccountID = custmerAccountID,
                TotalIn = 0f,
                TotalOut = totalCost,
                DateOfProcess = DateTime.Now,
                Description = string.Format("Total  Of  A  Order_ Name {0} at time {1}, branch Name {2}", ord.OrderName, DateTime.Now.ToString(), UserInfo.CurrnetUser.Branch.Branch_Name),
                CommandArg = ord.ID.ToString()
            };
            db.AccountDailies.InsertOnSubmit(CustomerDept);


            var CutomerPay = new AccountDaily()
            {
                ID = ApiCounter.GetNumber(),
                AccountID = custmerAccountID,
                TotalIn = txtPayment.Text.Todouble(),
                TotalOut = 0f,
                DateOfProcess = DateTime.Now,
                Description = string.Format("Total  Of  A  Order_ Name {0} at time {1}, branch Name {2}", ord.OrderName, DateTime.Now.ToString(), UserInfo.CurrnetUser.Branch.Branch_Name),
                CommandArg = ord.ID.ToString()
            };

            db.AccountDailies.InsertOnSubmit(CutomerPay);
            var BranchCreated = new AccountDaily()
            {
                ID = ApiCounter.GetNumber(),
                AccountID =  UserInfo.CurrnetUser.Branch.AccountID,
                TotalIn = txtPayment.Text.Todouble(),
                TotalOut = 0f,
                DateOfProcess = DateTime.Now,//ord
                Description = string.Format("Total  Of  A  Order_ Name {0} at time {1}, branch Name {2}", ord.OrderName, DateTime.Now.ToString(), UserInfo.CurrnetUser.Branch.Branch_Name),
                CommandArg = ord.ID.ToString()
            };

            db.AccountDailies.InsertOnSubmit(BranchCreated);
            db.SubmitChanges();




            xLastOrderID = CustomerInformations.CurOrder.ID;
            Operation.EndOperation(this);

           
            RadMessageBox.ThemeName = this.ThemeName;
            RadMessageBox.Show("Saved Successfull ....");
            PrintBtn.Enabled = true;
            ReceiptVoucherButton.Enabled = true;
            OkeyBtn.Enabled = false;
        }



        private double ComputeDiscount(double totalCost, double discountValue)
        {
            var netTotalCostPrice = totalCost - (totalCost * (discountValue / 100));

            return netTotalCostPrice;
        }


        private int xLastOrderID;
        private void txtDiscountBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var strvalid = "0123456789.";
            if (e.KeyChar > 26)
            {
                if (((strvalid.IndexOf(e.KeyChar) + 1) == 0))
                {
                    e.KeyChar = '\0';
                }
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            var cmd = new OrderReportCmd();
            cmd.GetOrderBill(xLastOrderID);
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.OpenForms["FrmAddOrderProduct"].Show();
            this.Close();
        }

        private void ReceiptVoucherButton_Click(object sender, EventArgs e)
        {
            //ExchangebondReportCmd.ShowPayment//(TotalPriceBox.Text);
            ExchangebondReportCmd.ShowPayment(cost: txtPayment.Text, Dt: DateTime.Now, customerName: NameLab.Text, vnumber: orderID, payVouterCost: "0", rema: (TotalPriceBox.Text.Todouble() - txtPayment.Text.Todouble()).ToString());
        }
    }
}
