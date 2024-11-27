namespace QLCuaHangDoGo
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lb_QuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.lb_DangKy = new System.Windows.Forms.LinkLabel();
            this.peye = new System.Windows.Forms.PictureBox();
            this.phide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phide)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(13, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(153, 217);
            this.txtTaiKhoan.Multiline = true;
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(254, 34);
            this.txtTaiKhoan.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(153, 292);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(254, 33);
            this.txtMatKhau.TabIndex = 2;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(207, 418);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(139, 42);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.Image = global::QLCuaHangDoGo.Properties.Resources.iconmk1;
            this.pictureBox1.Location = new System.Drawing.Point(81, 292);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QLCuaHangDoGo.Properties.Resources.iconuser;
            this.pictureBox2.Location = new System.Drawing.Point(81, 217);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::QLCuaHangDoGo.Properties.Resources.user_login_icon_1948x2048_nocsasoq;
            this.pictureBox3.Location = new System.Drawing.Point(153, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(254, 109);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // lb_QuenMatKhau
            // 
            this.lb_QuenMatKhau.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lb_QuenMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QuenMatKhau.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lb_QuenMatKhau.Location = new System.Drawing.Point(150, 356);
            this.lb_QuenMatKhau.Name = "lb_QuenMatKhau";
            this.lb_QuenMatKhau.Size = new System.Drawing.Size(142, 37);
            this.lb_QuenMatKhau.TabIndex = 11;
            this.lb_QuenMatKhau.TabStop = true;
            this.lb_QuenMatKhau.Text = "Quên Mật Khẩu?";
            this.lb_QuenMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_QuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_QuenMatKhau_LinkClicked);
            // 
            // lb_DangKy
            // 
            this.lb_DangKy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lb_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DangKy.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lb_DangKy.LinkColor = System.Drawing.Color.Blue;
            this.lb_DangKy.Location = new System.Drawing.Point(331, 356);
            this.lb_DangKy.Name = "lb_DangKy";
            this.lb_DangKy.Size = new System.Drawing.Size(108, 37);
            this.lb_DangKy.TabIndex = 12;
            this.lb_DangKy.TabStop = true;
            this.lb_DangKy.Text = "Đăng Ký";
            this.lb_DangKy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_DangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_DangKy_LinkClicked);
            // 
            // peye
            // 
            this.peye.Image = ((System.Drawing.Image)(resources.GetObject("peye.Image")));
            this.peye.Location = new System.Drawing.Point(413, 292);
            this.peye.Name = "peye";
            this.peye.Size = new System.Drawing.Size(42, 33);
            this.peye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.peye.TabIndex = 13;
            this.peye.TabStop = false;
            this.peye.Click += new System.EventHandler(this.peye_Click);
            // 
            // phide
            // 
            this.phide.Image = ((System.Drawing.Image)(resources.GetObject("phide.Image")));
            this.phide.Location = new System.Drawing.Point(410, 292);
            this.phide.Name = "phide";
            this.phide.Size = new System.Drawing.Size(45, 33);
            this.phide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.phide.TabIndex = 14;
            this.phide.TabStop = false;
            this.phide.Click += new System.EventHandler(this.phide_Click);
            // 
            // frmDangNhap
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::QLCuaHangDoGo.Properties.Resources.milky_way_starry_sky_night_sky_star_956999;
            this.ClientSize = new System.Drawing.Size(526, 506);
            this.Controls.Add(this.phide);
            this.Controls.Add(this.peye);
            this.Controls.Add(this.lb_DangKy);
            this.Controls.Add(this.lb_QuenMatKhau);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label1);
            this.Name = "frmDangNhap";
            this.Text = "Đăng Nhập Hệ Thống";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDangNhap_FormClosing);
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel lb_QuenMatKhau;
        private System.Windows.Forms.LinkLabel lb_DangKy;
        private System.Windows.Forms.PictureBox peye;
        private System.Windows.Forms.PictureBox phide;
    }
}

