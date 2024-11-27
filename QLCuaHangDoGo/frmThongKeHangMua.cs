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

namespace QLCuaHangDoGo
{
    public partial class frmThongKeHangNhap : Form
    {
        public frmThongKeHangNhap()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void frmThongKeHangMua_Load(object sender, EventArgs e)
        {

            try
            {
                rpThongKeHangMua.LocalReport.ReportEmbeddedResource = "QLCuaHangDoGo.Report8.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1";
                reportDataSource.Value = kn.getAllHangHoa();
                rpThongKeHangMua.LocalReport.DataSources.Add(reportDataSource);
                this.rpThongKeHangMua.RefreshReport();
                rpThongKeHangMua.AutoSize = true;
                rpThongKeHangMua.ZoomMode = ZoomMode.PageWidth;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
