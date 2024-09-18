using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BT01_SQL
{
    public partial class Form1 : Form
    {
        //1. Khai bao cac doi tuong can su dung
        //1.1 Chuoi ket noi
        string strcon = @"server=.; Database=QLSV_SV_L1; integrated security=true";
        //1.2 Doi tuong ket noi
        SqlConnection cnn;
        //1.3 Khai bao cac doi tuong luu du lieu
        DataSet ds = new DataSet();
        DataTable tblKhoa = new DataTable("KHOA");
        DataTable tblSinhVien = new DataTable("SINHVIEN");
        DataTable tblKetQua = new DataTable("KETQUA");

        //2 Khia bao cac command de doc va ghi du lieu
        SqlCommand cmdKhoa, cmdSinhVien, cmdKetQua;
        //Khai bao bien stt
        int stt = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Khoi tao ket noi
            cnn = new SqlConnection(strcon);
            ////cnn.Open();
            //if (cnn.State == ConnectionState.Open)
            //    MessageBox.Show("Ok");
            TaoCauTrucCacBang();
            MocNoiQuanHeCacBang();
            NhapDuLieuCacBang();
            KhoiTaoComboKhoa();

            stt = 0;
            GanDuLieu(stt);
        }

        private void TaoCauTrucCacBang()
        {
            //Tạo cấu trúc cho DataTable tương ứng với bảng KHOA
            tblKhoa.Columns.Add("MaKH", typeof(string));
            tblKhoa.Columns.Add("TenKH", typeof(string));
            //Tạo khoá chính cho tblKHOA
            tblKhoa.PrimaryKey = new DataColumn[] { tblKhoa.Columns["MaKH"] };

            //Tạo cấu trúc cho DataTable tương ứng với bảng SINHVIEN
            tblSinhVien.Columns.Add("MaSV", typeof(string));
            tblSinhVien.Columns.Add("HoSV", typeof(string));
            tblSinhVien.Columns.Add("TenSV", typeof(string));
            tblSinhVien.Columns.Add("Phai", typeof(Boolean));
            tblSinhVien.Columns.Add("NgaySinh", typeof(DateTime));
            tblSinhVien.Columns.Add("NoiSinh", typeof(string));
            tblSinhVien.Columns.Add("MaKH", typeof(string));
            tblSinhVien.Columns.Add("HocBong", typeof(double));
            //Tạo khoá chính cho tblSINHVIEN
            tblSinhVien.PrimaryKey = new DataColumn[] { tblSinhVien.Columns["MaSV"] };

            //Tạo cấu trúc cho DataTable tương ứng với bảng KETQUA
            tblKetQua.Columns.Add("MaSV", typeof(string));
            tblKetQua.Columns.Add("MaMH", typeof(string));
            tblKetQua.Columns.Add("Diem", typeof(double));
            //Tạo khoá chính cho tblSINHVIEN
            tblKetQua.PrimaryKey = new DataColumn[] { tblKetQua.Columns["MaSV"], tblKetQua.Columns["MaMH"] };

            //Them cac DataTable vao DataSet, dung tung lenh
            //ds.Tables.Add(tblKhoa);
            //ds.Tables.Add(tblSinhVien);
            //ds.Tables.Add(tblKetQua);

            //Them dong thoi nhieu Datatable vao DataSet
            ds.Tables.AddRange(new DataTable[] { tblKhoa, tblSinhVien, tblKetQua });
        }

        private void MocNoiQuanHeCacBang()
        {
            //Tao quan he giua tblKhoa vaf tblSinhVien
            ds.Relations.Add("FK_KHOA_SINHVIEN", ds.Tables["KHOA"].Columns["MaKH"], ds.Tables["SINHVIEN"].Columns["MaKH"], true);
            //Tao quan he giua tblSinhVien vaf tblKetQua
            ds.Relations.Add("FK_SINHVIEN_KETQUA", ds.Tables["SINHVIEN"].Columns["MaSV"], ds.Tables["KETQUA"].Columns["MaSV"], true);
            //Loai bo Cacase Delete trong cac quan he
            ds.Relations["FK_KHOA_SINHVIEN"].ChildKeyConstraint.DeleteRule = Rule.None;
            ds.Relations["FK_SINHVIEN_KETQUA"].ChildKeyConstraint.DeleteRule = Rule.None;
        }

        private void NhapDuLieuCacBang()
        {
            NhapLieu_tblKhoa();
            NhapLieu_tblSinhVien();
            NhapLieu_tblKetQua();
        }

        private void NhapLieu_tblKhoa()
        {
            //1 Mo ket noi
            cnn.Open();
            //2 Khoi tao doi tuong command tuong ung de doc du lieu tu table KHOA
            cmdKhoa = new SqlCommand("select * from KHOA", cnn);
            //3 Tao doi tuong DataReader de tien hanh doc du lieu teong table KHOA
            SqlDataReader rkh = cmdKhoa.ExecuteReader();
            //4 Tien hanh doc du lieu voi doi tuong DataReader nhu sau
            while (rkh.Read())  //Moi lan nap thi rkh tro den 1 dong trong table KHOA
            {
                DataRow r = tblKhoa.NewRow();
                for (int i = 0; i < rkh.FieldCount; i++)
                    r[i] = rkh[i];
                tblKhoa.Rows.Add(r);
            }
            //5 Dong dataReader va doi tuong ket noi
            rkh.Close();
            cnn.Close();
        }

        private void NhapLieu_tblSinhVien()
        {
            //1 Mo ket noi
            cnn.Open();
            //2 Khoi tao doi tuong command tuong ung de doc du lieu tu table SINHVIEN
            cmdSinhVien = new SqlCommand("select * from SINHVIEN", cnn);
            //3 Tao doi tuong DataReader de tien hanh doc du lieu teong table SINHVIEN
            SqlDataReader rsv = cmdSinhVien.ExecuteReader();
            //4 Tien hanh doc du lieu voi doi tuong DataReader nhu sau
            while (rsv.Read())  //Moi lan nap thi rkh tro den 1 dong trong table SINHVIEN
            {
                DataRow r = tblSinhVien.NewRow();
                for (int i = 0; i < rsv.FieldCount; i++)
                    r[i] = rsv[i];
                tblSinhVien.Rows.Add(r);
            }
            //5 Dong dataReader va doi tuong ket noi
            rsv.Close();
            cnn.Close();
        }

        private void NhapLieu_tblKetQua()
        {
            //1 Mo ket noi
            cnn.Open();
            //2 Khoi tao doi tuong command tuong ung de doc du lieu tu table KETQUA
            cmdKetQua = new SqlCommand("select * from KETQUA", cnn);
            //3 Tao doi tuong DataReader de tien hanh doc du lieu teong table KETQUA
            SqlDataReader rkq = cmdKetQua.ExecuteReader();
            //4 Tien hanh doc du lieu voi doi tuong DataReader nhu sau
            while (rkq.Read())  //Moi lan nap thi rkh tro den 1 dong trong table KETQUA
            {
                DataRow r = tblKetQua.NewRow();
                for (int i = 0; i < rkq.FieldCount; i++)
                    r[i] = rkq[i];
                tblKetQua.Rows.Add(r);
            }
            //5 Dong dataReader va doi tuong ket noi
            rkq.Close();
            cnn.Close();
        }

        private void KhoiTaoComboKhoa()
        {
            cboMaKhoa.DisplayMember = "TenKH";
            cboMaKhoa.ValueMember = "MaKH";
            cboMaKhoa.DataSource = tblKhoa;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            cnn.Open();
            if (txtMaSV.ReadOnly == true)//Ghi khi SUA
            {
                //Xac dinh dong SINHVIEN caanf sua
                DataRow rsv = tblSinhVien.Rows.Find(txtMaSV.Text);
                //Tien hanh sua
                //1 Cap nhat gia tri tren Form vao database
                rsv["HoSV"] = txtHoSV.Text;
                rsv["TenSV"] = txtTenSV.Text;
                rsv["Phai"] = chkPhai.Checked==true ? 1:0;
                rsv["NgaySinh"] = dtpNgaySinh.Text;
                rsv["NoiSinh"] = txtNoiSinh.Text;
                rsv["MaKH"] = cboMaKhoa.SelectedValue.ToString();
                rsv["HocBong"] = txtHocbong.Text;
                //2 Cap nhat gia tri tren Form vao CSDL Access
                string chuoiSua = "Update SINHVIEN set ";
                chuoiSua += "HoSV = N'" + txtHoSV.Text + "',";
                chuoiSua += "TenSV = N'" + txtTenSV.Text + "',";
                chuoiSua += "Phai = " + (chkPhai.Checked==true?1:0) + ",";
                chuoiSua += "NgaySinh = '" + dtpNgaySinh.Value + "',";
                chuoiSua += "NoiSinh = '" + txtNoiSinh.Text + "',";
                chuoiSua += "MaKH = '" + cboMaKhoa.SelectedValue.ToString() + "',";
                chuoiSua += "HocBong = " + txtHocbong.Text;
                chuoiSua += " Where MaSV = '" + txtMaSV.Text + "'";
                cmdSinhVien = new SqlCommand(chuoiSua, cnn);
                int n = cmdSinhVien.ExecuteNonQuery();
                if (n > 0)
                    MessageBox.Show("Cap nhat SUA thanh cong");
            }
            else
            {
                //Tao mơi va them sinh vien vao Database SINHVIEN
                //Kiem tra khoa chinh co bi trung khong
                DataRow rsv = tblSinhVien.Rows.Find(txtMaSV.Text);
                if (rsv != null)//Da co SV mang MaSV nay
                {
                    MessageBox.Show("MaSV nay bi trung, moi nhap MaSV khac");
                    txtMaSV.Focus();
                    return;
                }
                rsv = tblSinhVien.NewRow();
                rsv["MaSV"] = txtMaSV.Text;
                rsv["HoSV"] = txtHoSV.Text;
                rsv["TenSV"] = txtTenSV.Text;
                rsv["Phai"] = chkPhai.Checked;
                rsv["NgaySinh"] = dtpNgaySinh.Text;
                rsv["NoiSinh"] = txtNoiSinh.Text;
                rsv["MaKH"] = cboMaKhoa.SelectedValue.ToString();
                rsv["HocBong"] = txtHocbong.Text;
                tblSinhVien.Rows.Add(rsv);
                //Them moi sinh vien vao CSDL
                string chuoiThem = "Insert into SINHVIEN values (";
                chuoiThem += "'" + txtMaSV.Text + "',";
                chuoiThem += "N'" + txtHoSV.Text + "',";
                chuoiThem += "N'" + txtTenSV.Text + "',";
                chuoiThem += (chkPhai.Checked==true?1:0) + ",";
                chuoiThem += "'" + dtpNgaySinh.Text + "',";
                chuoiThem += "N'" + txtNoiSinh.Text + "',";
                chuoiThem += "'" + cboMaKhoa.SelectedValue.ToString() + "',";
                chuoiThem += txtHocbong.Text + ")";
                cmdSinhVien = new SqlCommand(chuoiThem, cnn);
                int n = cmdSinhVien.ExecuteNonQuery();
                if (n > 0)
                    MessageBox.Show("Cap nhat THEM thanh cong");
            }
            cnn.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //Xac dinh dong can huy Su dung ham Find
            DataRow rsv = tblSinhVien.Rows.Find(txtMaSV.Text);
            //Can kien tra Neu rsv ton tai trong tblKetQua thi khong xoa. Nguoc lai thi cho xoa
            //Su dung ham getChilRow de kiem tra nhung dong lien quan co ton tai hay khong. Gia tri tra ve la mang
            DataRow[] mangDongLienQuan = rsv.GetChildRows("FK_SINHVIEN_KETQUA");
            if (mangDongLienQuan.Length > 0)//co ton tai nhung dong lien quan trong tblKetQua
                MessageBox.Show("Khong xoa duoc Sv vi da co ket qua thi");
            else
            {
                DialogResult tl;
                tl = MessageBox.Show("Xoa sinh vien nay khong?", "Can than", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tl == DialogResult.Yes)
                {
                    //Xoa trong DataTable
                    rsv.Delete();
                    //Xoa trong CSDL
                    cnn.Open();
                    string chuoiXoa = "Delete from SINHVIEN where MaSV='" + txtMaSV.Text + "'";
                    cmdSinhVien = new SqlCommand(chuoiXoa, cnn);
                    int n = cmdSinhVien.ExecuteNonQuery();
                    if (n > 0)
                        MessageBox.Show("Xoa sinh vien thanh cong");
                    stt = 0;
                    GanDuLieu(stt);
                    cnn.Close();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaSV.ReadOnly = false;
            foreach (Control ctl in Controls)
                if (ctl is TextBox)
                    (ctl as TextBox).Clear();
                else if (ctl is CheckBox)
                    (ctl as CheckBox).Checked = true;
                else if (ctl is ComboBox)
                    (ctl as ComboBox).SelectedIndex = 0;
                else if (ctl is DateTimePicker)
                    (ctl as DateTimePicker).Value = new DateTime(2006, 1, 1);
            txtMaSV.Focus();
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (stt == tblSinhVien.Rows.Count - 1) return;
            stt++;
            GanDuLieu(stt);
        }

        private void GanDuLieu(int stt)
        {
            //lay dong du lieu thu stt trong tblsinhVien
            DataRow rsv = tblSinhVien.Rows[stt];
            txtMaSV.Text = rsv["MaSV"].ToString();
            txtHoSV.Text = rsv["HoSV"].ToString();
            txtTenSV.Text = rsv["TenSV"].ToString();
            chkPhai.Checked = (Boolean)rsv["Phai"];
            dtpNgaySinh.Text = rsv["NgaySinh"].ToString();
            txtNoiSinh.Text = rsv["NoiSinh"].ToString();
            cboMaKhoa.SelectedValue = rsv["MaKH"].ToString();
            txtHocbong.Text = rsv["HocBong"].ToString();
            //the hien so thu tu mau tin hien hanh
            lblSTT.Text = (stt + 1) + "/" + tblSinhVien.Rows.Count;
            //Tinh tong diem
            txtTongDiem.Text = TongDiem(txtMaSV.Text).ToString();
        }

        private object TongDiem(string text)
        {
            double kq = 0;
            Object td = tblKetQua.Compute("sum(Diem)", "MaSV='" + txtMaSV + "'");
            //Luu y Truong hop SV khong co diem thi phuong thuc tra ve gia tri DBNull
            if (td == DBNull.Value)
                kq = 0;
            else
                kq = Convert.ToDouble(td);
            return kq;
        }
    }
}
