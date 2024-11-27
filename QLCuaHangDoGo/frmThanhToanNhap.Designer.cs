namespace QLCuaHangDoGo
{
    partial class frmThanhToanNhap
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
            this.rpThanhToanNhap = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rpThanhToanNhap
            // 
            this.rpThanhToanNhap.Location = new System.Drawing.Point(31, 12);
            this.rpThanhToanNhap.Name = "rpThanhToanNhap";
            this.rpThanhToanNhap.ServerReport.BearerToken = null;
            this.rpThanhToanNhap.Size = new System.Drawing.Size(738, 364);
            this.rpThanhToanNhap.TabIndex = 0;
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.Location = new System.Drawing.Point(609, 393);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(125, 45);
            this.btnNhapHang.TabIndex = 1;
            this.btnNhapHang.Text = "Nhập Hàng";
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // frmThanhToanNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNhapHang);
            this.Controls.Add(this.rpThanhToanNhap);
            this.Name = "frmThanhToanNhap";
            this.Text = "Thanh Toán Nhập";
            this.Load += new System.EventHandler(this.frmThanhToanNhap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpThanhToanNhap;
        private System.Windows.Forms.Button btnNhapHang;
    }
}