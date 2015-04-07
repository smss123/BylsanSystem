using System;
using System.Linq;
using System.Windows.Forms;
using XamaDataLayer;
using XamaDataLayer.Security;
using Xprema.XExtention;

namespace Bylsan_System.SenarioAddOrderForms
{
    public partial class frmReturnBill : Form
    {
        public frmReturnBill()
        {
            InitializeComponent();
        }
        DbDataContext db = new DbDataContext();
        private void frmReturnBill_Load(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            billBindingSource.DataSource = db.Bills.ToList();
            productBindingSource.DataSource = Operation.Allproducts;
            Operation.EndOperation(this);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var q = db.Bills.Where(p => p.ID == txtID.Text.ToInt()).Single();
                billBindingSource.DataSource = q;
                billItemsBindingSource.DataSource = q.BillItems;
            }
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show("Bill Not Found");
               
            }
           
        }

        private void billBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            this.billItemsBindingSource.EndEdit();
            this.billBindingSource.EndEdit();
            try
            {
                foreach (DataGridViewRow item in billItemsDataGridView.Rows)
                {
                    var px = (BillItem)item.DataBoundItem;
                    if (item.Cells[4].Value.ToString().Contains("Return"))
                    {
                        var q = db.SellStores.Where(p => p.Product.ID == px.ProductID && p.branchID == UserInfo.CurrnetUser.Branch_ID).Single();
                        q.Qty = long.Parse((q.Qty.ToString().Todouble() + item.Cells[3].Value.ToString().Todouble()).ToString());

                        db.SubmitChanges();
                    }
                    
                }
            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
            }

            db.SubmitChanges();
            Operation.ShowToustOk("Saved", this);

            Operation.EndOperation(this);
        }

        double Amount = 0;
        private void billItemsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Caluclate Amount
            CalcAmount();
        }

        private void CalcAmount()
        {
            try
            {
                Amount = 0;
                foreach (DataGridViewRow item in billItemsDataGridView.Rows)
                {
                    var p = (BillItem)item.DataBoundItem;
                    try
                    {

                        Amount = Amount + p.Product.ProductPrice.Value * item.Cells[2].Value.ToString().Todouble();
                    }
                    catch (Exception)
                    {

                        Operation.ShowToustOk(p.Product.Product_Name + " no Price in this product ", this);
                    }
                    billTotalTextBox.Text = Amount.ToString();
                }

                double ReturnBill = 0;

                foreach (DataGridViewRow item in billItemsDataGridView.Rows)
                {
                    // Done
                    //Return
                    var p = (BillItem)item.DataBoundItem;
                    if (item.Cells[4].Value==null)
                    {
                        MessageBox.Show("Please Fill Status Choice");
                        break;
                    }
                    if (item.Cells[4].Value.ToString().Contains("Return"))
                    {
                        ReturnBill = ReturnBill + ( p.Product.ProductPrice.Value * item.Cells[3].Value.ToString().Todouble());
                    }
                    Amount = Amount - ReturnBill;
                    billTotalTextBox.Text = Amount.ToString();
                }
            }
            catch (Exception ex)
            {
                
               
            }
        }
    }
}
