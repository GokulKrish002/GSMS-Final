using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSMS.App_Code;
using System.Data.SqlClient;

namespace GSMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        DBConnection LoginCon = new DBConnection();
        Validation validation = new Validation();
        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            Index obj = new Index();
            obj.Show();
            this.Hide();

            /*try
            {
                bool input1, input2;

                input1 = validation.ValidateEmail(txt_Email.Text);
                input2 = validation.ValidateNumber(txt_Password.Text);

                if (string.IsNullOrEmpty(txt_Email.Text))
                {

                    txt_Email.Focus();
                    MessageBox.Show("Please Enter Email ID");
                }
                else if (string.IsNullOrEmpty(txt_Password.Text))
                {
                    txt_Email.Focus();
                    MessageBox.Show("Please Enter password");
                }
                else if (input1 == false && input2 == false)
                {
                    txt_Email.Focus();
                    MessageBox.Show("Please Enter valid email/ password");
                }
                else
                {
                    try
                    {
                        SqlConnection connection = LoginCon.connect();
                        SqlCommand cmd = new SqlCommand("Staff_tbl_Search", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter param1 = new SqlParameter("@Email", SqlDbType.VarChar);
                        cmd.Parameters.Add(param1).Value = txt_Email.Text;
                        SqlParameter param2 = new SqlParameter("@phone", SqlDbType.Int);
                        cmd.Parameters.Add(param2).Value = txt_Password.Text;
                        int usercount = (Int32)cmd.ExecuteScalar();
                        connection.Close();
                        if (usercount == 1)
                        {
                            MessageBox.Show("Welcome");
                            Index obj = new Index();
                            obj.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Please enter the Valid Information !");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        Login obj = new Login();
                        obj.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error while converting your message " + ex);
            }*/

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

