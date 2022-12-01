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
    public partial class Library : Form
    {
        DBConnection LibraryCon = new DBConnection();
        public Library()
        {
            InitializeComponent();
            TableRefresh();
        }

        public void TextClear()
        {
            txt_Author.Text = "";
            txt_Borrowed.Text = "";
            txt_GridLibrary.Text = "";
            txt_Name.Text = "";
            txt_Rack.Text = "";
            txt_Search.Text = "";
            txt_Shelves.Text = "";
        }
        public void TableRefresh()
        {
            try
            {
                SqlConnection connection = LibraryCon.connect();
                SqlCommand cmd = new SqlCommand("Library_View", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                d.Fill(dt);
                txt_GridLibrary.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            SqlConnection connection = LibraryCon.connect();
            try {
                SqlCommand cmd = new SqlCommand("Library_Insert", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@Book_Name", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value = txt_Name.Text;
                SqlParameter param2 = new SqlParameter("@Rack", SqlDbType.Int);
                cmd.Parameters.Add(param2).Value = Combo_Rack.Text;
                SqlParameter param3 = new SqlParameter("@Shelves", SqlDbType.Int);
                cmd.Parameters.Add(param3).Value = Combo_Shelves.Text;
                SqlParameter param4 = new SqlParameter("@Author", SqlDbType.VarChar);
                cmd.Parameters.Add(param4).Value = txt_Author.Text;
                SqlParameter param5 = new SqlParameter("@Borrowed_Books", SqlDbType.VarChar);
                cmd.Parameters.Add(param5).Value = txt_Borrowed.Text;
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("executed successfully...");
                }
                else
                {
                    MessageBox.Show("not working");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                TableRefresh();
                TextClear();
            }
            
        }

        private void txt_Search_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                SqlConnection connection = LibraryCon.connect();
                SqlCommand cmd = new SqlCommand("select * from Library_tbl where Book_Name like '%" + txt_Search.Text + "%'",connection);
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                d.Fill(dt);
                txt_GridLibrary.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            SqlConnection connection = LibraryCon.connect();
            try
            {
                SqlCommand cmd = new SqlCommand("Library_Update", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@Book_Name", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value = txt_Name.Text;
                SqlParameter param2 = new SqlParameter("@Rack", SqlDbType.Int);
                cmd.Parameters.Add(param2).Value = txt_Rack.Text;
                SqlParameter param3 = new SqlParameter("@Shelves", SqlDbType.Int);
                cmd.Parameters.Add(param3).Value = txt_Shelves.Text;
                SqlParameter param4 = new SqlParameter("@Author", SqlDbType.VarChar);
                cmd.Parameters.Add(param4).Value = txt_Author.Text;
                SqlParameter param5 = new SqlParameter("@Borrowed_Books", SqlDbType.VarChar);
                cmd.Parameters.Add(param5).Value = txt_Borrowed.Text;
                SqlParameter param6 = new SqlParameter("@Book_id", SqlDbType.Int);
                cmd.Parameters.Add(param6).Value = txt_BookId.Text;
                int i = cmd.ExecuteNonQuery();
                connection.Close();
                if (i != 0)
                {
                    MessageBox.Show("executed successfully...");
                }
                else
                {
                    MessageBox.Show("not working");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                TableRefresh();
                TextClear();
            }
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = LibraryCon.connect();
                SqlCommand cmd = new SqlCommand("Library_Delete", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@Book_Id", SqlDbType.Int);
                cmd.Parameters.Add(param1).Value = txt_Search.Text;
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("executed successfully...");
                }
                else
                {
                    MessageBox.Show("Not Working");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                TableRefresh();
                TextClear();
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

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void Btn_Events_Click(object sender, EventArgs e)
        {
            try
            {
                Events obj = new Events();
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

        private void view_btn_Click(object sender, EventArgs e)
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