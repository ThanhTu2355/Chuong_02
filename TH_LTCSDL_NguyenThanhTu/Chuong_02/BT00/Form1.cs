using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//Access
using System.Data.SqlClient;//sql Server

namespace BT00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Khai bao cac doi tuong can su dung de ket noi
            //1. Chuoi ket noi  den csdl access 2003
            string strcon = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\..\..\data\QLSV.mdb";
            //2. Khai bao doi tuong ket doi
            OleDbConnection cnn = new OleDbConnection(strcon);
            //3. Mo ket noi
            cnn.Open();
            //4. Kiem tra xem co ket noi thanh cong khong?
            if (cnn.State == ConnectionState.Open)
                MessageBox.Show("Ket noi voi SQL.mdb thanh cong", "Thong bao ket noi", MessageBoxButtons.OK, MessageBoxIcon.None);
            //5. Sau khi su dung thi dong ket noi
            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Khai bao cac doi tuong can su dung de ket noi
            //1. Chuoi ket noi  den csdl access 2003
            string strcon = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\..\..\data\QLSV.accdb";
            //2. Khai bao doi tuong ket doi
            OleDbConnection cnn = new OleDbConnection(strcon);
            //3. Mo ket noi
            cnn.Open();
            //4. Kiem tra xem co ket noi thanh cong khong?
            if (cnn.State == ConnectionState.Open)
                MessageBox.Show("Ket noi voi SQL.accdb thanh cong", "Thong bao ket noi", MessageBoxButtons.OK, MessageBoxIcon.None);
            //5. Sau khi su dung thi dong ket noi
            cnn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Khai bao cac doi tuong can su dung de ket noi
            //1. Chuoi ket noi  den csdl access 2003
            string strcon = @"server=.; Database=QLSV_SV_L1; integrated security=true";
            //2. Khai bao doi tuong ket doi
            SqlConnection cnn = new SqlConnection(strcon);
            //3. Mo ket noi
            cnn.Open();
            //4. Kiem tra xem co ket noi thanh cong khong?
            if (cnn.State == ConnectionState.Open)
                MessageBox.Show("Ket noi voi SQL Sever (Win) thanh cong", "Thong bao ket noi", MessageBoxButtons.OK, MessageBoxIcon.None);
            //5. Sau khi su dung thi dong ket noi
            cnn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Khai bao cac doi tuong can su dung de ket noi
            //1. Chuoi ket noi  den csdl access 2003
            string strcon = @"server=.; Database=QLSV_SV_L1; uid=sa; pwd=c23";
            //2. Khai bao doi tuong ket doi
            SqlConnection cnn = new SqlConnection(strcon);
            //3. Mo ket noi
            cnn.Open();
            //4. Kiem tra xem co ket noi thanh cong khong?
            if (cnn.State == ConnectionState.Open)
                MessageBox.Show("Ket noi voi SQL Sever (sa) thanh cong", "Thong bao ket noi", MessageBoxButtons.OK, MessageBoxIcon.None);
            //5. Sau khi su dung thi dong ket noi
            cnn.Close();
        }
    }
}
