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
    public partial class Giaovien : Form
    {
        public Giaovien()
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
        private void load()
        {
            DataTable dt = Red("SELECT * FROM Giaovien");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }
        private void Load(object sender, EventArgs e)
        {
            load();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmagv.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txthotengv.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsdt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtemail.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtmakhoa.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtmagv.ResetText();
            txthotengv.ResetText();
            txtemail.ResetText();
            txtsdt.ResetText();
            txtmakhoa.ResetText();
        }

        private void Giaovien_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Exe("INSERT INTO Giaovien(Magv, Hotengv, sdt, Email, Makhoa) VALUES ('" + txtmagv.Text + "', N'" + txthotengv.Text + "', '" + txtsdt.Text + "', '" + txtemail.Text + "', '" + txtmakhoa.Text + "'");
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Exe("UPDATE Giaovien SET Magv = '" + txtmagv.Text + "', Hotengv = N'" + txthotengv.Text + "', '" + txtsdt.Text + "', '" + txtemail.Text + "', '" + txtmakhoa + "'");
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            Exe("DELETE FROM Giaovien WHERE Magv = '" + txtmagv.Text + "'");
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            DataTable dt = Red("SELECT * FROM Giaovien WHERE Magv = '" + txtmagv.Text + "'");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }
    }
}
