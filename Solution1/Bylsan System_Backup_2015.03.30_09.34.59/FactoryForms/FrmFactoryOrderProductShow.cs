using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Xprema.XExtention;
using System.Threading;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
using XamaDataLayer.Main_Store;
using Telerik.WinControls;

namespace Bylsan_System.FactoryForms
{
    public partial class FrmFactoryOrderProductShow : Telerik.WinControls.UI.RadForm
    {
        public FrmFactoryOrderProductShow()
        {
            InitializeComponent();
        }
        public int TaregtOrder { get; set; }
        public Order TagOrder { get; set; }
        public int PrdID { get; set; }
        private Thread Thr;
        private void PopulateGrd()
        {
            Operation.BeginOperation(this);

            try
            {
                var q = Operation.AllOrderProduct.Where(p => p.OrderID == TagOrder.ID).ToList();  //Operation.AllOrder.Where(p => p.ID == TagOrder.ID).Single().OrderProducts; //TagOrder.OrderProducts.ToList();
                this.Invoke((MethodInvoker)delegate
                {
                    foreach (var item in q)
                    {
                        DGVProducts.Rows.Add(new string[] { item .ID .ToString (), item .ProductID .ToString (), item.Product.Product_Name,
                     item .Qty .ToString ()
                     });
                    }
                });

            }
            catch (Exception ex) 
            {
                RadMessageBox.ThemeName = this.ThemeName;
                RadMessageBox.Show("No Any Product on this Order");
                
            }
            Operation.EndOperation(this);
            Thr.Abort();
        }



        private void FrmFactoryOrderProductShow_Load(object sender, EventArgs e)
        {
            DGVContents.ColumnCount = 4;
            DGVContents.Columns[0].HeaderText = "ID";
            DGVContents.Columns[0].Width = 50;
            DGVContents.Columns[1].HeaderText = "Item";
            DGVContents.Columns[1].Width = 120;
            DGVContents.Columns[2].HeaderText = "QTY";
            DGVContents.Columns[2].Width = 50;
            DGVContents.Columns[3].HeaderText = "Unit";
            DGVContents.DataSource = null;


            ChkToDeliver.Visible = false;
            PhotoBox.Image = null;

            Thr = new Thread(PopulateGrd);
            Thr.Start();
            lblOrderDate.Text = TagOrder.OrderDate.Value.ToString("dd/MM/yyyy");
            lblOrderDelviryDate.Text = TagOrder.OrderDeliveryDate.Value.ToString("dd/MM/yyyy");
        }


        private Thread productThread;
        private void DGVProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void LoadProdcutInformations()
        {
            PrdID = 0;
            int productID = int.Parse(DGVProducts.CurrentRow.Cells[0].Value.ToString());
            var px = Operation.AllOrderProduct.Where(p => p.ID == productID).Single(); //(OrderProduct)(DGVProducts.CurrentRow.DataBoundItem);

            var lst1 = px; //OrderProductsCmd.GetAllByProductID(PrdID);

            //var CurrentProduct = Operation.Allproducts.Where(p => p.ID == PrdID).ToList();
            this.Invoke((MethodInvoker)delegate
            {
                TxtDescription.Text = lst1.Description;
                PhotoBox.Image = lst1.ImageX;



                lblPoductName.Text = lst1.Product.Product_Name;
                lblPrice.Text = "[none]";


                productThread.Abort();
            });
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoadCleaner()
        {
            PhotoBox.Image = null;
            TxtDescription.Text = string.Empty;
            lblPrice.Text = string.Empty;
            lblPoductName.Text = string.Empty;
        }

        private void ChkToDeliver_CheckedChanged(object sender, EventArgs e)
        {
            if ( TaregtOrder != 0)
            {
                var orderTb = new Order()
                { OrderStatus = "To Deliver", };

                OrdersCmd.EditOrderStatusOnly(orderTb, TaregtOrder);
                MessageBox.Show("The current product is ready to be sent to the customer");
            }
        }

        private void PhotoBox_Click(object sender, EventArgs e)
        {
            var op = new SaveFileDialog();
            op.ShowDialog();
            PhotoBox.Image.Save(op.FileName);
        }

        private void SaveChangesBtn_Click(object sender, EventArgs e)
        {
            var orderTb = new Order();


            for (var i = 0; i < DGVProducts.Rows.Count; i++)
            {
                CreateContents(i);
                var chkchecking = DGVProducts.Rows[i].Cells[4] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(chkchecking.Value) == true)
                {
                    var Indx = DGVProducts.CurrentRow.Index;
                    DGVProducts.Rows.RemoveAt(Indx);
                }


                orderTb = new Order()
                {
                    OrderStatus = "To Deliver",
                };

                OrdersCmd.EditOrderStatusOnly(orderTb, TaregtOrder);

               
                

            }
          
        }


        private void CreateContents(int row)
        {
            DGVContents.DataSource = null;
            var xproid = int.Parse(DGVProducts.Rows[row].Cells[1].Value.ToString());
            var lst  = ProductContentsCmd.GetAllProductConentsByProductID(xproid);
            DGVContents.Rows.Clear();
            foreach (var item in lst)
            {
                try
                {
                    DGVContents.Rows.Add(new string[] { item .ID .ToString (),
                    item .ContentsProductID .ToString (),
                    item .Qty .ToString (),
                    item .unitOfProduct .ToString ()
                    });


                    float AvailQty = 0;
                    var TargetStore = StoreCmd.GetAvailableQtyByItemID(item.ContentsProductID.Value);
                    AvailQty = TargetStore.AvailableQty.Value;
                    TargetStore.ProductID = item.ID;
                    TargetStore.AvailableQty =  TargetStore.AvailableQty -(long)(item.Qty.ToString()).ToFloat();
                    TargetStore.Description = "Drawal";
                    StoreCmd.EditStore(TargetStore);
                    StoreManagerCmd.AddStoreManager(new StoreManager() { DateOfProcess = DateTime.Now, Description="Rol from Factory to Order issue", Price=0, ProcessType="Roll Out", QtyInOrOut=(long)(item.Qty.ToString()).ToFloat(), StoreID = TargetStore.ID });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void DGVProducts_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            if (DGVProducts.Rows.Count != 0)
            {
                LoadCleaner();

                productThread = new Thread(LoadProdcutInformations);
                productThread.Start();

            //    CreateContents();
            }
        }

        private void DGVProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
