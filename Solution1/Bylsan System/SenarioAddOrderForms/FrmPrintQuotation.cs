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
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
using XamaDataLayer.Helper_Classes;
namespace Bylsan_System.SenarioAddOrderForms
{
    public partial class FrmPrintQuotation : Form
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




            ListViewProducts.View = View.Details;
            ListViewProducts.Columns.Add("ID", 30, HorizontalAlignment.Center);
            ListViewProducts.Columns.Add("Product", 170, HorizontalAlignment.Center);
            ListViewProducts.Columns.Add("Description", 170, HorizontalAlignment.Center);
            ListViewProducts.Columns.Add("Public Name", 100, HorizontalAlignment.Center);
            ListViewProducts.Columns.Add("Price", 70, HorizontalAlignment.Center);

        }

        #endregion 

        private void FrmPrintQuotation_Load(object sender, EventArgs e)
        {
            PopulateCategoreisTree();
            CreateListViewProducts();
        }

        private void TreeCategories_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
    
        }


        private int SelectedCategryID { get; set; }
        private void TreeCategories_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (TreeCategories.Nodes.Count != 0)
            {
                 SelectedCategryID = (from c in CategoriesCmd.GetAllCategories()
                                         where c.ProductCategoryName == TreeCategories.SelectedNode.Text
                                         select c.ID).Single();
                var Lst = ProductsCmd.GetProductByCategID(SelectedCategryID);
                ListViewProducts.Items.Clear();
                foreach (var p in Lst)
                {
                    ListViewItem itm = new ListViewItem(p.ID.ToString());
                    itm.SubItems.Add(p.Product_Name);
                    itm.SubItems.Add(p.Product_Description);
                    itm.SubItems.Add(p.PublicName);
                    itm.SubItems.Add(p.ProductPrice.ToString());
                    ListViewProducts.Items.Add(itm);
                }


            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListViewProducts.Items.Count != 0)
                {
                    //== Starting Save At Quotation :
                    Quotation tb = new Quotation()
                    {
                        QuotationFor = quotationForTextBox .Text ,CreatedDate = DateTime .Now ,PhoneNumber = phoneNumberTextBox .Text ,AddressFor = addressForTextBox .Text ,
                    };
                    QuotationCmd.AddQuotation(tb);
                    //==================================

                    // Starting Save At QuotationProduct
                    int xMax = (from mx in QuotationCmd.GetAllQuotations() select mx.ID).Max();
                    foreach (ListViewItem  item in ListViewProducts.Items  )
                    {
                        QuotationProduct qptb = new QuotationProduct()
                        {
                            ProductID =  int .Parse (item .SubItems [0].Text)  ,  QuotationID = xMax , Description = item .SubItems [2].Text.ToString (),
                        };
                        QuotationProductCmd.AddQuotationProduct(qptb);
                    }
                }
            }
            catch (Exception)
            {
                
                
            }
        }




    }
}
