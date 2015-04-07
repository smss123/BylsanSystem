using System;
using System.Collections.Generic;
using System.Linq;
using XamaDataLayer;

namespace WindowsFormsApplication1
{
    public class SynicLoadFromRemote
    {
        public void LoadFromLocal()
        {
            DbDataContext remotedb = new DbDataContext(Properties.Settings.Default.RemoteConnection);
            DbDataContext localdb = new DbDataContext(Properties.Settings.Default.LocalConnection);

            foreach (var item in localdb.AccountCategories)
            {
                try
                {
                    var q = remotedb.AccountCategories.Where(p => p.ID == item.ID).Single();
                    q.AccountCategoryName = item.AccountCategoryName;
                    q.Description = item.Description;
                    q.ID = item.ID;
                    remotedb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.AccountCategories.InsertOnSubmit(new AccountCategory()
                    {
                        AccountCategoryName = item.AccountCategoryName,
                        Description = item.Description,
                        ID = item.ID
                    });
                    remotedb.SubmitChanges();
                }
            }


            

            

            #region Debtors

            foreach (var item in localdb.Debtors)
            {
                try
                {
                    var q = remotedb.Debtors.Where(p => p.ID == item.ID).Single();
                    q.AccountID = item.AccountID;
                    q.DebtorName = item.DebtorName;
                    q.ID = item.ID;
                    q.DebtorDescription = item.DebtorDescription;
                    q.Addresss = item.Addresss;
                    q.PhoneNumber = item.PhoneNumber;
                    remotedb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.Debtors.InsertOnSubmit(new Debtor()
                    {
                        AccountID = item.AccountID,
                        DebtorName = item.DebtorName,
                        ID = item.ID,
                        DebtorDescription = item.DebtorDescription,
                        Addresss = item.Addresss,
                        PhoneNumber = item.PhoneNumber,

                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region Expensses

            foreach (var item in localdb.Expensses)
            {
                try
                {
                    var q = remotedb.Expensses.Where(p => p.ID == item.ID).Single();
                    q.AccountID = item.AccountID;
                    q.ExpenssesName = item.ExpenssesName;
                    q.ID = item.ID;
                    q.Description = item.Description;
                    remotedb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.Expensses.InsertOnSubmit(new Expenss()
                    {
                        AccountID = item.AccountID,
                        ExpenssesName = item.ExpenssesName,
                        ID = item.ID,
                        Description = item.Description,


                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region ExpenssesMovment

            foreach (var item in localdb.ExpenssesMovments)
            {
                try
                {
                    var q = remotedb.ExpenssesMovments.Where(p => p.ID == item.ID).Single();
                    q.ExpenssesID = item.ExpenssesID;
                    q.Amount = item.Amount;
                    q.ID = item.ID;
                    q.Description = item.Description;
                    q.DateOfProcess = item.DateOfProcess;
                    remotedb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.ExpenssesMovments.InsertOnSubmit(new ExpenssesMovment()
                    {
                        ExpenssesID = item.ExpenssesID,
                        Amount = item.Amount,
                        ID = item.ID,
                        Description = item.Description,
                        DateOfProcess = item.DateOfProcess

                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region ExpenssesMovment

            foreach (var item in localdb.Branches)
            {
                try
                {
                    var q = remotedb.Branches.Where(p => p.ID == item.ID).Single();
                    q.Branch_Name = item.Branch_Name;
                    q.Branch_Description = item.Branch_Description;
                    q.ID = item.ID;
                    q.CreatedDate = item.CreatedDate;
                    q.Manager_ID = item.Manager_ID;
                    q.AccountID = item.AccountID;
                    remotedb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.Branches.InsertOnSubmit(new Branch()
                    {
                        Branch_Name = item.Branch_Name,
                        Branch_Description = item.Branch_Description,
                        ID = item.ID,
                        CreatedDate = item.CreatedDate,
                        Manager_ID = item.Manager_ID,
                        AccountID = item.AccountID,

                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region Customer

            foreach (var item in localdb.Customers)
            {
                try
                {
                    var q = remotedb.Customers.Where(p => p.ID == item.ID).Single();
                    q.CustomerName = item.CustomerName;
                    q.PhoneNumber = item.PhoneNumber;
                    q.ID = item.ID;
                    q.CreateDate = item.CreateDate;
                    q.Points = item.Points;
                    //q.AccountID = item.AccountID;
                    remotedb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.Customers.InsertOnSubmit(new Customer()
                    {
                        CustomerName = item.CustomerName,
                        PhoneNumber = item.PhoneNumber,
                        ID = item.ID,
                        CreateDate = item.CreateDate,
                        Points = item.Points,
                      //  AccountID = item.AccountID,

                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region Employee

            foreach (var item in localdb.Employees)
            {
                try
                {
                    var q = remotedb.Employees.Where(p => p.ID == item.ID).Single();
                    q.Emp_Name = item.Emp_Name;
                    q.PhoneNumber = item.PhoneNumber;
                    q.ID = item.ID;
                    q.CreateDate = item.CreateDate;
                    q.HereDate = item.HereDate;
                    q.Personalty_ID = item.Personalty_ID;
                    q.Nationalty = item.Nationalty;
                    q.HomeAddress = item.HomeAddress;
                    q.Job = item.Job;

                    remotedb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.Employees.InsertOnSubmit(new Employee()
                    {
                        Emp_Name = item.Emp_Name,
                        PhoneNumber = item.PhoneNumber,
                        ID = item.ID,
                        CreateDate = item.CreateDate,
                        HereDate = item.HereDate,
                        Personalty_ID = item.Personalty_ID,
                        Nationalty = item.Nationalty,
                        HomeAddress = item.HomeAddress,
                        Job = item.Job,

                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region Order

            foreach (var item in localdb.Orders)
            {
                try
                {
                    var q = remotedb.Orders.Where(p => p.ID == item.ID).Single();
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

                    remotedb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.Orders.InsertOnSubmit(new Order()
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
                        OrderAccount = item.OrderAccount,
                        OrderDate = item.OrderDate,
                        DeliverdToBranch = item.DeliverdToBranch,
                        isOrderBranch = item.isOrderBranch,

                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region OrderProduct

            foreach (var item in localdb.OrderProducts)
            {
                try
                {
                    var q = remotedb.OrderProducts.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.OrderID = item.OrderID;
                    q.ProductID = item.ProductID;
                    q.Qty = item.Qty;
                    q.Description = item.Description;
                    q.ImageX = item.ImageX;
                    q.Status = item.Status;


                    remotedb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.OrderProducts.InsertOnSubmit(new OrderProduct()
                    {
                        ID = item.ID,

                        OrderID = item.OrderID,
                        ProductID = item.ProductID,
                        Qty = item.Qty,
                        Description = item.Description,
                        ImageX = item.ImageX,
                        Status = item.Status

                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region OrderProuctAttachment

            foreach (var item in localdb.OrderProuctAttachments)
            {
                try
                {
                    var q = remotedb.OrderProuctAttachments.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.imageX = item.imageX;
                    q.OrderProductID = item.OrderProductID;
                    q.CustomerText = item.CustomerText;
                    q.Description = item.Description;



                    remotedb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.OrderProuctAttachments.InsertOnSubmit(new OrderProuctAttachment()
                    {
                        ID = item.ID,
                        imageX = item.imageX,
                        OrderProductID = item.OrderProductID,
                        CustomerText = item.CustomerText,
                        Description = item.Description


                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region Product

            foreach (var item in localdb.Products)
            {
                try
                {
                    var q = remotedb.Products.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.Product_Name = item.Product_Name;
                    q.Product_Description = item.Product_Description;
                    q.CateogryID = item.CateogryID;
                    q.Img = item.Img;
                    q.PublicName = item.PublicName;
                    q.ProductPrice = item.ProductPrice;
                    q.ProductType = item.ProductType;
                    q.LoadingCost = item.LoadingCost;



                    remotedb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.Products.InsertOnSubmit(new Product()
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
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region ProductCategory

            foreach (var item in localdb.ProductCategories)
            {
                try
                {
                    var q = remotedb.ProductCategories.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.ProductCategoryName = item.ProductCategoryName;
                    q.Description = item.Description;



                    remotedb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.ProductCategories.InsertOnSubmit(new ProductCategory()
                    {
                        ID = item.ID,
                        ProductCategoryName = item.ProductCategoryName,
                        Description = item.Description


                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region ProductContents

            foreach (var item in localdb.ProductContents)
            {
                try
                {
                    var q = remotedb.ProductContents.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.ProductID = item.ProductID;
                    q.ContentsProductID = item.ContentsProductID;
                    q.Qty = item.Qty;
                    q.unitOfProduct = item.unitOfProduct;



                    remotedb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.ProductContents.InsertOnSubmit(new ProductContent()
                    {
                        ID = item.ID,
                        ProductID = item.ProductID,
                        ContentsProductID = item.ContentsProductID,
                        Qty = item.Qty,
                        unitOfProduct = item.unitOfProduct


                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region ProductMinimummQty

            foreach (var item in localdb.ProductMinimummQties)
            {
                try
                {
                    var q = remotedb.ProductMinimummQties.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.ProductID = item.ProductID;
                    q.MinimumQty = item.MinimumQty;




                    remotedb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.ProductMinimummQties.InsertOnSubmit(new ProductMinimummQty()
                    {
                        ID = item.ID,
                        ProductID = item.ProductID,
                        MinimumQty = item.MinimumQty



                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region Quotation

            foreach (var item in localdb.Quotations)
            {
                try
                {
                    var q = remotedb.Quotations.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.QuotationFor = item.QuotationFor;
                    q.CreatedDate = item.CreatedDate;
                    q.AddressFor = item.AddressFor;
                    q.PhoneNumber = item.PhoneNumber;
                    q.Description = item.Description;



                    remotedb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.Quotations.InsertOnSubmit(new Quotation()
                    {
                        ID = item.ID,
                        QuotationFor = item.QuotationFor,
                        CreatedDate = item.CreatedDate,
                        AddressFor = item.AddressFor,
                        PhoneNumber = item.PhoneNumber,
                        Description = item.Description



                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region QuotationProduct

            foreach (var item in localdb.QuotationProducts)
            {
                try
                {
                    var q = remotedb.QuotationProducts.Where(p => p.id == item.id).Single();
                    q.id = item.id;
                    q.QuotationID = item.QuotationID;
                    q.ProductID = item.ProductID;
                    q.Description = item.Description;
                    q.Qty = item.Qty;




                    remotedb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.QuotationProducts.InsertOnSubmit(new QuotationProduct()
                    {
                        id = item.id,
                        QuotationID = item.QuotationID,
                        ProductID = item.ProductID,
                        Qty = item.Qty,
                        Description = item.Description



                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region Inbox

            foreach (var item in localdb.Inboxes)
            {
                try
                {
                    var q = remotedb.Inboxes.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.Subject = item.Subject;
                    q.MessageText = item.MessageText;
                    q.DateOfMessage = item.DateOfMessage;
                    q.SenderUserID = item.SenderUserID;
                    q.ReciverUserID = item.ReciverUserID;
                    q.Status = item.Status;




                    remotedb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.Inboxes.InsertOnSubmit(new Inbox()
                    {
                        ID = item.ID,
                        Subject = item.Subject,
                        MessageText = item.MessageText,
                        DateOfMessage = item.DateOfMessage,
                        SenderUserID = item.SenderUserID,
                        ReciverUserID = item.ReciverUserID,
                        Status = item.Status



                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region OutBox

            foreach (var item in localdb.OutBoxes)
            {
                try
                {
                    var q = remotedb.OutBoxes.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.Subject = item.Subject;
                    q.MessageText = item.MessageText;
                    q.DateOfMessage = item.DateOfMessage;
                    q.SenderUserID = item.SenderUserID;
                    q.ReciverUserID = item.ReciverUserID;
                    q.Status = item.Status;




                    remotedb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.OutBoxes.InsertOnSubmit(new OutBox()
                    {
                        ID = item.ID,
                        Subject = item.Subject,
                        MessageText = item.MessageText,
                        DateOfMessage = item.DateOfMessage,
                        SenderUserID = item.SenderUserID,
                        ReciverUserID = item.ReciverUserID,
                        Status = item.Status



                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region OrderPurches

            foreach (var item in localdb.OrderPurches)
            {
                try
                {
                    var q = remotedb.OrderPurches.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.OrderDate = item.OrderDate;
                    q.SuplierID = item.SuplierID;
                    q.Comment = item.Comment;

                    remotedb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.OrderPurches.InsertOnSubmit(new OrderPurch()
                    {
                        ID = item.ID,
                        OrderDate = item.OrderDate,
                        SuplierID = item.SuplierID,
                        Comment = item.Comment,



                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region ProductOrderPurchus

            foreach (var item in localdb.ProductOrderPurchus)
            {
                try
                {
                    var q = remotedb.ProductOrderPurchus.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.ProductID = item.ProductID;
                    q.Qty = item.Qty;
                    q.Unit = item.Unit;
                    q.OrderPurchusID = item.OrderPurchusID;

                    remotedb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.ProductOrderPurchus.InsertOnSubmit(new ProductOrderPurchus()
                    {
                        ID = item.ID,
                        ProductID = item.ProductID,
                        Qty = item.Qty,
                        Unit = item.Unit,
                        OrderPurchusID = item.OrderPurchusID



                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region Purchases

            foreach (var item in localdb.Purchases)
            {
                try
                {
                    var q = remotedb.Purchases.Where(p => p.ID == item.ID).Single();
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

                    remotedb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.Purchases.InsertOnSubmit(new Purchase()
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
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region Store

            foreach (var item in localdb.Stores)
            {
                try
                {
                    var q = remotedb.Stores.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.ProductID = item.ProductID;
                    q.AvailableQty = item.AvailableQty;
                    q.Description = item.Description;
                    q.ExpiredDate = item.ExpiredDate;

                    remotedb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.Stores.InsertOnSubmit(new Store()
                    {
                        ID = item.ID,
                        ProductID = item.ProductID,
                        AvailableQty = item.AvailableQty,
                        Description = item.Description,
                        ExpiredDate = item.ExpiredDate



                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region Store_Sells

            foreach (var item in localdb.Store_Sells)
            {
                try
                {
                    var q = remotedb.Store_Sells.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.ProductID = item.ProductID;
                    q.Price = item.Price;
                    q.UnitPrice = item.UnitPrice;
                    q.DateOfProcess = item.DateOfProcess;
                    q.Comment = item.Comment;
                    q.UserID = item.UserID;
                    q.SupplierID = item.SupplierID;
                    remotedb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.Store_Sells.InsertOnSubmit(new Store_Sell()
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
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region StoreManager

            foreach (var item in localdb.StoreManagers)
            {
                try
                {
                    var q = remotedb.StoreManagers.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.StoreID = item.StoreID;
                    q.QtyInOrOut = item.QtyInOrOut;
                    q.DateOfProcess = item.DateOfProcess;
                    q.ProcessType = item.ProcessType;
                    q.Price = item.Price;
                    q.Description = item.Description;
                    remotedb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.StoreManagers.InsertOnSubmit(new StoreManager()
                    {
                        ID = item.ID,
                        StoreID = item.StoreID,
                        QtyInOrOut = item.QtyInOrOut,
                        DateOfProcess = item.DateOfProcess,
                        ProcessType = item.ProcessType,
                        Price = item.Price,
                        Description = item.Description



                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region StoreWithDrawal

            foreach (var item in localdb.StoreWithDrawals)
            {
                try
                {
                    var q = remotedb.StoreWithDrawals.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.StoreID = item.StoreID;
                    q.ProductID = item.ProductID;
                    q.DateOfProcess = item.DateOfProcess;
                    q.Qty = item.Qty;
                    q.Comment = item.Comment;
                    q.UserID = item.UserID;
                    remotedb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.StoreWithDrawals.InsertOnSubmit(new StoreWithDrawal()
                    {
                        ID = item.ID,
                        StoreID = item.StoreID,
                        ProductID = item.ProductID,
                        DateOfProcess = item.DateOfProcess,
                        Qty = item.Qty,
                        Comment = item.Comment,
                        UserID = item.UserID



                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region Supplier

            foreach (var item in localdb.Suppliers)
            {
                try
                {
                    var q = remotedb.Suppliers.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.SupplierName = item.SupplierName;
                    q.SupplierPhone = item.SupplierPhone;
                    q.Address = item.Address;
                    q.Description = item.Description;
                    remotedb.SubmitChanges();

                }
                catch (Exception ex)
                {
                    remotedb.Suppliers.InsertOnSubmit(new Supplier()
                    {
                        ID = item.ID,
                        SupplierName = item.SupplierName,
                        SupplierPhone = item.SupplierPhone,
                        Address = item.Address,
                        Description = item.Description



                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region History

            foreach (var item in localdb.Histories)
            {
                try
                {
                    var q = remotedb.Histories.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.HistoryAction = item.HistoryAction;
                    q.DateOfProcess = item.DateOfProcess;
                    q.ActionName = item.ActionName;
                    q.Description = item.Description;
                    q.UserID = item.UserID;
                    remotedb.SubmitChanges();

                }
                catch (Exception ex)
                {
                    remotedb.Histories.InsertOnSubmit(new History()
                    {
                        ID = item.ID,
                        HistoryAction = item.HistoryAction,
                        DateOfProcess = item.DateOfProcess,
                        ActionName = item.ActionName,
                        Description = item.Description,
                        UserID = item.UserID




                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region SystemPermession

            foreach (var item in localdb.SystemPermessions)
            {
                try
                {
                    var q = remotedb.SystemPermessions.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.Permession = item.Permession;
                    q.Description = item.Description;
                    remotedb.SubmitChanges();

                }
                catch (Exception ex)
                {
                    remotedb.SystemPermessions.InsertOnSubmit(new SystemPermession()
                    {
                        ID = item.ID,
                        Permession = item.Permession,
                        Description = item.Description,




                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region SystemSettings

            foreach (var item in localdb.SystemSettings)
            {
                try
                {
                    var q = remotedb.SystemSettings.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.SettingName = item.SettingName;
                    q.SettingValue = item.SettingValue;
                    q.BinaryValue = item.BinaryValue;
                    q.SerialNumber = item.SerialNumber;
                    q.CommandArg = item.CommandArg;
                    remotedb.SubmitChanges();

                }
                catch (Exception ex)
                {
                    remotedb.SystemSettings.InsertOnSubmit(new SystemSetting()
                    {
                        ID = item.ID,
                        SettingName = item.SettingName,
                        SettingValue = item.SettingValue,
                        BinaryValue = item.BinaryValue,
                        SerialNumber = item.SerialNumber,
                        CommandArg = item.CommandArg




                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion


            #region UserPermession

            foreach (var item in localdb.UserPermessions)
            {
                try
                {
                    var q = remotedb.UserPermessions.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.SystemPermessionID = item.SystemPermessionID;
                    q.UserID = item.UserID;
                    q.PermessionValue = item.PermessionValue;
                    remotedb.SubmitChanges();

                }
                catch (Exception ex)
                {
                    remotedb.UserPermessions.InsertOnSubmit(new UserPermession()
                    {
                        ID = item.ID,
                        SystemPermessionID = item.SystemPermessionID,
                        UserID = item.UserID,
                        PermessionValue = item.PermessionValue




                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region Users

            foreach (var item in localdb.Users)
            {
                try
                {
                    var q = remotedb.Users.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.UserName = item.UserName;
                    q.Passwords = item.Passwords;
                    q.Branch_ID = item.Branch_ID;

                    remotedb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.Users.InsertOnSubmit(new User()
                    {
                        ID = item.ID,
                        UserName = item.UserName,
                        Passwords = item.Passwords,
                        Branch_ID = item.Branch_ID





                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region Bill

            foreach (var item in localdb.Bills)
            {
                try
                {
                    var q = remotedb.Bills.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.BillDate = item.BillDate;
                    q.BillNumber = item.BillNumber;
                    q.UserID = item.UserID;
                    q.BillTotal = item.BillTotal;
                    q.paytype = item.paytype;
                    q.description = item.description;
                    q.CustomerID = item.CustomerID;
                    remotedb.SubmitChanges();

                }
                catch (Exception ex)
                {
                    remotedb.Bills.InsertOnSubmit(new Bill()
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
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region BillItem

            foreach (var item in localdb.BillItems)
            {
                try
                {
                    var q = remotedb.BillItems.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.ProductID = item.ProductID;
                    q.Qty = item.Qty;
                    q.Bill_ID = item.Bill_ID;
                    q.Status = item.Status;
                    // q.WZN = item.WZN;

                    remotedb.SubmitChanges();

                }
                catch (Exception ex)
                {
                    remotedb.BillItems.InsertOnSubmit(new BillItem()
                    {
                        ID = item.ID,
                        ProductID = item.ProductID,
                        Qty = item.Qty,
                        Bill_ID = item.Bill_ID,
                        Status = item.Status,
                        // WZN = item.WZN





                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region SellStore

            foreach (var item in localdb.SellStores)
            {
                try
                {
                    var q = remotedb.SellStores.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.ItemID = item.ItemID;
                    q.Qty = item.Qty;
                    q.branchID = item.branchID;

                    remotedb.SubmitChanges();


                }
                catch (Exception ex)
                {
                    remotedb.SellStores.InsertOnSubmit(new SellStore()
                    {
                        ID = item.ID,
                        ItemID = item.ItemID,
                        Qty = item.Qty,
                        branchID = item.branchID,






                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region StoreOperationManager

            foreach (var item in localdb.StoreOperationManagers)
            {
                try
                {
                    var q = remotedb.StoreOperationManagers.Where(p => p.ID == item.ID).Single();
                    q.ID = item.ID;
                    q.StoreID = item.StoreID;
                    q.Qty = item.Qty;
                    q.ProcessDate = item.ProcessDate;
                    q.ProcessType = item.ProcessType;
                    q.UserID = item.UserID;

                    remotedb.SubmitChanges();

                }
                catch (Exception ex)
                {
                    remotedb.StoreOperationManagers.InsertOnSubmit(new StoreOperationManager()
                    {
                        ID = item.ID,
                        StoreID = item.StoreID,
                        Qty = item.Qty,
                        ProcessType = item.ProcessType,

                        ProcessDate = item.ProcessDate,
                        UserID = item.UserID





                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region Account

            foreach (var item in localdb.Accounts)
            {
                try
                {
                    var q = remotedb.Accounts.Where(p => p.ID == item.ID).Single();
                    q.AccountName = item.AccountName;
                    q.Description = item.Description;
                    q.ID = item.ID;
                    q.CategoryID = item.CategoryID;
                    localdb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.Accounts.InsertOnSubmit(new Account()
                    {
                        AccountName = item.AccountName,
                        Description = item.Description,
                        ID = item.ID,
                        CategoryID = item.CategoryID,
                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion

            #region AccountDaily

            foreach (var item in localdb.AccountDailies)
            {
                try
                {
                    var q = remotedb.AccountDailies.Where(p => p.ID == item.ID).Single();
                    q.AccountID = item.AccountID;
                    q.DateOfProcess = item.DateOfProcess;
                    q.ID = item.ID;
                    q.TotalIn = item.TotalIn;
                    q.TotalOut = item.TotalOut;
                    q.Description = item.Description;
                    q.CommandArg = item.CommandArg;
                    remotedb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    remotedb.AccountDailies.InsertOnSubmit(new AccountDaily()
                    {
                        AccountID = item.AccountID,
                        DateOfProcess = item.DateOfProcess,
                        ID = item.ID,
                        TotalIn = item.TotalIn,
                        TotalOut = item.TotalOut,
                        Description = item.Description,
                        CommandArg = item.CommandArg,
                    });
                    remotedb.SubmitChanges();
                }
            }
            #endregion
        }
    }
}
