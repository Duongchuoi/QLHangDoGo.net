namespace QLCuaHangDoGo
{
    partial class frmThongKeHangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rpThongKeHangMua = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpThongKeHangMua
            // 
            this.rpThongKeHangMua.Location = new System.Drawing.Point(12, 23);
            this.rpThongKeHangMua.Name = "rpThongKeHangMua";
            this.rpThongKeHangMua.ServerReport.BearerToken = null;
            this.rpThongKeHangMua.Size = new System.Drawing.Size(776, 405);
            this.rpThongKeHangMua.TabIndex = 0;
            // 
            // frmThongKeHangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpThongKeHangMua);
            this.Name = "frmThongKeHangNhap";
            this.Text = "Thống Kê Hàng Nhập";
            this.Load += new System.EventHandler(this.frmThongKeHangMua_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpThongKeHangMua;
    }
}