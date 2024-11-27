using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace QLCuaHangDoGo.Thống_kê___Báo_cáo
{
    public partial class frmBaoCaoTN : Form
    {
        public frmBaoCaoTN()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();

        private void frmBaoCaoTN_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "QLCuaHangDoGo.Report1.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1";
                reportDataSource.Value = kn.getAllLuong();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
                reportViewer1.AutoSize = true;
                reportViewer1.ZoomMode = ZoomMode.PageWidth;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
