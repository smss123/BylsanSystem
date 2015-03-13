using System;
using System.Drawing.Imaging;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Bylsan_System.Reports.ReportCommand;
using Telerik.WinControls.UI;
using XamaDataLayer;
using XamaDataLayer.BranchCmd;
using Xprema.XExtention;

namespace Bylsan_System.ManagmentOrderForms
{
    public partial class FrmOrderManage : RadForm
    {
        public FrmOrderManage()
        {
            InitializeComponent();
            DGVOrders.CommandCellClick += DGVOrders_CommandCellClick;
        }
        Thread th;

        private static void CreateBarcode(string code)
        {

            frmExperDate frm = new frmExperDate();
          if(  frm.ShowDialog()==DialogResult.OK)
          {
              var cmd = new ItemBarcodeReportCmd();
              cmd.GetItemStorByDate( int.Parse(code), 1, frm.SelectedDate.ToDateTime());

          }


            //var myBitmap = new Bitmap(500, 50);
            //var g = Graphics.FromImage(myBitmap);
            //var jgpEncoder = GetEncoder(ImageFormat.Jpeg);

            //g.Clear(Color.White);

            //var strFormat = new StringFormat { Alignment = StringAlignment.Center };
           
            //FontFamily p = new FontFamily("IDAutomationHC39M");
            //Font font = new Font("IDAutomationHC39M", 12.0f);
            //g.DrawString(code, font, Brushes.Black, new RectangleF(0, 0, 200, 50), strFormat);

            //var myEncoder = Encoder.Quality;
            //var myEncoderParameters = new EncoderParameters(1);

            //var myEncoderParameter = new EncoderParameter(myEncoder,100L);
            //myEncoderParameters.Param[0] = myEncoderParameter;
            //myBitmap.Save(Application.StartupPath+ @"\OrderBarcode.jpg", jgpEncoder, myEncoderParameters);
            //PrintDocument pd = new PrintDocument();
            //pd.DefaultPageSettings.PrinterSettings.PrinterName = Properties.Settings.Default.SmallPrinter;
            //pd.DefaultPageSettings.Landscape = false; //or false!
            //pd.PrintPage += (send, args) =>
            //{
            //    Image i = Image.FromFile(Application.StartupPath + @"\OrderBarcode.jpg");
            //    Rectangle m = args.MarginBounds;

            //    if ((double)i.Width / (double)i.Height > (double)m.Width / (double)m.Height) // image is wider
            //    {
            //        m.Height = (int)((double)i.Height / (double)i.Width * (double)m.Width);
            //    }
            //    else
            //    {
            //        m.Width = (int)((double)i.Width / (double)i.Height * (double)m.Height);
            //    }
            //    args.Graphics.DrawImage(i, m);
            //};
            //pd.Print();
        }

        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {

            var codecs = ImageCodecInfo.GetImageDecoders();

            foreach (var codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        } 

        void DGVOrders_CommandCellClick(object sender, EventArgs e)
        {
            if (DGVOrders.CurrentCell.ColumnInfo.Index==11)
            {
                Order o = (Order)DGVOrders.CurrentRow.DataBoundItem;
                FrmrOrderProductShow frm  = new FrmrOrderProductShow();
                frm.TragetOrder = o;
                frm.ShowDialog();
            }
            if (DGVOrders.CurrentCell.ColumnInfo.Index == 12)
            {
                frmExperDate frm = new frmExperDate();
                frm.ShowDialog();
                 Order o = (Order)DGVOrders.CurrentRow.DataBoundItem;
                 CreateBarcode(o.ID.ToString());
                
            }
        }

        private void FrmOrderManage_Load(object sender, EventArgs e)
        {
          th = new Thread(LoadOrder);
          th.Start();
        }

        private void LoadOrder()
        {
            Operation.BeginOperation(this);
            var q = OrdersCmd.GetAllOrders();
            this.Invoke((MethodInvoker)delegate {
                DGVOrders.DataSource = q;
            });
           
            Operation.EndOperation(this);
            th.Abort();
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            th = new Thread(LoadOrder);
            th.Start();
        }

        private void DGVOrders_Click(object sender, EventArgs e)
        {

        }
    }
}
