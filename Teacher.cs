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
        Validation validate = new Validation();

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
            try
            {
                SqlConnection connection = LibraryCon.connect();
                SqlCommand cmd = new SqlCommand("Staff_View", connection);
                cmd.CommandType = CommandType.StoredProcedure;
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

        private void btn_insert_Click(object sender, EventArgs e)
        {
            SqlConnection connection = LibraryCon.connect();
            bool phone,email;
            phone =validate.ValidateNumber(txt_phone.Text);
            email =validate.ValidateEmail(txt_email.Text);

            if (txt_staffid.Text == "")
            {
                MessageBox.Show("Please enter a valid Staff ID !");
            }
            else if (txt_fullname.Text.Length < 1)
            {
                MessageBox.Show("Please enter a valid Staff Name!");
            }
            else if (phone == false || txt_phone.Text.Length < 10)
            {
                MessageBox.Show("Please enter a valid Phone Number!");
            }
            else if (txt_address.Text.Length < 5)
            {
                MessageBox.Show("Please enter a valid Address!");
            }
            else if (txt_basicpay.Text.Length < 4)
            {
                MessageBox.Show("Please enter a valid Basic Pay !");
            }
            else if (txt_designation.Text.Length < 1)
            {
                MessageBox.Show("Please enter a valid Designation !");
            }
            else if (email == false || txt_email.Text.Length < 1)
            {
                MessageBox.Show("Please enter a valid Email !");
            }
            else
            {
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
                    connection.Close();
                    if (i != 0)
                    {
                        MessageBox.Show("executed successfully...");
                    }
                    else
                    {
                        MessageBox.Show("some thing wrong happen try again later....");
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
                finally
                {
                    TextClear();
                    TableRefresh();
                    connection.Close();
                }
            }
            connection.Close();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = LibraryCon.connect();
            bool phone, email, staffID, basic_Pay;
            phone = validate.ValidateNumber(txt_phone.Text);
            email = validate.ValidateEmail(txt_email.Text);
            staffID = validate.ValidateNumber(txt_staffid.Text);
            basic_Pay = validate.ValidateNumber(txt_basicpay.Text);

            if (txt_fullname.Text.Length < 5)
            {
                MessageBox.Show("Please enter a valid event Discription Name !");
            }
            else if (txt_fullname.Text.Length < 1)
            {
                MessageBox.Show("Please enter a valid Staff Name!");
            }
            else if (phone == false || txt_phone.Text.Length < 10)
            {
                MessageBox.Show("Please enter a valid Phone Number!");
            }
            else if (txt_address.Text.Length < 5)
            {
                MessageBox.Show("Please enter a valid Address!");
            }
            else if (basic_Pay == false || txt_basicpay.Text.Length < 4)
            {
                MessageBox.Show("Please enter a valid Basic Pay !");
            }
            else if (txt_designation.Text.Length < 1)
            {
                MessageBox.Show("Please enter a valid Designation !");
            }
            else if (email == false || txt_email.Text.Length < 1)
            {
                MessageBox.Show("Please enter a valid Email !");
            }
            else if (staffID == false  || txt_staffid.Text.Length < 1)
            {
                MessageBox.Show("Please enter a valid Staff ID !");
            }
            else
            {

                try
                {
                    connection.Open();
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
                    connection.Close();
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
                    connection.Close();
                }
                finally
                {
                    TextClear();
                    TableRefresh();
                    connection.Close();
                }
            }
            connection.Close();
        }
        private void delete_btn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = LibraryCon.connect();
            bool staffID;
            staffID = validate.ValidateNumber(txt_staffid.Text);
            if (staffID == false || txt_staffid.Text.Length < 1)
            {
                MessageBox.Show("Please enter a valid Staff ID !");
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Staff_tbl_delete", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@Email", SqlDbType.VarChar);
                    cmd.Parameters.Add(param1).Value = txt_email.Text;
                    int i = cmd.ExecuteNonQuery();
                    connection.Close();
                    if (i != 0)
                    {
                        MessageBox.Show("executed successfully...");
                    }
                    else
                    {
                        MessageBox.Show("some thing wrong happen try again later....");
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
                finally
                {
                    TextClear();
                    TableRefresh();
                    connection.Close();
                }
            }
            connection.Close();
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = LibraryCon.connect();

                SqlCommand comme = new SqlCommand("Staff_View", connection);
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
                SqlCommand cmd = new SqlCommand("select * from Staff_table where Full_name like '%"+txt_searchteacher.Text+"%'", connection);
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
