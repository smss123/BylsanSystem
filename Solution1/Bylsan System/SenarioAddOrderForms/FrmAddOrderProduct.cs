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

namespace Bylsan_System.SenarioAddOrderForms
{
    public partial class FrmAddOrderProduct : Form
    {
        public FrmAddOrderProduct()
        {
            InitializeComponent();
        }
        public int CustomerID { get; set; }

        #region " Loading Customer Informations  "
        private void ImportCustomerData()
        {

         try 
	     {	        
		  
            if ((int)CustomerInformations.WatingCustomer.ID != 0 ) 

            { 
                CustomerID = CustomerInformations.WatingCustomer.ID;
                CustomerNameLab.Text = string.Format ("Customer Name is : {0} " ,CustomerInformations.WatingCustomer.CustomerName);
                CustomerPhoneLab.Text = string.Format ("Customer Phone  is : {0} " , CustomerInformations.WatingCustomer.PhoneNumber);
            }
	      }
	      catch (Exception)
	       {

                CustomerNameLab.Text = string.Format ("Customer Name is : {0} " ,CustomerInformations.CustmrName);
                CustomerPhoneLab.Text = string .Format ("Customer Phone  is : {0} " , CustomerInformations.CustmrPhone);
	          }
          
        }
        #endregion

        #region "   Populate Categories Tree   "
        private void PopulateCategoreisTree() {
            this.TreeCategories.Nodes.Clear();
            this.TreeCategories.ImageList = imageList1;
            this.TreeCategories.Nodes.Add("Xprema", "All Categories",0);
            var ListOfCategores = CategoriesCmd.GetAllCategories();
            foreach (var item in ListOfCategores )
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

            ListViewProductes.View = View.Details;
            ListViewProductes.Columns.Add( "ID",30, HorizontalAlignment.Center);
            ListViewProductes.Columns.Add("Product", 230, HorizontalAlignment.Center);
            ListViewProductes.Columns.Add("Descriptoin", 300, HorizontalAlignment.Center);
          
        }


        void PopulateListProducts()
        {
            if (CategID != 0)
            {
                ListViewProductes.Items.Clear();
                var AllProducts = ProductsCmd.GetProductByCategID(CategID);
                foreach (var item in AllProducts )
                {
                    ListViewItem Itm = new ListViewItem(item .ID .ToString ());
                    Itm.SubItems.Add( item .Product_Name .ToString ());
                    Itm.SubItems.Add(item .Product_Description .ToString ());

                    ListViewProductes.Items.Add(Itm);
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
                                   where c.ProductCategoryName.Contains (  e.Node.Text)
                                   select c.ID).Single();
                        PopulateListProducts();
                    }
            }
            catch (Exception)
            {
                
             
            }
        }
        #endregion

        int PrdID = 0;
        private void ListViewProductes_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (ListViewProductes.Items.Count != 0)
                {
                    PrdID = 0;
                    PrdID = ListViewProductes.SelectedItems[0].Index;
                  
                    var MyProdctut = ProductsCmd.GetProductByID(int.Parse(ListViewProductes.Items[PrdID].SubItems[0].Text));
                    foreach (var item in MyProdctut )
                    {
                        ProductNameLab.Text = string.Format("Product Name : {0}", item.Product_Name.ToString());
                        ProductDescriotionLab.Text = string.Format("Description  : {0} ", item.Product_Description.ToString());


                        if (item .Img != null)
                        {

                            byte[] buffer = null;

                            //buffer = (byte[])item.Img ;
                            //MemoryStream MS = new MemoryStream(buffer);
                            //PhotoBox.Image = Image.FromStream(MS);
                          
                            this.Cursor = Cursors.Default;
                        }

                  
                        

                    }
                }
            }
            catch (Exception)
            {
                
                
            }
        }


    }
}
