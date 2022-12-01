﻿using System;
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
            TableRefresh();
        }
        DBConnection EventCon = new DBConnection();

        public void TableRefresh()
        {
            SqlConnection connection = EventCon.connect();
            SqlCommand cmd = new SqlCommand("Event_view", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d.Fill(dt);
            Event_GridView.DataSource = dt;
            connection.Close();
        }
        public void TextClear()
        {
            txt_EventName.Text = "";
            txt_EventDiscription.Text = "";
        }


        private void Btn_Delete_Click(object sender, EventArgs e)
        {
           
            try
            {
                SqlConnection connection = EventCon.connect();
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
                TextClear();
                TableRefresh();
            }
            
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection connection = EventCon.connect();
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
                TextClear();
                TableRefresh();
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection connection = EventCon.connect();
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
                TextClear();
                TableRefresh();
            }
        }

        private void Home_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                Index obj = new Index();
                obj.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Students_Click(object sender, EventArgs e)
        {
            try
            {
                Student obj = new Student();
                obj.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Teachers_Click(object sender, EventArgs e)
        {
            try
            {
                Teacher obj = new Teacher();
                obj.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Library_Click(object sender, EventArgs e)
        {
            try
            {
                Library obj = new Library();
                obj.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            try
            {
                Login obj = new Login();
                obj.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            TableRefresh();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close_Timer.Start();
        }

        private void Close_Timer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >= 0)
            {
                this.Opacity -= 0.7;
            }
            else
            {
                Close_Timer.Stop();
                Application.Exit();
            }
        }
    }
}

