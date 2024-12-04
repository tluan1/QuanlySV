using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlySV
{
    public partial class Lophoc : Form
    {
        public Lophoc()
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
            DataTable dt = Red("SELECT * FROM Lophoc");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void Lophoc_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtmalop.ResetText();
            txttenlop.ResetText();
            txtsoluongsv.ResetText();
            txtmakhoa.ResetText();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Exe("INSERT INTO Lophoc(Malop, Tenlop, Soluongsv, Makhoa) VALUES('" + txtmalop + "', N'" + txttenlop + "', '" + txtsoluongsv + "', N'" + txtmakhoa + "'");
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Exe("UPDATE Lophoc SET Malop = '" + txtmalop.Text + "', Tenlop = N'" + txttenlop.Text + "', Soluongsv = N'" + txtsoluongsv + "', '" + txtmakhoa + "'");
        }
    }
}
