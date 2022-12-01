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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
            TableRefresh();
        }
        DBConnection LibraryCon = new DBConnection();

        public void TextClear()
        {
            txt_address.Text = "";
            txt_basicpay.Text = "";
            txt_designation.Text = "";
            txt_email.Text = "";
            txt_fullname.Text = "";
            txt_phone.Text = "";
            txt_staffid.Text = "";
            txt_searchteacher.Text = "";
        }
        public void TableRefresh()
        {
            SqlConnection connection = LibraryCon.connect();
            SqlCommand cmd = new SqlCommand("select * from Staff_tbl where Full_name like '%" + txt_searchteacher.Text + "%'", connection);
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d.Fill(dt);
            txt_dataGrid.DataSource = dt;
            connection.Close();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            SqlConnection connection = LibraryCon.connect();
            try
            {
                SqlCommand cmd = new SqlCommand("Staff_tbl_Insert", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@Full_name", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value = txt_fullname.Text;
                SqlParameter param2 = new SqlParameter("@Phone_no", SqlDbType.Int);
                cmd.Parameters.Add(param2).Value = txt_phone.Text;
                SqlParameter param3 = new SqlParameter("@Staff_Address", SqlDbType.VarChar);
                cmd.Parameters.Add(param3).Value = txt_address.Text;
                SqlParameter param4 = new SqlParameter("@Basic_pay", SqlDbType.Int);
                cmd.Parameters.Add(param4).Value = txt_basicpay.Text;
                SqlParameter param5 = new SqlParameter("@Designation", SqlDbType.VarChar);
                cmd.Parameters.Add(param5).Value = txt_designation.Text;
                SqlParameter param6 = new SqlParameter("@Email", SqlDbType.VarChar);
                cmd.Parameters.Add(param6).Value = txt_email.Text;
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("executed successfully...");
                }
                else
                {
                    MessageBox.Show("some thing wrong happen try again later....");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                TextClear();
                TableRefresh();
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = LibraryCon.connect();
            try
            {


                SqlCommand cmd = new SqlCommand("Staff_tbl_update", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@Full_name", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value = txt_fullname.Text;
                SqlParameter param2 = new SqlParameter("@Phone_no", SqlDbType.Int);
                cmd.Parameters.Add(param2).Value = txt_phone.Text;
                SqlParameter param3 = new SqlParameter("@Staff_Address", SqlDbType.VarChar);
                cmd.Parameters.Add(param3).Value = txt_address.Text;
                SqlParameter param4 = new SqlParameter("@Basic_pay", SqlDbType.Int);
                cmd.Parameters.Add(param4).Value = txt_basicpay.Text;
                SqlParameter param5 = new SqlParameter("@Designation", SqlDbType.VarChar);
                cmd.Parameters.Add(param5).Value = txt_designation.Text;
                SqlParameter param6 = new SqlParameter("@Email", SqlDbType.VarChar);
                cmd.Parameters.Add(param6).Value = txt_email.Text;
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("executed successfully...");
                }
                else
                {
                    MessageBox.Show("some thing wrong happen try again later....");

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
        private void delete_btn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = LibraryCon.connect();

            try
            {
                SqlCommand cmd = new SqlCommand("Staff_tbl_delete", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@Email", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value = txt_email.Text;
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("executed successfully...");
                }
                else
                {
                    MessageBox.Show("some thing wrong happen try again later....");
                    this.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Refresh();
            }
            finally
            {
                TextClear();
                TableRefresh();
            }
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = LibraryCon.connect();

                SqlCommand comme = new SqlCommand("select * from Staff_tbl", connection);
                SqlDataAdapter d = new SqlDataAdapter(comme);
                DataTable dt = new DataTable();
                d.Fill(dt);
                txt_dataGrid.DataSource = dt;
                connection.Close();
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

        private void txt_searchteacher_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                SqlConnection connection = LibraryCon.connect();
                SqlCommand cmd = new SqlCommand("select * from Staff_tbl where Full_name like '%"+txt_searchteacher.Text+"%'", connection);
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                d.Fill(dt);
                txt_dataGrid.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Students_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            obj.Show();
            this.Hide();
        }

        private void Btn_Library_Click(object sender, EventArgs e)
        {
            Library obj = new Library();
            obj.Show();
            this.Hide();
        }

        private void Btn_Events_Click(object sender, EventArgs e)
        {
            Events obj = new Events();
            obj.Show();
            this.Hide();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            Index obj = new Index();
            obj.Show();
            this.Hide();
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
    }
}
