using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
using Telerik.WinControls.UI;
namespace Bylsan_System.SenarioAddOrderForms
{
    public partial class frmSpAttachment_ : RadForm
    {
        public frmSpAttachment_()
        {
            InitializeComponent();
            TragetProduct = new Product();
            RetrunProduct = new OrderProduct();
        }
        public Product TragetProduct { get; set; }
        public OrderProduct RetrunProduct { get; set; }
        private void frmSpAttachment__Load(object sender, EventArgs e)
        {
           

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex==1)
            {
                OpenFileDialog op = new OpenFileDialog();
                if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    dataGridView1.CurrentCell.Value = Image.FromFile(op.FileName);

                }

            }
            
        }

        private void orderProuctAttachmentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            RetrunProduct = new OrderProduct();
            RetrunProduct.ProductID = TragetProduct.ID;
            RetrunProduct.Product = TragetProduct;
            RetrunProduct.Product.ProductPrice = TragetProduct.ProductPrice;
            RetrunProduct.Qty = 1;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                try
                {
                    RetrunProduct.OrderProuctAttachments.Add(new OrderProuctAttachment()
                    {
                        CustomerText = item.Cells[3].Value.ToString(),
                        Description = item.Cells[2].Value.ToString(),
                        imageX = (Image)item.Cells[1].Value


                    });
                }
                catch (Exception)
                {

                    continue;
                }
                
            }
            this.Close();
        }
    }
}
