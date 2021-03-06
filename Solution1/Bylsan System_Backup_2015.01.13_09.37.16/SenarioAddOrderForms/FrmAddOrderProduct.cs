﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using XamaDataLayer.BranchCmd;
using XamaDataLayer.Helper_Classes;
using XamaDataLayer;
using System.Data.Linq;
using System.Threading;
using Xprema.XExtention;
using Telerik.WinControls.UI;
using XamaDataLayer.Security;

namespace Bylsan_System.SenarioAddOrderForms
{
    public partial class FrmAddOrderProduct : RadForm
    {
        public List<Product> Products { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        public FrmAddOrderProduct()
        {
            InitializeComponent();
            ProductImageList.ImageSize = new Size(70, 70);
        }
        ImageList ProductImageList = new ImageList();
        public int CustomerID { get; set; }
        FrmTotalOrder frm = new FrmTotalOrder();
        #region " Loading Customer Informations  "
        private void ImportCustomerData()
        {

            try
            {


                CustomerID = CustomerInformations.WatingCustomer.ID;
                CustomerNameLab.Text = string.Format("Customer Name is : {0} ", CustomerInformations.WatingCustomer.CustomerName);
                CustomerPhoneLab.Text = string.Format("Customer Phone  is : {0} ", CustomerInformations.WatingCustomer.PhoneNumber);

                frm.NameLab.Text = CustomerInformations.WatingCustomer.CustomerName;
                frm.PhoneLab.Text = CustomerInformations.WatingCustomer.PhoneNumber;

            }
            catch (Exception)
            {

                CustomerNameLab.Text = string.Format("Customer Name is : {0} ", CustomerInformations.CustmrName);
                CustomerPhoneLab.Text = string.Format("Customer Phone  is : {0} ", CustomerInformations.CustmrPhone);
                frm.NameLab.Text = CustomerInformations.WatingCustomer.CustomerName;
                frm.PhoneLab.Text = CustomerInformations.CustmrPhone;

            }

        }
        #endregion

        #region "   Populate Categories Tree   "
        private void PopulateCategoreisTree()
        {
            PhotoBox.Image = null;
            ProductDescriotionLab.Text = "";
            ProductNameLab.Text = "";

            this.TreeCategories.Nodes.Clear();
            this.TreeCategories.ImageList = imageList1;
            this.TreeCategories.Nodes.Add("Xprema", "All Categories", 0);

            foreach (var item in this.ProductCategories)
            {
                this.TreeCategories.Nodes[0].Nodes.Add(item.ID.ToString(), item.ProductCategoryName, 1);
            }

        }
        #endregion
        Thread th;
        private void FrmAddOrderProduct_Load(object sender, EventArgs e)
        {
            th = new Thread(LoadingProduct);
            th.Start();
            CustomerInformations.AttachIni();


        }

        private void LoadingProduct()
        {
            Operation.BeginOperation(this);
            this.Invoke((MethodInvoker)delegate
            {

                lblStatus.Text = "Loading ...";
            });
            this.Products = Operation.Allproducts;
            this.ProductCategories = Operation.Allcategorys;

            this.Invoke((MethodInvoker)delegate
            {

                lblStatus.Text = "Complete Loading  ...";
                ImportCustomerData();
                PopulateCategoreisTree();
                CreateOrdersListView();
                CustomerInformations.Orderini();
            });
            Operation.EndOperation(this);
            th.Abort();

        }


        #region "  Tree Buttons "
        private void ExpanedAll_Click(object sender, EventArgs e)
        {
            this.TreeCategories.ExpandAll();
        }

        private void CollapesBtn_Click(object sender, EventArgs e)
        {
            this.TreeCategories.CollapseAll();
        }

        #endregion

        #region "Populate ListProducts "

        void CreateOrdersListView()
        {
            var allProducts = this.Products.Where(p => p.CateogryID == CategID).ToList();
            dataGridView1.DataSource = allProducts;

            //ListViewProductes.View = View.Tile;
            //ListViewProductes.Columns.Add("ID", 30, HorizontalAlignment.Center);
            //ListViewProductes.Columns.Add("Product", 230, HorizontalAlignment.Center);
            //ListViewProductes.Columns.Add("Descriptoin", 300, HorizontalAlignment.Center);

            //==============================================================================


        }


        void PopulateListProducts()
        {
            var allProducts = this.Products.Where(p => p.CateogryID == CategID).ToList();
            dataGridView1.DataSource = allProducts;

            //ListViewProductes.Items.Clear();
            //int ImgIndx = 0;


            //if (CategID != 0)
            //{
            //    
            //    foreach (var item in AllProducts)
            //    {
            //        ListViewProductes.LargeImageList = ProductImageList;
            //        ListViewItem Itm = new ListViewItem(item.ID.ToString(),ImgIndx);
            //        Itm.SubItems[0].ForeColor = Color.Green;
            //        Itm.SubItems.Add(item.Product_Name.ToString());
            //        Itm.SubItems.Add(item.Product_Description.ToString());

            //        ProductImageList.Images.Add(item.Img);
            //        ListViewProductes.Items.Add(Itm);
            //        ImgIndx++;
            //    }
            //}
        }


        private int CategID = 0;
        private void TreeCategories_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (this.TreeCategories.Nodes.Count != 0)
                {
                    CategID = (from c in ProductCategories
                               where c.ProductCategoryName.Contains(e.Node.Text)
                               select c.ID).Single();
                    PopulateListProducts();
                }
            }
            catch (Exception)
            {


            }
        }
        #endregion

