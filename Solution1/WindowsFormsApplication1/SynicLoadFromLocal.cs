using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaDataLayer;
namespace WindowsFormsApplication1
{
    public class SynicLoadFromLocal : IDisposable
    {
        public DbDataContext Remotedb = new DbDataContext();

        public void Dispose()
        {
            if (Remotedb != null)
            {
                Remotedb.Dispose();
                Remotedb = null;
            }
        }
        public SynicLoadFromLocal()
        {
        }

        //public void LoadFromRemote()
        //{
        //    Remotedb = new DbDataContext(Properties.Settings.Default.RemoteConnection);
        //    Remotedb.Connection.ConnectionString = Properties.Settings.Default.LocalConnection;
        //    Remotedb.SubmitChanges();
        //}

        public void LoadFromRemote()
        {
            DbDataContext remotedb = new DbDataContext(Properties.Settings.Default.RemoteConnection);
            DbDataContext localdb = new DbDataContext(Properties.Settings.Default.LocalConnection);
          
            foreach (var item in remotedb.AccountCategories)
            {
                try
                {
                    var q = localdb.AccountCategories.Where(p => p.ID == item.ID).Single();
                    q.AccountCategoryName = item.AccountCategoryName;
                    q.Description=item.Description ;
                    q.ID = item.ID;
                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.AccountCategories.InsertOnSubmit(new AccountCategory() { 
                     AccountCategoryName = item.AccountCategoryName,
                      Description= item.Description,
                       ID = item.ID
                    });
                    localdb.SubmitChanges();
                }
            }

            

            

            #region Debtors

            foreach (var item in remotedb.Debtors)
            {
                try
                {
                    var q = localdb.Debtors.Where(p => p.ID == item.ID).Single();
                    q.AccountID = item.AccountID;
                    q.DebtorName = item.DebtorName;
                    q.ID = item.ID;
                    q.DebtorDescription = item.DebtorDescription;
                    q.Addresss = item.Addresss;
                    q.PhoneNumber = item.PhoneNumber;
                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.Debtors.InsertOnSubmit(new Debtor()
                    {
                        AccountID = item.AccountID,
                        DebtorName = item.DebtorName,
                        ID = item.ID,
                        DebtorDescription = item.DebtorDescription,
                        Addresss = item.Addresss,
                        PhoneNumber = item.PhoneNumber,
                        
                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region Expensses

            foreach (var item in remotedb.Expensses)
            {
                try
                {
                    var q = localdb.Expensses.Where(p => p.ID == item.ID).Single();
                    q.AccountID = item.AccountID;
                    q.ExpenssesName = item.ExpenssesName;
                    q.ID = item.ID;
                    q.Description = item.Description;
                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.Expensses.InsertOnSubmit(new Expenss()
                    {
                       // AccountID = item.AccountID,
                        ExpenssesName = item.ExpenssesName,
                        ID = item.ID,
                        Description = item.Description,
                       

                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region ExpenssesMovment

            foreach (var item in remotedb.ExpenssesMovments)
            {
                try
                {
                    var q = localdb.ExpenssesMovments.Where(p => p.ID == item.ID).Single();
                    q.ExpenssesID = item.ExpenssesID;
                    q.Amount = item.Amount;
                    q.ID = item.ID;
                    q.Description = item.Description;
                    q.DateOfProcess = item.DateOfProcess;
                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.ExpenssesMovments.InsertOnSubmit(new ExpenssesMovment()
                    {
                        ExpenssesID = item.ExpenssesID,
                        Amount = item.Amount,
                        ID = item.ID,
                        Description = item.Description,
                        DateOfProcess = item.DateOfProcess

                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region ExpenssesMovment

            foreach (var item in remotedb.Branches)
            {
                try
                {
                    var q = localdb.Branches.Where(p => p.ID == item.ID).Single();
                    q.Branch_Name = item.Branch_Name;
                    q.Branch_Description = item.Branch_Description;
                    q.ID = item.ID;
                    q.CreatedDate = item.CreatedDate;
                    q.Manager_ID = item.Manager_ID;
                    q.AccountID = item.AccountID;
                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.Branches.InsertOnSubmit(new Branch()
                    {
                    Branch_Name = item.Branch_Name,
                    Branch_Description = item.Branch_Description,
                    ID = item.ID,
                    CreatedDate = item.CreatedDate,
                    Manager_ID = item.Manager_ID,
                    AccountID = item.AccountID,

                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region Customer

            foreach (var item in remotedb.Customers)
            {
                try
                {
                    var q = localdb.Customers.Where(p => p.ID == item.ID).Single();
                    q.CustomerName = item.CustomerName;
                    q.PhoneNumber = item.PhoneNumber;
                    q.ID = item.ID;
                    q.CreateDate = item.CreateDate;
                    q.Points = item.Points;
                  //  q.AccountID = item.AccountID;
                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.Customers.InsertOnSubmit(new Customer()
                    {
                        CustomerName = item.CustomerName,
                        PhoneNumber = item.PhoneNumber,
                        ID = item.ID,
                        CreateDate = item.CreateDate,
                        Points = item.Points,
                        //AccountID = item.AccountID,

                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region Employee

            foreach (var item in remotedb.Employees)
            {
                try
                {
                    var q = localdb.Employees.Where(p => p.ID == item.ID).Single();
                    q.Emp_Name = item.Emp_Name;
                    q.PhoneNumber = item.PhoneNumber;
                    q.ID = item.ID;
                    q.CreateDate = item.CreateDate;
                    q.HereDate = item.HereDate;
                    q.Personalty_ID = item.Personalty_ID;
                    q.Nationalty = item.Nationalty;
                    q.HomeAddress = item.HomeAddress;
                    q.Job = item.Job;
                    
                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.Employees.InsertOnSubmit(new Employee()
                    {
                        Emp_Name = item.Emp_Name,
                        PhoneNumber = item.PhoneNumber,
                        ID = item.ID,
                        CreateDate = item.CreateDate,
                        HereDate = item.HereDate,
                        Personalty_ID = item.Personalty_ID,
                        Nationalty=item.Nationalty,
                        HomeAddress=item.HomeAddress,
                        Job=item.Job,

                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region Order

            foreach (var item in remotedb.Orders)
            {
                try
                {
                    var q = localdb.Orders.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.Branch_ID = item.Branch_ID;
                    q.CustomerID = item.CustomerID;
                    q.OrderName = item.OrderName;
                    q.OrderType = item.OrderType;
                    q.OrderVerify = item.OrderVerify;
                    q.OrderDeliveryDate = item.OrderDeliveryDate;
                    q.Comment = item.Comment;
                    q.OrderStatus = item.OrderStatus;
                    q.TotalAmount = item.TotalAmount;
                    q.OrderAccount = item.OrderAccount;
                    q.OrderDate = item.OrderDate;
                    q.DeliverdToBranch = item.DeliverdToBranch;
                    q.isOrderBranch = item.isOrderBranch;

                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.Orders.InsertOnSubmit(new Order()
                    {
                    ID = item.ID,
                    Branch_ID = item.Branch_ID,
                    CustomerID = item.CustomerID,
                    OrderName = item.OrderName,
                    OrderType = item.OrderType,
                    OrderVerify = item.OrderVerify,
                    OrderDeliveryDate = item.OrderDeliveryDate,
                    Comment = item.Comment,
                    OrderStatus = item.OrderStatus,
                    TotalAmount = item.TotalAmount,
                   // OrderAccount = item.OrderAccount,
                    OrderDate = item.OrderDate,
                    DeliverdToBranch = item.DeliverdToBranch,
                    isOrderBranch = item.isOrderBranch,

                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region OrderProduct

            foreach (var item in remotedb.OrderProducts)
            {
                try
                {
                    var q = localdb.OrderProducts.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.OrderID = item.OrderID;
                    q.ProductID = item.ProductID;
                    q.Qty = item.Qty;
                    q.Description = item.Description;
                    q.ImageX = item.ImageX;
                    q.Status = item.Status;
                   

                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.OrderProducts.InsertOnSubmit(new OrderProduct()
                    {
                    ID = item.ID,
                    
                    OrderID = item.OrderID,
                    ProductID = item.ProductID,
                    Qty = item.Qty,
                    Description = item.Description,
                    ImageX = item.ImageX,
                    Status = item.Status

                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region OrderProuctAttachment

            foreach (var item in remotedb.OrderProuctAttachments)
            {
                try
                {
                    var q = localdb.OrderProuctAttachments.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.imageX = item.imageX;
                    q.OrderProductID = item.OrderProductID;
                    q.CustomerText = item.CustomerText;
                    q.Description = item.Description;
                   


                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.OrderProuctAttachments.InsertOnSubmit(new OrderProuctAttachment()
                    {
                     ID = item.ID,
                    imageX = item.imageX,
                    OrderProductID = item.OrderProductID,
                    CustomerText = item.CustomerText,
                    Description = item.Description
                   

                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region Product

            foreach (var item in remotedb.Products)
            {
                try
                {
                    var q = localdb.Products.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.Product_Name = item.Product_Name;
                    q.Product_Description = item.Product_Description;
                    q.CateogryID = item.CateogryID;
                    q.Img = item.Img;
                    q.PublicName = item.PublicName;
                    q.ProductPrice = item.ProductPrice;
                    q.ProductType = item.ProductType;
                    q.LoadingCost = item.LoadingCost;



                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.Products.InsertOnSubmit(new Product()
                    {
                    ID = item.ID,
                    Product_Name = item.Product_Name,
                    Product_Description = item.Product_Description,
                    CateogryID = item.CateogryID,
                    Img = item.Img,
                    PublicName = item.PublicName,
                    ProductPrice = item.ProductPrice,
                    ProductType = item.ProductType,
                    LoadingCost = item.LoadingCost


                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region ProductCategory

            foreach (var item in remotedb.ProductCategories)
            {
                try
                {
                    var q = localdb.ProductCategories.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.ProductCategoryName = item.ProductCategoryName;
                    q.Description = item.Description;
                  


                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.ProductCategories.InsertOnSubmit(new ProductCategory()
                    {
                        ID = item.ID,
                       ProductCategoryName = item.ProductCategoryName,
                       Description = item.Description


                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region ProductContents

            foreach (var item in remotedb.ProductContents)
            {
                try
                {
                    var q = localdb.ProductContents.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.ProductID = item.ProductID;
                    q.ContentsProductID = item.ContentsProductID;
                    q.Qty = item.Qty;
                    q.unitOfProduct = item.unitOfProduct;



                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.ProductContents.InsertOnSubmit(new ProductContent()
                    {
                        ID = item.ID,
                    ProductID = item.ProductID,
                    ContentsProductID = item.ContentsProductID,
                    Qty = item.Qty,
                    unitOfProduct = item.unitOfProduct


                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region ProductMinimummQty

            foreach (var item in remotedb.ProductMinimummQties)
            {
                try
                {
                    var q = localdb.ProductMinimummQties.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.ProductID = item.ProductID;
                    q.MinimumQty = item.MinimumQty;
                  



                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.ProductMinimummQties.InsertOnSubmit(new ProductMinimummQty()
                    {
                        ID = item.ID,
                        ProductID = item.ProductID,
                        MinimumQty = item.MinimumQty
                       


                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region Quotation

            foreach (var item in remotedb.Quotations)
            {
                try
                {
                    var q = localdb.Quotations.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.QuotationFor = item.QuotationFor;
                    q.CreatedDate = item.CreatedDate;
                    q.AddressFor = item.AddressFor;
                    q.PhoneNumber = item.PhoneNumber;
                    q.Description = item.Description;



                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.Quotations.InsertOnSubmit(new Quotation()
                    {
                     ID = item.ID,
                    QuotationFor = item.QuotationFor,
                    CreatedDate = item.CreatedDate,
                    AddressFor = item.AddressFor,
                    PhoneNumber = item.PhoneNumber,
                    Description = item.Description



                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region QuotationProduct

            foreach (var item in remotedb.QuotationProducts)
            {
                try
                {
                    var q = localdb.QuotationProducts.Where(p => p.id == item.id).Single();
                    q.id = item.id;
                    q.QuotationID = item.QuotationID;
                    q.ProductID = item.ProductID;
                    q.Description = item.Description;
                    q.Qty = item.Qty;
                  



                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.QuotationProducts.InsertOnSubmit(new QuotationProduct()
                    {
                        id = item.id,
                        QuotationID = item.QuotationID,
                        ProductID = item.ProductID,
                        Qty = item.Qty,
                        Description = item.Description



                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region Inbox

            foreach (var item in remotedb.Inboxes)
            {
                try
                {
                    var q = localdb.Inboxes.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.Subject = item.Subject;
                    q.MessageText = item.MessageText;
                    q.DateOfMessage = item.DateOfMessage;
                    q.SenderUserID = item.SenderUserID;
                    q.ReciverUserID = item.ReciverUserID;
                    q.Status = item.Status;




                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.Inboxes.InsertOnSubmit(new Inbox()
                    {
                    ID = item.ID,
                    Subject = item.Subject,
                    MessageText = item.MessageText,
                    DateOfMessage = item.DateOfMessage,
                    SenderUserID = item.SenderUserID,
                    ReciverUserID = item.ReciverUserID,
                    Status = item.Status



                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region OutBox

            foreach (var item in remotedb.OutBoxes)
            {
                try
                {
                    var q = localdb.OutBoxes.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.Subject = item.Subject;
                    q.MessageText = item.MessageText;
                    q.DateOfMessage = item.DateOfMessage;
                    q.SenderUserID = item.SenderUserID;
                    q.ReciverUserID = item.ReciverUserID;
                    q.Status = item.Status;




                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.OutBoxes.InsertOnSubmit(new OutBox()
                    {
                        ID = item.ID,
                        Subject = item.Subject,
                        MessageText = item.MessageText,
                        DateOfMessage = item.DateOfMessage,
                        SenderUserID = item.SenderUserID,
                        ReciverUserID = item.ReciverUserID,
                        Status = item.Status



                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

           #region OrderPurches

            foreach (var item in remotedb.OrderPurches)
            {
                try
                {
                    var q = localdb.OrderPurches.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.OrderDate = item.OrderDate;
                    q.SuplierID = item.SuplierID;
                    q.Comment = item.Comment;
                                      
                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.OrderPurches.InsertOnSubmit(new OrderPurch()
                    {
                        ID = item.ID,
                        OrderDate = item.OrderDate,
                        SuplierID = item.SuplierID,
                        Comment = item.Comment,
                       


                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

           #region ProductOrderPurchus

            foreach (var item in remotedb.ProductOrderPurchus)
            {
                try
                {
                    var q = localdb.ProductOrderPurchus.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.ProductID = item.ProductID;
                    q.Qty = item.Qty;
                    q.Unit = item.Unit;
                    q.OrderPurchusID = item.OrderPurchusID;

                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.ProductOrderPurchus.InsertOnSubmit(new ProductOrderPurchus()
                    {
                        ID = item.ID,
                    ProductID = item.ProductID,
                    Qty = item.Qty,
                    Unit = item.Unit,
                    OrderPurchusID = item.OrderPurchusID



                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region Purchases

            foreach (var item in remotedb.Purchases)
            {
                try
                {
                    var q = localdb.Purchases.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.ProductID = item.ProductID;
                    q.Qty = item.Qty;
                    q.CostAmount = item.CostAmount;
                    q.SupplierID = item.SupplierID;
                    q.AccountID = item.AccountID;
                    q.BillNumber = item.BillNumber;
                    q.ProductBarcode = item.ProductBarcode;
                    q.SerialNumber = item.SerialNumber;
                    q.expierdDate = item.expierdDate;
                    q.dateOfProcess = item.dateOfProcess;

                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.Purchases.InsertOnSubmit(new Purchase()
                    {
                    ID = item.ID,
                    ProductID = item.ProductID,
                    Qty = item.Qty,
                    CostAmount = item.CostAmount,
                    SupplierID = item.SupplierID,
                    AccountID = item.AccountID,
                    BillNumber = item.BillNumber,
                    ProductBarcode = item.ProductBarcode,
                    SerialNumber = item.SerialNumber,
                    expierdDate = item.expierdDate,
                    dateOfProcess = item.dateOfProcess




                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region Store

            foreach (var item in remotedb.Stores)
            {
                try
                {
                    var q = localdb.Stores.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.ProductID = item.ProductID;
                    q.AvailableQty = item.AvailableQty;
                    q.Description = item.Description;
                    q.ExpiredDate = item.ExpiredDate;
                   
                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.Stores.InsertOnSubmit(new Store()
                    {
                    ID = item.ID,
                    ProductID = item.ProductID,
                    AvailableQty = item.AvailableQty,
                    Description = item.Description,
                    ExpiredDate = item.ExpiredDate



                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region Store_Sells

            foreach (var item in remotedb.Store_Sells)
            {
                try
                {
                    var q = localdb.Store_Sells.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.ProductID = item.ProductID;
                    q.Price = item.Price;
                    q.UnitPrice = item.UnitPrice;
                    q.DateOfProcess = item.DateOfProcess;
                    q.Comment = item.Comment;
                    q.UserID = item.UserID;
                    q.SupplierID = item.SupplierID;
                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.Store_Sells.InsertOnSubmit(new Store_Sell()
                    {
                     ID = item.ID,
                    ProductID = item.ProductID,
                    Price = item.Price,
                    UnitPrice = item.UnitPrice,
                    DateOfProcess = item.DateOfProcess,
                    Comment = item.Comment,
                    UserID = item.UserID,
                    SupplierID = item.SupplierID



                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region StoreManager

            foreach (var item in remotedb.StoreManagers)
            {
                try
                {
                    var q = localdb.StoreManagers.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.StoreID = item.StoreID;
                    q.QtyInOrOut = item.QtyInOrOut;
                    q.DateOfProcess = item.DateOfProcess;
                    q.ProcessType = item.ProcessType;
                    q.Price = item.Price;
                    q.Description = item.Description;
                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.StoreManagers.InsertOnSubmit(new StoreManager()
                    {
                    ID = item.ID,
                    StoreID = item.StoreID,
                    QtyInOrOut = item.QtyInOrOut,
                    DateOfProcess = item.DateOfProcess,
                    ProcessType = item.ProcessType,
                   Price = item.Price,
                    Description = item.Description



                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region StoreWithDrawal

            foreach (var item in remotedb.StoreWithDrawals)
            {
                try
                {
                    var q = localdb.StoreWithDrawals.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.StoreID = item.StoreID;
                    q.ProductID = item.ProductID;
                    q.DateOfProcess = item.DateOfProcess;
                    q.Qty = item.Qty;
                    q.Comment = item.Comment;
                    q.UserID = item.UserID;
                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.StoreWithDrawals.InsertOnSubmit(new StoreWithDrawal()
                    {
                        ID = item.ID,
                        StoreID = item.StoreID,
                        ProductID = item.ProductID,
                    DateOfProcess = item.DateOfProcess,
                    Qty = item.Qty,
                    Comment = item.Comment,
                    UserID = item.UserID



                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region Supplier

            foreach (var item in remotedb.Suppliers)
            {
                try
                {
                    var q = localdb.Suppliers.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.SupplierName = item.SupplierName;
                    q.SupplierPhone = item.SupplierPhone;
                    q.Address = item.Address;
                    q.Description = item.Description;
                    localdb.SubmitChanges();

                }
                catch (Exception ex)
                {
                    localdb.Suppliers.InsertOnSubmit(new Supplier()
                    {
                        ID = item.ID,
                        SupplierName = item.SupplierName,
                    SupplierPhone = item.SupplierPhone,
                    Address = item.Address,
                    Description = item.Description



                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region History

            foreach (var item in remotedb.Histories)
            {
                try
                {
                    var q = localdb.Histories.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.HistoryAction = item.HistoryAction;
                    q.DateOfProcess = item.DateOfProcess;
                    q.ActionName = item.ActionName;
                    q.Description = item.Description;
                    q.UserID = item.UserID;
                    localdb.SubmitChanges();

                }
                catch (Exception ex)
                {
                    localdb.Histories.InsertOnSubmit(new History()
                    {
                        ID = item.ID,
                         HistoryAction = item.HistoryAction,
                    DateOfProcess = item.DateOfProcess,
                    ActionName = item.ActionName,
                    Description = item.Description,
                    UserID = item.UserID




                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region SystemPermession

            foreach (var item in remotedb.SystemPermessions)
            {
                try
                {
                    var q = localdb.SystemPermessions.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.Permession = item.Permession;
                    q.Description = item.Description;
                    localdb.SubmitChanges();

                }
                catch (Exception ex)
                {
                    localdb.SystemPermessions.InsertOnSubmit(new SystemPermession()
                    {
                        ID = item.ID,
                       Permession = item.Permession,
                       Description = item.Description,




                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region SystemSettings

            foreach (var item in remotedb.SystemSettings)
            {
                try
                {
                    var q = localdb.SystemSettings.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.SettingName = item.SettingName;
                    q.SettingValue = item.SettingValue;
                    q.BinaryValue = item.BinaryValue;
                    q.SerialNumber = item.SerialNumber;
                    q.CommandArg = item.CommandArg;
                    localdb.SubmitChanges();

                }
                catch (Exception ex)
                {
                    localdb.SystemSettings.InsertOnSubmit(new SystemSetting()
                    {
                    ID = item.ID,
                    SettingName = item.SettingName,
                    SettingValue = item.SettingValue,
                    BinaryValue = item.BinaryValue,
                    SerialNumber = item.SerialNumber,
                    CommandArg = item.CommandArg




                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion


            #region UserPermession

            foreach (var item in remotedb.UserPermessions)
            {
                try
                {
                    var q = localdb.UserPermessions.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.SystemPermessionID = item.SystemPermessionID;
                    q.UserID = item.UserID;
                    q.PermessionValue = item.PermessionValue;
                    localdb.SubmitChanges();

                }
                catch (Exception ex)
                {
                    localdb.UserPermessions.InsertOnSubmit(new UserPermession ()
                    {
                    ID = item.ID,
                    SystemPermessionID = item.SystemPermessionID,
                    UserID = item.UserID,
                    PermessionValue = item.PermessionValue




                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region Users

            foreach (var item in remotedb.Users)
            {
                try
                {
                    var q = localdb.Users.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.UserName = item.UserName;
                    q.Passwords = item.Passwords;
                    q.Branch_ID = item.Branch_ID;

                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.Users.InsertOnSubmit(new User()
                    {
                        ID = item.ID,
                         UserName = item.UserName,
                    Passwords = item.Passwords,
                    Branch_ID = item.Branch_ID





                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region Bill

            foreach (var item in remotedb.Bills)
            {
                try
                {
                    var q = localdb.Bills.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.BillDate = item.BillDate;
                    q.BillNumber = item.BillNumber;
                    q.UserID = item.UserID;
                    q.BillTotal = item.BillTotal;
                    q.paytype = item.paytype;
                    q.description = item.description;
                    q.CustomerID = item.CustomerID;

                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.Bills.InsertOnSubmit(new Bill()
                    {
                    ID = item.ID,
                    BillDate = item.BillDate,
                    BillNumber = item.BillNumber,
                    UserID = item.UserID,
                    BillTotal = item.BillTotal,
                    paytype = item.paytype,
                    description = item.description,
                    CustomerID = item.CustomerID





                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region BillItem

            foreach (var item in remotedb.BillItems)
            {
                try
                {
                    var q = localdb.BillItems.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.ProductID = item.ProductID;
                    q.Qty = item.Qty;
                    q.Bill_ID = item.Bill_ID;
                    q.Status = item.Status;
                   // q.WZN = item.WZN;

                    localdb.SubmitChanges();

                }
                catch (Exception ex)
                {
                    localdb.BillItems.InsertOnSubmit(new BillItem()
                    {
                    ID = item.ID,
                    ProductID = item.ProductID,
                    Qty = item.Qty,
                    Bill_ID = item.Bill_ID,
                    Status = item.Status,
                   // WZN = item.WZN





                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region SellStore

            foreach (var item in remotedb.SellStores)
            {
                try
                {
                    var q = localdb.SellStores.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.ItemID = item.ItemID;
                    q.Qty = item.Qty;
                    q.branchID = item.branchID;

                    localdb.SubmitChanges();


                }
                catch (Exception ex)
                {
                    localdb.SellStores.InsertOnSubmit(new SellStore()
                    {
                        ID = item.ID,
                        ItemID = item.ItemID,
                        Qty = item.Qty,
                        branchID = item.branchID,
                       





                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region StoreOperationManager

            foreach (var item in remotedb.StoreOperationManagers)
            {
                try
                {
                    var q = localdb.StoreOperationManagers.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.StoreID = item.StoreID;
                    q.Qty = item.Qty;
                    q.ProcessDate = item.ProcessDate;
                    q.ProcessType = item.ProcessType;
                    q.UserID = item.UserID;

                    localdb.SubmitChanges();

                }
                catch (Exception ex)
                {
                    localdb.StoreOperationManagers.InsertOnSubmit(new StoreOperationManager()
                    {
                        ID = item.ID,
                        StoreID = item.StoreID,
                        Qty = item.Qty,
                        ProcessType = item.ProcessType,

                        ProcessDate = item.ProcessDate,
                        UserID=item.UserID





                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion
            #region Account

            foreach (var item in remotedb.Accounts)
            {
                try
                {
                    var q = localdb.Accounts.Where(p => p.ID == item.ID).Single();
                    q.AccountName = item.AccountName;
                    q.Description = item.Description;
                    q.ID = item.ID;
                    q.CategoryID = item.CategoryID;
                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.Accounts.InsertOnSubmit(new Account()
                    {
                        AccountName = item.AccountName,
                        Description = item.Description,
                        ID = item.ID,
                        CategoryID = item.CategoryID,
                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion

            #region AccountDaily

            foreach (var item in remotedb.AccountDailies)
            {
                try
                {
                    var q = localdb.AccountDailies.Where(p => p.ID == item.ID).Single();
                    q.AccountID = item.AccountID;
                    q.DateOfProcess = item.DateOfProcess;
                    q.ID = item.ID;
                    q.TotalIn = item.TotalIn;
                    q.TotalOut = item.TotalOut;
                    q.Description = item.Description;
                    q.CommandArg = item.CommandArg;
                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    localdb.AccountDailies.InsertOnSubmit(new AccountDaily()
                    {
                        AccountID = item.AccountID,
                        DateOfProcess = item.DateOfProcess,
                        ID = item.ID,
                        TotalIn = item.TotalIn,
                        TotalOut = item.TotalOut,
                        Description = item.Description,
                        CommandArg = item.CommandArg,
                    });
                    localdb.SubmitChanges();
                }
            }
            #endregion
        }

    }
}
