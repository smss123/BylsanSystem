using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using XamaDataLayer.Helper_Classes;
using XamaDataLayer;
using System.Threading;
using Xprema.XExtention;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using Bylsan_System.ManagmentOrderForms;

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
        private ImageList ProductImageList = new ImageList();
        public int CustomerID { get; set; }
        private FrmTotalOrder frm = new FrmTotalOrder();

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



        private void PopulateCategoreisTree()
        {
            PhotoBox.Image = null;
            ProductDescriotionLab.Text = string.Empty;
            ProductNameLab.Text = string.Empty;

            TreeCategories.Nodes.Clear();
            TreeCategories.ImageList = imageList1;
            TreeCategories.Nodes.Add("Xprema", "All Categories", 0);

            foreach (var item in ProductCategories)
            {
                TreeCategories.Nodes[0].Nodes.Add(item.ID.ToString(), item.ProductCategoryName, 1);
            }
        }

        private Thread th;
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
            Products = Operation.Allproducts;
            ProductCategories = Operation.Allcategorys;

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



        private void ExpanedAll_Click(object sender, EventArgs e)
        {
            TreeCategories.ExpandAll();
        }

        private void CollapesBtn_Click(object sender, EventArgs e)
        {
            TreeCategories.CollapseAll();
        }





        private void CreateOrdersListView()
        {
            var allProducts = Products.Where(p => p.CateogryID == CategID).ToList();
            dataGridView1.DataSource = allProducts;
        }


        private void PopulateListProducts()
        {
            var allProducts = Products.Where(p => p.CateogryID == CategID).ToList();
            dataGridView1.DataSource = allProducts;
        }


        private int CategID = 0;
        private void TreeCategories_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (TreeCategories.Nodes.Count != 0)
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


        public int PrdID { get; set; }
        public List<OrderProduct> selectedProductX { get; set; }
        private int QtyCounter = 1;
        private void ListViewProductes_MouseClick(object sender, MouseEventArgs e)
        {
        }


        private void nextBtn_Click_1(object sender, EventArgs e)
        {
            XamaDataLayer.Security.UserCmd.SaveHistory("Add", "Order Product ", "Add New Order Product  ");
            frm.TragetOrderType = OrderTypeCheckLab.Text;
            frm.ShowDialog();
            
        }


        private void titleToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }



        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ckBracode.Checked)
                {
                    try
                    {
                        var q = Products.Where(p => p.ID == textBox1.Text.ToInt()).ToList();
                        dataGridView1.DataSource = q;

                        dataGridView1_CellClick(null, null);
                        textBox1.Text = string.Empty;
                    }
                    catch (Exception)
                    {
                        RadMessageBox.Show("Item Not Found");
                        textBox1.Text = "";
                    }
                   
                }
                else
                {
                    try
                    {
                        if (!ckBracode.Checked)
                        {
                            var q = Products.Where(p => p.Product_Name == textBox1.Text).ToList();
                            dataGridView1.DataSource = q;
                        }
                    }
                    catch (Exception)
                    {
                        RadMessageBox.Show("Item Not Found");
                        textBox1.Text = "";
                    }
                    
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CustomerInformations.OrdrType == "Special")
            {
                //var SFrm = new FrmSpecialOrder();
                //SFrm.TragetOrderproduct = (Product )dataGridView1.CurrentRow.DataBoundItem;
                //SFrm.ShowDialog();
                //radGridView1.DataSource = CustomerInformations.WaitingOrder.OrderProducts.ToList();
                frmSpAttachment_ frm = new frmSpAttachment_();
                frm.TragetProduct = (Product)dataGridView1.CurrentRow.DataBoundItem;
                frm.ShowDialog();

                CustomerInformations.WaitingOrder.OrderProducts.Add(frm.RetrunProduct);
                radGridView1.DataSource = CustomerInformations.WaitingOrder.OrderProducts.ToList();
                return;
            }


            PrdID = 0;
            PrdID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());



            var myProdctut = Operation.Allproducts.Where(p => p.ID == PrdID).ToList();
            Application.DoEvents();
            foreach (var item in myProdctut)
            {
                ProductNameLab.Text = string.Format("Product Name : {0}", item.Product_Name.ToString());
                ProductDescriotionLab.Text = string.Format("Description  : {0} ", item.Product_Description.ToString());
                Publicnamelab.Text = string.Format("Price : {0}", item.ProductPrice.ToString());
                PhotoBox.Image = item.Img;





                //var q = CustomerInformations.WaitingOrder.OrderProducts.Where(p => p.ProductID == item.ID).SingleOrDefault();
                //if (q == null)
                //{
                    CustomerInformations.WaitingOrder.OrderProducts.Add(new OrderProduct()
                    {
                        Product = myProdctut[0],
                        Qty = QtyCounter,
                        Status = "Orderd",
                        ImageX = item.Img
                    });
                    QtyCounter = 1;
                //}
                //else
                //{
                    //q.Qty = q.Qty + 1;
                //}

                radGridView1.DataSource = CustomerInformations.WaitingOrder.OrderProducts.ToList();
            }
        }

        private void radGridView1_DoubleClick(object sender, EventArgs e)
        {
            var q = (OrderProduct)radGridView1.CurrentRow.DataBoundItem;
            frmSpAttachment_ frm = new frmSpAttachment_();
            frm.RetrunProduct = q;
            frm.ShowDialog();
           
           
        }
    }
}