        public int PrdID { get; set; }
        public List<OrderProduct> selectedProductX { get; set; }
        private int QtyCounter = 1;
        private void ListViewProductes_MouseClick(object sender, MouseEventArgs e)
        {
            //QtyCounter++;
            //Operation.BeginOperation(this);
            ////try
            ////{
            //    if (ListViewProductes.Items.Count != 0)
            //    {

            //        if (CustomerInformations.OrdrType == "Special")
            //        {
            //            FrmSpecialOrder SFrm = new FrmSpecialOrder();
            //            SFrm.ShowDialog();
            //        }


            //            PrdID = 0;
            //            PrdID = int.Parse(ListViewProductes.SelectedItems[0].Text) ;



            //            var MyProdctut =  ProductsCmd.GetProductByID(PrdID);
            //            Application.DoEvents();
            //            foreach (var item in MyProdctut)
            //            {
            //                ProductNameLab.Text = string.Format("Product Name : {0}", item.Product_Name.ToString());
            //                ProductDescriotionLab.Text = string.Format("Description  : {0} ", item.Product_Description.ToString());

            //                PhotoBox.Image =  item.Img;

            //                ListViewItem Itm = new ListViewItem(item.ID.ToString());

            //                Itm.SubItems.Add(item.Product_Name.ToString());

            //                Itm.SubItems.Add(item.Product_Description.ToString());

            //                ProductImageList.Images.Add(item.Img);

            //                //========================================
            //                // start Work With Orders :

            //                var q = CustomerInformations.WaitingOrder.OrderProducts.Where(p => p.ProductID == item.ID).SingleOrDefault();
            //                if (q == null)
            //                {
            //                    CustomerInformations.WaitingOrder.OrderProducts.Add(new OrderProduct()
            //                    {
            //                        Product = MyProdctut[0],
            //                        Qty = QtyCounter,
            //                        Status = "Created",
            //                        ImageX =  item .Img 
            //                    });
            //                    QtyCounter=0;
            //                }
            //                else
            //                {
            //                    q.Qty = q.Qty + 1;

            //                }

            //               radGridView1.DataSource = CustomerInformations.WaitingOrder.OrderProducts.ToList();




            //                }

            //        }
            ////    }



            ////catch (Exception)
            ////{


            ////}
            //Operation.EndOperation(this);
        }


        private void nextBtn_Click_1(object sender, EventArgs e)
        {
            XamaDataLayer.Security.UserCmd.SaveHistory("Add", "Order Product ", "Add New Order Product  ");
            frm.TragetOrderType = OrderTypeCheckLab.Text;
            frm.Show();
            this.Hide();
        }

        #region "       Context     "
        private void titleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ListViewProductes.View = View.Tile;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ListViewProductes.View = View.List;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ListViewProductes.View = View.Details;
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ListViewProductes.View = View.LargeIcon;
        }

        #endregion

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ckBracode.Checked)
                {
                    var q = this.Products.Where(p => p.ID == textBox1.Text.ToInt()).ToList();
                    dataGridView1.DataSource = q;
                }
                else if(!ckBracode.Checked)
                {
                    var q = this.Products.Where(p => p.Product_Name == textBox1.Text).ToList();
                    dataGridView1.DataSource = q;
                }
              

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (CustomerInformations.OrdrType == "Special")
            {
                FrmSpecialOrder SFrm = new FrmSpecialOrder();
                SFrm.TragetOrderproduct = (Product )dataGridView1.CurrentRow.DataBoundItem;
                SFrm.ShowDialog();
            }


            PrdID = 0;
            PrdID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());



            var myProdctut = Operation.Allproducts.Where(p => p.ID == PrdID).ToList(); //ProductsCmd.GetProductByID(PrdID);
            Application.DoEvents();
            foreach (var item in myProdctut)
            {
                ProductNameLab.Text = string.Format("Product Name : {0}", item.Product_Name.ToString());
                ProductDescriotionLab.Text = string.Format("Description  : {0} ", item.Product_Description.ToString());

                PhotoBox.Image = item.Img;


                //========================================
                // start Work With Orders :

                var q = CustomerInformations.WaitingOrder.OrderProducts.Where(p => p.ProductID == item.ID).SingleOrDefault();
                if (q == null)
                {
                    CustomerInformations.WaitingOrder.OrderProducts.Add(new OrderProduct()
                    {
                        Product = myProdctut[0],
                        Qty = QtyCounter,
                        Status = "Orderd",
                        ImageX = item.Img
                    });
                    QtyCounter = 1;
                }
                else
                {
                    q.Qty = q.Qty + 1;

                }

                radGridView1.DataSource = CustomerInformations.WaitingOrder.OrderProducts.ToList();




            }

        }
    }


       
    
}
