﻿using System;
using System.Linq;
using System.Windows.Forms;
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

        private void PopulateCategoreisTree()
        {
            TreeCategories.Nodes.Clear();
            TreeCategories.ImageList = imageList1;
            TreeCategories.Nodes.Add("Xprema", "All Categories", 0);
            var ListOfCategores = CategoriesCmd.GetAllCategories();

            foreach (var item in ListOfCategores)
            {
                TreeCategories.Nodes[0].Nodes.Add(string.Empty, item.ProductCategoryName, 1);
                ProductsCmd.GetProductByCategID(item.ID);
            }
        }


        private void CreateListViewProducts()
        {
        }



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
                SelectedCategryID = Operation.Allcategorys.Where(p => p.ProductCategoryName == TreeCategories.SelectedNode.Text).Single().ID;

                Operation.Allproducts.Where(p => p.CateogryID == SelectedCategryID);
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
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
                    textBox1.Text = string.Empty;
                }
                else
                {
                    if (!ckBracode.Checked)
                    {
                        var q = Operation.Allproducts.Where(p => p.Product_Name == textBox1.Text).ToList();
                        dataGridView1.DataSource = q;
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
