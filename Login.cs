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

        private void submit_btn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = LoginCon.connect();

            try
            {
                SqlCommand cmd = new SqlCommand("Staff_tbl_Search", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@Email", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value = teacherid_txt.Text;
                SqlParameter param2 = new SqlParameter("@phone", SqlDbType.Int);
                cmd.Parameters.Add(param2).Value = pwd_txt.Text;
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
                    MessageBox.Show("Type the correct Id/Pwd");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }
    }
}
