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
    public partial class Student : Form
    {
        DBConnection StudentCon = new DBConnection();
        public Student()
        {
            InitializeComponent();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            SqlConnection connection = StudentCon.connect();
            try
            {
                SqlCommand cmd = new SqlCommand("Student_tbl_insert", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@Name", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value = txt_Name.Text;
                SqlParameter param2 = new SqlParameter("@Roll", SqlDbType.Int);
                cmd.Parameters.Add(param2).Value = Txt_RollNo.Text;
                SqlParameter param3 = new SqlParameter("@Dob", SqlDbType.Date);
                cmd.Parameters.Add(param3).Value = Txt_Date.Text;
                SqlParameter param4 = new SqlParameter("@Gender", SqlDbType.VarChar);
                cmd.Parameters.Add(param4).Value = Txt_Gender.Text;
                SqlParameter param9 = new SqlParameter("@Mobile", SqlDbType.Int);
                cmd.Parameters.Add(param9).Value = txt_Mobile.Text;
                SqlParameter param5 = new SqlParameter("@Standard", SqlDbType.Int);
                cmd.Parameters.Add(param5).Value = Txt_Standrad.Text;
                SqlParameter param6 = new SqlParameter("@Section", SqlDbType.Int);
                cmd.Parameters.Add(param6).Value = Txt_Section.Text;
                SqlParameter param7 = new SqlParameter("@Address", SqlDbType.VarChar);
                cmd.Parameters.Add(param7).Value = Txt_Address.Text;
                SqlParameter param8 = new SqlParameter("@Blood_Group", SqlDbType.VarChar);
                cmd.Parameters.Add(param8).Value = txt_Blood_Group.Text;
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Success");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txt_Blood_Group.Text = "";
                txt_Mobile.Text = "";
                txt_Name.Text = "";
                Txt_Address.Text= "";
                Txt_Date.Text = "";
                Txt_Gender.Text = "";
                Txt_RollNo.Text = "";
                Txt_Section.Text = "";
                Txt_Standrad.Text = "";
            }
            SqlCommand comme = new SqlCommand("select * from Student_tbl", connection);
            SqlDataAdapter d = new SqlDataAdapter(comme);
            DataTable dt = new DataTable();
            d.Fill(dt);
            Student_GridView.DataSource = dt;
            connection.Close();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            SqlConnection connection = StudentCon.connect();
            try
            {
                SqlCommand cmd = new SqlCommand("Student_tbl_Update", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@Name", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value = txt_Name.Text;
                SqlParameter param2 = new SqlParameter("@Roll", SqlDbType.Int);
                cmd.Parameters.Add(param2).Value = Txt_RollNo.Text;
                SqlParameter param3 = new SqlParameter("@Dob", SqlDbType.Date);
                cmd.Parameters.Add(param3).Value = Txt_Date.Text;
                SqlParameter param4 = new SqlParameter("@Gender", SqlDbType.VarChar);
                cmd.Parameters.Add(param4).Value = Txt_Gender.Text;
                SqlParameter param9 = new SqlParameter("@Mobile", SqlDbType.Int);
                cmd.Parameters.Add(param9).Value = txt_Mobile.Text;
                SqlParameter param5 = new SqlParameter("@Standard", SqlDbType.Int);
                cmd.Parameters.Add(param5).Value = Txt_Standrad.Text;
                SqlParameter param6 = new SqlParameter("@Section", SqlDbType.Int);
                cmd.Parameters.Add(param6).Value = Txt_Section.Text;
                SqlParameter param7 = new SqlParameter("@Address", SqlDbType.VarChar);
                cmd.Parameters.Add(param7).Value = Txt_Address.Text;
                SqlParameter param8 = new SqlParameter("@Blood_Group", SqlDbType.VarChar);
                cmd.Parameters.Add(param8).Value = txt_Blood_Group.Text;
                SqlParameter param10 = new SqlParameter("@Student_Roll", SqlDbType.Int);
                cmd.Parameters.Add(param10).Value = Txt_RollNo.Text;
                int i = cmd.ExecuteNonQuery();
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
                txt_Blood_Group.Text = "";
                txt_Mobile.Text = "";
                txt_Name.Text = "";
                Txt_Address.Text = "";
                Txt_Date.Text = "";
                Txt_Gender.Text = "";
                Txt_RollNo.Text = "";
                Txt_Section.Text = "";
                Txt_Standrad.Text = "";
            }
            SqlCommand comme = new SqlCommand("select * from Student_tbl",connection);
            SqlDataAdapter d = new SqlDataAdapter(comme);
            DataTable dt = new DataTable();
            d.Fill(dt);
            Student_GridView.DataSource = dt;
            connection.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = StudentCon.connect();
            try
            {
                SqlCommand cmd = new SqlCommand("Student_tbl_Delete", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@Student_Roll", SqlDbType.Int);
                cmd.Parameters.Add(param1).Value = Txt_RollNo.Text;
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Failure");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txt_Blood_Group.Text = "";
                txt_Mobile.Text = "";
                txt_Name.Text = "";
                Txt_Address.Text = "";
                Txt_Date.Text = "";
                Txt_Gender.Text = "";
                Txt_RollNo.Text = "";
                Txt_Section.Text = "";
                Txt_Standrad.Text = "";
            }
            SqlCommand comme = new SqlCommand("select * from Student_tbl",connection);
            SqlDataAdapter d = new SqlDataAdapter(comme);
            DataTable dt = new DataTable();
            d.Fill(dt);
            Student_GridView.DataSource = dt;
            connection.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SqlConnection connection = StudentCon.connect();
            try
            {
                SqlCommand cmd = new SqlCommand("Student_tbl_Search", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@Student_Roll", SqlDbType.Int);
                cmd.Parameters.Add(param1).Value = Txt_RollNo.Text;
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Failure");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txt_Blood_Group.Text = "";
                txt_Mobile.Text = "";
                txt_Name.Text = "";
                Txt_Address.Text = "";
                Txt_Date.Text = "";
                Txt_Gender.Text = "";
                Txt_RollNo.Text = "";
                Txt_Section.Text = "";
                Txt_Standrad.Text = "";
            }
            SqlCommand comme = new SqlCommand("select * from Student_tbl",connection);
            SqlDataAdapter d = new SqlDataAdapter(comme);
            DataTable dt = new DataTable();
            d.Fill(dt);
            Student_GridView.DataSource = dt;
            connection.Close();
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            Student_GridView.SelectAll();
            DataObject copydata = Student_GridView.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object miseddata = System.Reflection.Missing.Value;
            xlWbook = xlapp.Workbooks.Add(miseddata);

            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();

            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void Btn_MarkList_Click(object sender, EventArgs e)
        {
            Student_Marklist obj = new Student_Marklist();
            obj.Show();
            this.Hide();
        }
        private void Btn_Students_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            obj.Show();
            this.Hide();
        }
        private void Home_btn_Click_1(object sender, EventArgs e)
        {
            Index anker = new Index();
            anker.Show();
            this.Hide();
        }

        private void Btn_Library_Click(object sender, EventArgs e)
        {
            Library anker = new Library();
            anker.Show();
            this.Hide();
        }

        private void Btn_Events_Click(object sender, EventArgs e)
        {
            Events anker = new Events();
            anker.Show();
            this.Hide();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Close_Timer.Start();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_Timer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.25;
            }
            else
            {
                Close_Timer.Stop();
                Application.Exit();
            }
        }
    }
}

