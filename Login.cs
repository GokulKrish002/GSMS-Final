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
        Validate validate = new Validate();

        private void submit_btn_Click(object sender, EventArgs e)
        {
            bool inputMail, inputpwd;

            inputMail = validate.ValidateEmail(teacherid_txt.Text);
            inputpwd = validate.ValidateNumber(pwd_txt.Text);

            if (inputMail & inputpwd == false)
            {
                Error_Box obj = new Error_Box();
                obj.Show();
                this.Hide();
            }
            else
            {
                try
                {
                    SqlConnection connection = LoginCon.connect();
                    SqlCommand cmd = new SqlCommand("Staff_tbl_Search", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@Email", SqlDbType.VarChar);
                    cmd.Parameters.Add(param1).Value = teacherid_txt.Text;
                    SqlParameter param2 = new SqlParameter("@phone", SqlDbType.Int);
                    cmd.Parameters.Add(param2).Value = pwd_txt.Text;
                    int usercount = (Int32)cmd.ExecuteScalar();
                    connection.Close();
                    LoginCon.disconnect();
                    if (usercount == 1)
                    {
                        MessageBox.Show("Welcome");
                        Index obj = new Index();
                        obj.Show();
                        this.Hide();
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Type the correct Id/Pwd");
                        connection.Close();
                        Landing_app obj = new Landing_app();
                        obj.Show();
                        this.Hide();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Type the correct Id/Pwd");
                }
            }   
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
