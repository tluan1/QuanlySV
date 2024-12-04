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

namespace QuanlySV
{
    public partial class Thongtinsv : Form
    {
        public Thongtinsv()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAB2-36;Initial Catalog=QLSV;Integrated Security=True");
        private void openCon()
        {
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
        }
        private void closeCon()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        private Boolean Exe(String cmd)
        {
            openCon();
            Boolean check;
            try 
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                sc.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }
            closeCon();
            return check;
        }
        private DataTable Red(String cmd)
        {
            openCon();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sda.Fill(dt);
            }
            catch (Exception) 
            {
                dt = null;
                throw;
            }
            closeCon();
            return dt;
        }
        private void load()
        {
            DataTable dt = Red("SELECT * FROM Sinhvien");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }
        private void Thongtinsv_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtmasv.ResetText();
            txthosv.ResetText();
            txttensv.ResetText();
            txtngaysinh.ResetText();
            txtgioitinh.ResetText();
            txtdiachi.ResetText();
            txtemail.ResetText();
            txtsdt.ResetText();
            txtmakhoa.ResetText();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Exe("INSERT INTO Sinhvien(Hosv, Tensv, Ngaysinh, Gioitinh, Diachi, Email, Sodienthoai, Makhoa) VALUES('N'" + txthosv.Text + "', N'" + txttensv.Text + "', '" + txtngaysinh.Text + "', N'" + txtgioitinh.Text + "', N'" + txtdiachi.Text + "', '" + txtemail.Text + "', '" + txtsdt.Text + "', '" + txtmakhoa.Text + "'");
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            load();
        }
        
        private void btnsua_Click(object sender, EventArgs e)
        {
            Exe("UPDATE Sinhvien SET Masv = '" + txtmasv.Text + "', Hosv = N'" + txthosv.Text + "', Tensv = N'" + txttensv + "', Ngaysinh = '" + txtngaysinh.Text + "', Gioitinh = N'" + txtgioitinh.Text + "', Diachi = N'" + txtdiachi.Text + "', Email = '" + txtemail.Text + "', Sodienthoai = '" + txtsdt.Text + "', Makhoa = '" + txtmakhoa.Text + "' WHERE Masv = '" + txtmasv.Text + "'");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmasv.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txthosv.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txttensv.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtngaysinh.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtgioitinh.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtdiachi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtemail.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsdt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtmakhoa.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            Exe("DELETE FROM Sinhvien WHERE Masv = '" + txtmasv.Text + "'");
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            DataTable dt = Red("SELECT * FROM Sinhvien WHERE Masv = '" + txtmasv.Text + "'");
            if (dt != null) 
            {
                dataGridView1.DataSource = dt;
            }
        }
    }
}
