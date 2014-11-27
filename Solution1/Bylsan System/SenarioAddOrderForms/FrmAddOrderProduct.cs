using System;
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

namespace Bylsan_System.SenarioAddOrderForms
{
    public partial class FrmAddOrderProduct : Form
    {
        public FrmAddOrderProduct()
        {
            InitializeComponent();
            ProductImageList.ImageSize =new Size(70,70);
        }
        ImageList ProductImageList = new ImageList();
        public int CustomerID { get; set; }
        FrmTotalOrder frm = new FrmTotalOrder();
        #region " Loading Customer Informations  "
        private void ImportCustomerData()
        {

            try
            {

                if ((int)CustomerInformations.WatingCustomer.ID != 0)
                {
                    CustomerID = CustomerInformations.WatingCustomer.ID;
                    CustomerNameLab.Text = string.Format("Customer Name is : {0} ", CustomerInformations.WatingCustomer.CustomerName);
                    CustomerPhoneLab.Text = string.Format("Customer Phone  is : {0} ", CustomerInformations.WatingCustomer.PhoneNumber);

                    frm.NameLab.Text = CustomerInformations.WatingCustomer.CustomerName;
                    frm.PhoneLab.Text = CustomerInformations.WatingCustomer.PhoneNumber;
                }
            }
            catch (Exception)
            {

                CustomerNameLab.Text = string.Format("Customer Name is : {0} ", CustomerInformations.CustmrName);
                CustomerPhoneLab.Text = string.Format("Customer Phone  is : {0} ", CustomerInformations.CustmrPhone);
                frm.NameLab.Text = CustomerInformations.CustmrName;
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
            var ListOfCategores = CategoriesCmd.GetAllCategories();
            foreach (var item in ListOfCategores)
            {
                this.TreeCategories.Nodes[0].Nodes.Add("", item.ProductCategoryName, 1);
            }

        }
        #endregion

        private void FrmAddOrderProduct_Load(object sender, EventArgs e)
        {
            ImportCustomerData();
            PopulateCategoreisTree();
            CreateListViewProducts();
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

        void CreateListViewProducts()
        {

            ListViewProductes.View = View.Tile;
            ListViewProductes.Columns.Add("ID", 30, HorizontalAlignment.Center);
            ListViewProductes.Columns.Add("Product", 230, HorizontalAlignment.Center);
            ListViewProductes.Columns.Add("Descriptoin", 300, HorizontalAlignment.Center);

            //==============================================================================

            OrdersListView.View = View.Details;
            OrdersListView.Columns.Add("ID", 30, HorizontalAlignment.Center);
            OrdersListView.Columns.Add("Product", 170, HorizontalAlignment.Center);
            OrdersListView.Columns.Add("Description", 170, HorizontalAlignment.Center);
            OrdersListView.Columns.Add("Quantity", 100, HorizontalAlignment.Center);
            OrdersListView.Columns.Add("Price", 70, HorizontalAlignment.Center);
        }


        void PopulateListProducts()
        {
            ListViewProductes.Items.Clear();
            int ImgIndx = 0;


            if (CategID != 0)
            {
                var AllProducts = ProductsCmd.GetProductByCategID(CategID);
                foreach (var item in AllProducts)
                {
                    ListViewProductes.LargeImageList = ProductImageList;
                    ListViewItem Itm = new ListViewItem(item.ID.ToString(), ImgIndx);
                    Itm.SubItems[0].ForeColor = Color.Green;
                    Itm.SubItems.Add(item.Product_Name.ToString());
                    Itm.SubItems.Add(item.Product_Description.ToString());

                    ProductImageList.Images.Add(item.Img);
                    ListViewProductes.Items.Add(Itm);
                    ImgIndx++;
                }
            }
        }


        private int CategID = 0;
        private void TreeCategories_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (this.TreeCategories.Nodes.Count != 0)
                {
                    CategID = (from c in CategoriesCmd.GetAllCategories()
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
        private void ListViewProductes_MouseClick(object sender, MouseEventArgs e)
        {
            Operation.BeginOperation(this);
            try
            {
                if (ListViewProductes.Items.Count != 0)
                {
                    PrdID = 0;
                    PrdID = ListViewProductes.SelectedItems[0].Index;

                    var MyProdctut = ProductsCmd.GetProductByID(int.Parse(ListViewProductes.Items[PrdID].SubItems[0].Text));

                    foreach (var item in MyProdctut)
                    {
                        ProductNameLab.Text = string.Format("Product Name : {0}", item.Product_Name.ToString());
                        ProductDescriotionLab.Text = string.Format("Description  : {0} ", item.Product_Description.ToString());
                        Publicnamelab.Text = string.Format("Public Name  : {0} ", item.PublicName.ToString());
                        if (item.Img != null)
                        {
                            PhotoBox.Image = item.Img;
                            this.Cursor = Cursors.Default;
                        }
                        //=======================================
             

                        ListViewItem Itm = new ListViewItem(item.ID.ToString());
                        Itm.SubItems[0].ForeColor = Color.Green;
                        Itm.SubItems.Add(item.Product_Name.ToString());
                       
                        Itm.SubItems.Add(item.Product_Description.ToString());

                        ProductImageList.Images.Add(item.Img);
                      //  frm.OrdersListView.Items.Add(Itm);
                        //========================================
                        // start Work With Orders :

                        int QtyCount = 1;
                        ListViewItem SelectedProduct = new ListViewItem(item.ID.ToString());

                        SelectedProduct.SubItems.Add(item.Product_Name.ToString());
                        SelectedProduct.SubItems.Add(item.Product_Description .ToString());
                        SelectedProduct.SubItems.Add(QtyCount.ToString());
                        SelectedProduct.SubItems.Add(item.ProductPrice .ToString());
                        OrdersListView.Items.Add(SelectedProduct);

                        for (int i = 0; i < OrdersListView.Items.Count; i++)
                        {
                            if (OrdersListView.Items[i].SubItems[0].Text == SelectedProduct.SubItems[0].Text)
                            {
                                int x = OrdersListView.Items[i].Index;

                                QtyCount++;
                                OrdersListView.Items.RemoveAt(x);
                                OrdersListView.Items.Add(SelectedProduct);

                            }
                            // ===== Compute Total Cost Price
                            double TotalCostPrice = (from ListViewItem li in OrdersListView.Items
                                                     select
                                                         Convert.ToDouble(li.SubItems[4].Text.ToString())).Sum();
                            //==  Display Total Cost Price Of Orders
                            TotalCostBox.Text = TotalCostPrice.ToString();
                            // == Display  Orders Count
                            OrdersCountBox.Text = OrdersListView.Items.Count.ToString();
                        }
                    }
                }
                    
               
            }
            catch (Exception)
            {


            }
            Operation.EndOperation(this);
        }

       
        private void nextBtn_Click_1(object sender, EventArgs e)
        {
           
	

                ListViewItem itemClone;
                ListView.ListViewItemCollection coll = OrdersListView.Items;
                foreach (ListViewItem item in coll)
                {
                itemClone = item.Clone() as ListViewItem;
                OrdersListView.Items.Remove(item);
                frm .OrdersListView.Items.Add(itemClone);
                }

            frm.Show();
            this.Hide();
        }

        private void titleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewProductes.View = View.Tile;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewProductes.View = View.List ;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewProductes.View = View.Details ;
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewProductes.View = View.LargeIcon ;
        }

        private void TreeCategories_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
