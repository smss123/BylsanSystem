using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
using XamaDataLayer.Helper_Classes;
using Xprema.XExtention;

namespace Bylsan_System.SenarioAddOrderForms
{
    public partial class FrmPrintQuotation : RadForm
    {
        public FrmPrintQuotation()
        {
            InitializeComponent();
        }
        #region "   Populate Categories Tree   "
        private void PopulateCategoreisTree()
        {


            this.TreeCategories.Nodes.Clear();
            this.TreeCategories.ImageList = imageList1;
            this.TreeCategories.Nodes.Add("Xprema", "All Categories", 0);
            var ListOfCategores = CategoriesCmd.GetAllCategories();

            int i = 0;

            foreach (var item in ListOfCategores)
            {
                this.TreeCategories.Nodes[0].Nodes.Add("", item.ProductCategoryName, 1);
                int Indx = item.ID;
                var ListOfProducts = ProductsCmd.GetProductByCategID(item.ID);
                // --{Abu Ehab ^^  I Don't Need It Know ....} 
                //foreach (var Prd in ListOfProducts )
                //{
                //   this.TreeCategories.Nodes[0].Nodes  .Add("", Prd .Product_Name , 2);
                //    i++;
                //}
            }

        }
        #endregion
        #region "    Create ListView For Products     "
        void CreateListViewProducts()
        {




            //ListViewProducts.View = View.Details;
            //ListViewProducts.Columns.Add("ID", 30, HorizontalAlignment.Center);
            //ListViewProducts.Columns.Add("Product", 170, HorizontalAlignment.Center);
            //ListViewProducts.Columns.Add("Description", 170, HorizontalAlignment.Center);
            //ListViewProducts.Columns.Add("Public Name", 100, HorizontalAlignment.Center);
            //ListViewProducts.Columns.Add("Price", 70, HorizontalAlignment.Center);

        }

        #endregion

        private void FrmPrintQuotation_Load(object sender, EventArgs e)
        {
            PopulateCategoreisTree();
            CreateListViewProducts();
            CustomerInformations.Orderini();
        }

        private void TreeCategories_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }


        private int SelectedCategryID { get; set; }
        private void TreeCategories_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (TreeCategories.Nodes.Count != 0)
            {
                //SelectedCategryID =(from c in CategoriesCmd.GetAllCategories()
                //                        where c.ProductCategoryName == TreeCategories.SelectedNode.Text
                //                        select c.ID).Single();
                SelectedCategryID = Operation.Allcategorys.Where(p => p.ProductCategoryName == TreeCategories.SelectedNode.Text).Single().ID;

                var lst = Operation.Allproducts.Where(p => p.CateogryID == SelectedCategryID); //ProductsCmd.GetProductByCategID(SelectedCategryID);
                //ListViewProducts.Items.Clear();
                //foreach (var p in lst)
                //{
                //    ListViewItem itm = new ListViewItem(p.ID.ToString());
                //    itm.SubItems.Add(p.Product_Name);
                //    itm.SubItems.Add(p.Product_Description);
                //    itm.SubItems.Add(p.PublicName);
                //    itm.SubItems.Add(p.ProductPrice.ToString());
                //    ListViewProducts.Items.Add(itm);
                //}


            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {

            //if (ListViewProducts.Items.Count != 0)
            //{
            //    //== Starting Save At Quotation :
            //    Quotation tb = new Quotation()
            //    {
            //        QuotationFor = quotationForTextBox .Text ,CreatedDate = DateTime .Now ,PhoneNumber = phoneNumberTextBox .Text ,AddressFor = addressForTextBox .Text ,
            //    };
            //    QuotationCmd.AddQuotation(tb);

            //    //==================================

            //    // Starting Save At QuotationProduct
            //    int xMax = tb.ID;//(from mx in QuotationCmd.GetAllQuotations() select mx.ID).Max();
            //    foreach (ListViewItem  item in ListViewProducts.Items  )
            //    {
            //        QuotationProduct qptb = new QuotationProduct()
            //        {
            //            ProductID =  int .Parse (item .SubItems [0].Text)  ,  QuotationID = xMax , Description = item .SubItems [2].Text.ToString (),
            //        };
            //        QuotationProductCmd.AddQuotationProduct(qptb);
            //        tb.QuotationProducts.Add(qptb);
            //    }

            //    QuotationReportCmd cmd = new QuotationReportCmd();

            //    MessageBox.Show("Saved");
            //    cmd.GetOrderProductsByOrderId(tb.ID);
            //    ListViewProducts.Items.Clear();
            //    TreeCategories.CollapseAll();
            //    quotationForTextBox.Focus();

        }
        private int PrdID;
        private int QtyCounter = 1;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ckBracode.Checked)
                {
                    var q = Operation .Allproducts.Where(p => p.ID == textBox1.Text.ToInt()).ToList();
                    dataGridView1.DataSource = q;
                 

                    dataGridView1_CellContentClick(null, null);
                    textBox1.Text = "";
                }
                else if (!ckBracode.Checked)
                {
                    var q = Operation.Allproducts.Where(p => p.Product_Name == textBox1.Text).ToList();
                    dataGridView1.DataSource = q;
                }


            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          

            PrdID = 0;
            PrdID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());



            var myProdctut = Operation.Allproducts.Where(p => p.ID == PrdID).ToList(); //ProductsCmd.GetProductByID(PrdID);
            Application.DoEvents();
            foreach (var item in myProdctut)
            {
                ProductNameLab.Text = string.Format("Product Name : {0}", item.Product_Name.ToString());
                ProductDescriotionLab.Text = string.Format("Description  : {0} ", item.Product_Description.ToString());
                Publicnamelab.Text = string.Format("Price : {0}", item.ProductPrice.ToString());
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
                dataGridView2.DataSource = q;
            }
        }
    }
}
