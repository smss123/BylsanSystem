using Bylsan_System.Reports.ReportCommand;
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
            textBox1.AutoCompleteCustomSource.Clear();
            foreach (var item in Operation.Allproducts)
            {
                textBox1.AutoCompleteCustomSource.Add(item.Product_Name);
            }
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
                dataGridView1.DataSource = null;
                dataGridView1.DataSource= Operation.Allproducts.Where(p => p.CateogryID == SelectedCategryID);
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            var obj = new Quotation()
            {
                 ID=ApiCounter.GetNumber(),
                AddressFor = addressForTextBox.Text,
                CreatedDate = DateTime.Now,
                PhoneNumber = phoneNumberTextBox.Text,
                QuotationFor = quotationForTextBox.Text,
                Description = txtDescription.Text
          
            };
            foreach (DataGridViewRow item in dataGridView2.Rows)
            {
                //item.Cells[4].Value = item.Cells[2].Value.ToString().Todouble() * item.Cells[3].Value.ToString().Todouble();
                QuotationProduct p = new QuotationProduct()
                {
                     id= ApiCounter.GetNumber(),
                    Description = item.Cells[5].Value == null ? "-" : item.Cells[5].Value.ToString(),
                    ProductID = item.Cells[0].Value.ToString().ToInt(),
                    Qty = item.Cells[2].Value.ToString()
                };
                obj.QuotationProducts.Add(p);

            }
            QuotationCmd.AddQuotation(obj);
            QuotationReportCmd cmd = new QuotationReportCmd();
            cmd.GetOrderProductsByOrderId(obj.ID);
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
                    //dataGridView1.DataSource = q;
                    dataGridView1.Rows.Clear();
                    foreach (var item in q)
                    {
                        dataGridView1.Rows.Add(new string[] {item.ID.ToString(),item.Product_Name,item.ProductPrice.ToString() });
                    }

                    dataGridView1_CellContentClick(null, null);
                    textBox1.Text = string.Empty;
                }
                else
                {
                    if (!ckBracode.Checked)
                    {
                        var q = Operation.Allproducts.Where(p => p.Product_Name == textBox1.Text).ToList();
                        dataGridView1.Rows.Clear();
                        foreach (var item in q)
                        {
                            dataGridView1.Rows.Add(new string[] { item.ID.ToString(), item.Product_Name, item.ProductPrice.ToString() });
                        }
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





                //var q = CustomerInformations.WaitingOrder.OrderProducts.Where(p => p.ProductID == item.ID).SingleOrDefault();
                //if (q == null)
                //{
                //    CustomerInformations.WaitingOrder.OrderProducts.Add(new OrderProduct()
                //    {
                //        Product = myProdctut[0],
                //        Qty = QtyCounter,
                //        Status = "Orderd",
                //        ImageX = item.Img
                //    });
                //    QtyCounter = 1;
                //}
                //else
                //{
                //    q.Qty = q.Qty + 1;
                //}
                dataGridView2.Rows.Add(new string[] { item.ID.ToString(),item.Product_Name,"1",item.ProductPrice.ToString(),item.ProductPrice.ToString()});
            }
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView2.Rows)
            {
                item.Cells[4].Value = item.Cells[2].Value.ToString().Todouble() * item.Cells[3].Value.ToString().Todouble();
            }
        }

        private void TreeCategories_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (TreeCategories.Nodes.Count != 0)
                {
                    SelectedCategryID = Operation.Allcategorys.Where(p => p.ProductCategoryName == TreeCategories.SelectedNode.Text).Single().ID;
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Operation.Allproducts.Where(p => p.CateogryID == SelectedCategryID);
                }

            }
            catch (Exception)
            {

                return;
            }
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox1.AutoCompleteCustomSource.Clear();
                foreach (var item in Operation.Allproducts)
                {
                    textBox1.AutoCompleteCustomSource.Add(item.PublicName);
                }
            }
        }

        private void ckBracode_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox1.AutoCompleteCustomSource.Clear();
                foreach (var item in Operation.Allproducts)
                {
                    textBox1.AutoCompleteCustomSource.Add(item.PublicName);
                }
                textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }

        private void ckBracode_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox1.AutoCompleteCustomSource.Clear();
                foreach (var item in Operation.Allproducts)
                {
                    textBox1.AutoCompleteCustomSource.Add(item.PublicName);
                }
                textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }
    }
}
