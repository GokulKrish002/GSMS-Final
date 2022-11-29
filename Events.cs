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
using GSMS.App_Code;

namespace GSMS
{
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
        }
        DBConnection EventCon = new DBConnection();

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = EventCon.connect();
            try
            {
                SqlCommand cmd = new SqlCommand("Event_delete", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@Event_id", SqlDbType.Int);
                cmd.Parameters.Add(param1).Value = txt_Eventid.Text;
                int i = cmd.ExecuteNonQuery();
                connection.Close();
                if (i != 0)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txt_EventName.Text = "";
                txt_EventDiscription.Text = "";
            }
            SqlCommand comme = new SqlCommand("select * from Event_tbl", connection);
            SqlDataAdapter d = new SqlDataAdapter(comme);
            DataTable dt = new DataTable();
            d.Fill(dt);
            Event_GridView.DataSource = dt;
            connection.Close();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            SqlConnection connection = EventCon.connect();
            try
            {
                SqlCommand cmd = new SqlCommand("Event_update", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@Event_Name", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value = txt_EventName.Text;
                SqlParameter param2 = new SqlParameter("@Event_Discription", SqlDbType.VarChar);
                cmd.Parameters.Add(param2).Value = txt_EventDiscription.Text;
                SqlParameter param3 = new SqlParameter("@Event_Date", SqlDbType.Date);
                cmd.Parameters.Add(param3).Value = date_EventDate.Text;
                SqlParameter param4 = new SqlParameter("@Event_id", SqlDbType.Int);
                cmd.Parameters.Add(param4).Value = txt_Eventid.Text;
                int i = cmd.ExecuteNonQuery();
                connection.Close();
                if (i != 0)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txt_EventName.Text = "";
                txt_EventDiscription.Text = "";
            }
            SqlCommand comme = new SqlCommand("select * from Event_tbl", connection);
            SqlDataAdapter d = new SqlDataAdapter(comme);
            DataTable dt = new DataTable();
            d.Fill(dt);
            Event_GridView.DataSource = dt;
            connection.Close();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            SqlConnection connection = EventCon.connect();
            try
            {
                SqlCommand cmd = new SqlCommand("Event_insert", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@Event_Name", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value = txt_EventName.Text;
                SqlParameter param2 = new SqlParameter("@Event_Discription", SqlDbType.VarChar);
                cmd.Parameters.Add(param2).Value = txt_EventDiscription.Text;
                SqlParameter param3 = new SqlParameter("@Event_Date", SqlDbType.Date);
                cmd.Parameters.Add(param3).Value = date_EventDate.Text;
                int i = cmd.ExecuteNonQuery();
                connection.Close();
                if (i != 0)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txt_EventName.Text = "";
                txt_EventDiscription.Text = "";
            }
            SqlCommand comme = new SqlCommand("select * from Event_tbl", connection);
            SqlDataAdapter d = new SqlDataAdapter(comme);
            DataTable dt = new DataTable();
            d.Fill(dt);
            Event_GridView.DataSource = dt;
            connection.Close();
        }

        private void Home_btn_Click_1(object sender, EventArgs e)
        {
            Index obj = new Index();
            obj.Show();
            this.Hide();
        }

        private void Btn_Students_Click(object sender, EventArgs e)
        {
           Student_Form obj = new Student_Form();
            obj.Show();
            this.Hide();
        }

        private void Btn_Teachers_Click(object sender, EventArgs e)
        {
            Teacher obj = new Teacher();
            obj.Show();
            this.Hide();
        }

        private void Btn_Library_Click(object sender, EventArgs e)
        {
            Library obj = new Library();
            obj.Show();
            this.Hide();
        }
    }
}

