namespace BT01
{
    partial class Form1
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
            this.chkPhai = new System.Windows.Forms.CheckBox();
            this.btnKhong = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.cboMaKhoa = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.lblSTT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongDiem = new System.Windows.Forms.TextBox();
            this.txtHocbong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHoSV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MaSV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkPhai
            // 
            this.chkPhai.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPhai.Location = new System.Drawing.Point(31, 165);
            this.chkPhai.Name = "chkPhai";
            this.chkPhai.Size = new System.Drawing.Size(104, 26);
            this.chkPhai.TabIndex = 32;
            this.chkPhai.Text = "Giới tính";
            this.chkPhai.UseVisualStyleBackColor = true;
            // 
            // btnKhong
            // 
            this.btnKhong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhong.ForeColor = System.Drawing.Color.Maroon;
            this.btnKhong.Location = new System.Drawing.Point(441, 300);
            this.btnKhong.Name = "btnKhong";
            this.btnKhong.Size = new System.Drawing.Size(71, 35);
            this.btnKhong.TabIndex = 41;
            this.btnKhong.Text = "Không";
            this.btnKhong.UseVisualStyleBackColor = true;
            // 
            // btnGhi
            // 
            this.btnGhi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhi.ForeColor = System.Drawing.Color.Maroon;
            this.btnGhi.Location = new System.Drawing.Point(364, 300);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(71, 35);
            this.btnGhi.TabIndex = 40;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Maroon;
            this.btnHuy.Location = new System.Drawing.Point(297, 300);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(71, 35);
            this.btnHuy.TabIndex = 39;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnSau
            // 
            this.btnSau.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSau.ForeColor = System.Drawing.Color.Maroon;
            this.btnSau.Location = new System.Drawing.Point(154, 301);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(60, 33);
            this.btnSau.TabIndex = 36;
            this.btnSau.Text = "Sau";
            this.btnSau.UseVisualStyleBackColor = true;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Maroon;
            this.btnThem.Location = new System.Drawing.Point(220, 300);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(71, 35);
            this.btnThem.TabIndex = 38;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnTruoc
            // 
            this.btnTruoc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruoc.ForeColor = System.Drawing.Color.Maroon;
            this.btnTruoc.Location = new System.Drawing.Point(31, 301);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(60, 33);
            this.btnTruoc.TabIndex = 35;
            this.btnTruoc.Text = "Trước";
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // cboMaKhoa
            // 
            this.cboMaKhoa.FormattingEnabled = true;
            this.cboMaKhoa.Location = new System.Drawing.Point(345, 211);
            this.cboMaKhoa.Name = "cboMaKhoa";
            this.cboMaKhoa.Size = new System.Drawing.Size(167, 27);
            this.cboMaKhoa.TabIndex = 30;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(312, 165);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 27);
            this.dtpNgaySinh.TabIndex = 28;
            this.dtpNgaySinh.Value = new System.DateTime(2005, 11, 1, 0, 0, 0, 0);
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(364, 118);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(148, 27);
            this.txtTenSV.TabIndex = 27;
            // 
            // lblSTT
            // 
            this.lblSTT.AutoSize = true;
            this.lblSTT.Location = new System.Drawing.Point(97, 308);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(51, 19);
            this.lblSTT.TabIndex = 24;
            this.lblSTT.Text = "00/00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ngày Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Họ tên SV";
            // 
            // txtTongDiem
            // 
            this.txtTongDiem.Location = new System.Drawing.Point(345, 254);
            this.txtTongDiem.Name = "txtTongDiem";
            this.txtTongDiem.Size = new System.Drawing.Size(167, 27);
            this.txtTongDiem.TabIndex = 33;
            // 
            // txtHocbong
            // 
            this.txtHocbong.Location = new System.Drawing.Point(120, 254);
            this.txtHocbong.Name = "txtHocbong";
            this.txtHocbong.Size = new System.Drawing.Size(108, 27);
            this.txtHocbong.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tổng điểm";
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Location = new System.Drawing.Point(121, 211);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(107, 27);
            this.txtNoiSinh.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Học bổng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Khoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nơi Sinh";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(121, 25);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.ReadOnly = true;
            this.txtMaSV.Size = new System.Drawing.Size(260, 27);
            this.txtMaSV.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "MaSV";
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(541, 55);
            this.label8.TabIndex = 42;
            this.label8.Text = "DANH SÁCH SINH VIÊN";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtHoSV
            // 
            this.txtHoSV.Location = new System.Drawing.Point(121, 118);
            this.txtHoSV.Name = "txtHoSV";
            this.txtHoSV.Size = new System.Drawing.Size(237, 27);
            this.txtHoSV.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Mã SV";
            // 
            // MaSV
            // 
            this.MaSV.Location = new System.Drawing.Point(121, 75);
            this.MaSV.Name = "MaSV";
            this.MaSV.Size = new System.Drawing.Size(391, 27);
            this.MaSV.TabIndex = 26;
            this.MaSV.TextChanged += new System.EventHandler(this.MaSV_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 355);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkPhai);
            this.Controls.Add(this.btnKhong);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.cboMaKhoa);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.MaSV);
            this.Controls.Add(this.txtHoSV);
            this.Controls.Add(this.lblSTT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTongDiem);
            this.Controls.Add(this.txtHocbong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNoiSinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLSV Access";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPhai;
        private System.Windows.Forms.Button btnKhong;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.ComboBox cboMaKhoa;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Label lblSTT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTongDiem;
        private System.Windows.Forms.TextBox txtHocbong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHoSV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MaSV;
    }
}

