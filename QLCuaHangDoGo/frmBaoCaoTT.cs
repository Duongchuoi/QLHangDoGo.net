using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDoGo.Thống_kê___Báo_cáo
{
    public partial class frmBaoCaoTT : Form
    {
        public frmBaoCaoTT()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void frmBaoCaoTT_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "QLCuaHangDoGo.Report3.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1";
                reportDataSource.Value = kn.getAllHangHoa();
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
    }
}
