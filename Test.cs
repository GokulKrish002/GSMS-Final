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

namespace GSMS
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }
        private void Test_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaashivDataSet.CarDetails' table. You can move, or remove it, as needed.
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SqlConnection Car = new SqlConnection(@"Data Source=GOKULSVICTUS\SQLEXPRESS;Initial Catalog=kaashiv;Integrated Security=True");
            Car.Open();
            SqlCommand cmd = new SqlCommand("CarDetails_ins", Car);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@CarBrand", SqlDbType.VarChar);
            cmd.Parameters.Add(param1).Value = guna2TextBox1.Text;
            SqlParameter param2 = new SqlParameter("@CarCost", SqlDbType.Int);
            cmd.Parameters.Add(param2).Value = guna2TextBox2.Text;
            SqlParameter param3 = new SqlParameter("@CarDescription", SqlDbType.VarChar);
            cmd.Parameters.Add(param3).Value = guna2TextBox3.Text;
            int i = cmd.ExecuteNonQuery();
            Car.Close();
            if (i == 0)
            {
                label7.Text = "some thing wrong happen try again later....";
            }
            else
            {
                label7.Text = "executed successfully...";
            }
            SqlCommand comme = new SqlCommand("select * from CarDetails", Car);
            SqlDataAdapter d = new SqlDataAdapter(comme);
            DataTable dt = new DataTable();
            d.Fill(dt);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SqlConnection Car = new SqlConnection(@"Data Source=GOKULSVICTUS\SQLEXPRESS;Initial Catalog=kaashiv;Integrated Security=True");
            Car.Open();
            SqlCommand cmd = new SqlCommand("CarDetails_Ups", Car); 
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@CarBrand", SqlDbType.VarChar);
            cmd.Parameters.Add(param1).Value = guna2TextBox1.Text;
            SqlParameter param2 = new SqlParameter("@CarCost", SqlDbType.Int);
            cmd.Parameters.Add(param2).Value = guna2TextBox2.Text;
            SqlParameter param3 = new SqlParameter("@CarDescription", SqlDbType.VarChar);
            cmd.Parameters.Add(param3).Value = guna2TextBox3.Text;
            SqlParameter param4 = new SqlParameter("@CarId", SqlDbType.Int);
            cmd.Parameters.Add(param4).Value = guna2TextBox4.Text;
            int i = cmd.ExecuteNonQuery();
            Car.Close();
            if (i == 0)
            {
                label7.Text = "some thing wrong happen try again later....";
            }
            else
            {
                label7.Text = "Success...";
            }
            SqlCommand comme = new SqlCommand("select * from CarDetails", Car);
            SqlDataAdapter d = new SqlDataAdapter(comme);
            DataTable dt = new DataTable();
            d.Fill(dt);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            SqlConnection Car = new SqlConnection(@"Data Source=GOKULSVICTUS\SQLEXPRESS;Initial Catalog=kaashiv;Integrated Security=True");
            Car.Open();
            SqlCommand cmd = new SqlCommand("CarDetails_Del", Car);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@CarId", SqlDbType.Int);
            cmd.Parameters.Add(param1).Value = guna2TextBox4.Text;
            int i = cmd.ExecuteNonQuery();
            Car.Close();
            if (i == 0)
            {
                label7.Text = "some thing wrong happen try again later....";
            }
            else
            {
                label7.Text = "Success...";
            }
            SqlCommand comme = new SqlCommand("select * from CarDetails", Car);
            SqlDataAdapter d = new SqlDataAdapter(comme);
            DataTable dt = new DataTable();
            d.Fill(dt);
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection Car = new SqlConnection(@"Data Source=GOKULSVICTUS\SQLEXPRESS;Initial Catalog=kaashiv;Integrated Security=True");
                Car.Open();
                SqlCommand cmd = new SqlCommand("CarDetails_Sea", Car);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@CarBrand", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value = guna2TextBox5.Text;
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                d.Fill(dt);
                guna2DataGridView2.DataSource = dt;
                Car.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

