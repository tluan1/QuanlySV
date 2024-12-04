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
    public partial class Khoa : Form
    {
        public Khoa()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAB2-36;Initial Catalog=QLSV;Integrated Security=True");
        private void openCon()
        {
            if (con.State == ConnectionState.Closed)
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
        //private void load();
            
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtmakhoa.ResetText();
            txttenkhoa.ResetText();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Exe("INSERT INTO Khoa(Makhoa, Tenkhoa) VALUES('" + txtmakhoa.Text + "', N'" + txttenkhoa.Text + "'");
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Exe("UPDATE Khoa SET Makhoa = '" + txtmakhoa.Text + "', Tenkhoa = N'" + txttenkhoa.Text + "'");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            Exe("DELETE FROM Khoa WHERE Makhoa = '" + txtmakhoa.Text + "'");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmakhoa.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txttenkhoa.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
