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
        Validation validate = new Validation();
        public Student()
        {
            InitializeComponent();
            RefreshTbl();
        }

        public void RefreshTbl()
        {
            SqlConnection connection = StudentCon.connect();
            try
            {
                SqlCommand cmd = new SqlCommand("Student_View", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                d.Fill(dt);
                Student_GridView.DataSource = dt;
                connection.Close();
            }
            catch(Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message);
            }
            
        }
        public void ClearTextBox()
        {
            Combo_BloodGrp.SelectedIndex = -1;
            txt_Mobile.Text = "";
            txt_Name.Text = "";
            Txt_Address.Text = "";
            Txt_Date.Text = "";
            Txt_Gender.SelectedIndex = -1;
            Txt_RollNo.Text = "";
            Combo_Section.SelectedIndex = -1; 
            Combo_Standrad.SelectedIndex = -1;
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            SqlConnection connection = StudentCon.connect();
            try
            {
                bool name, mobile, roll;
                name = validate.ValidateName(txt_Name.Text);
                mobile = validate.ValidateNumber(txt_Mobile.Text);
                roll = validate.ValidateNumber(Txt_RollNo.Text);

                if (name == false || txt_Name.Text == "")
                {
                    MessageBox.Show("Enter an valid Student Name !");
                }
                else if (roll == false || Txt_RollNo.Text == "")
                {
                    MessageBox.Show("Enter an valid Roll Number !");
                }
                else if (Txt_Gender.Text.Length < 6)
                {
                    MessageBox.Show("Enter an valid Address !");
                }
                else if (mobile == false || txt_Mobile.Text == "")
                {
                    MessageBox.Show("Enter an valid Mobile Number !");
                }
                else if (Combo_Standrad.Text.Length < 6)
                {
                    MessageBox.Show("Enter an valid Address !");
                }
                else if (Combo_Section.Text.Length < 6)
                {
                    MessageBox.Show("Enter an valid Address !");
                }
                else if (Txt_Address.Text.Length < 6)
                {
                    MessageBox.Show("Enter an valid Address !");
                }
                else if (Combo_BloodGrp.Text.Length < 6)
                {
                    MessageBox.Show("Enter an valid Address !");
                }
                else
                {
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
                        SqlParameter param5 = new SqlParameter("@Standard", SqlDbType.VarChar);
                        cmd.Parameters.Add(param5).Value = Combo_Standrad.Text;
                        SqlParameter param6 = new SqlParameter("@Section", SqlDbType.VarChar);
                        cmd.Parameters.Add(param6).Value = Combo_Section.Text;
                        SqlParameter param7 = new SqlParameter("@Address", SqlDbType.VarChar);
                        cmd.Parameters.Add(param7).Value = Txt_Address.Text;
                        SqlParameter param8 = new SqlParameter("@Blood_Group", SqlDbType.VarChar);
                        cmd.Parameters.Add(param8).Value = Combo_BloodGrp.Text;
                        int i = cmd.ExecuteNonQuery();
                        connection.Close();
                        if (i != 0)
                        {
                            MessageBox.Show("Inserted successfully");
                        }
                        else
                        {
                            MessageBox.Show("There is an problem while inserting");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        connection.Close();
                    }
                    finally
                    {
                        RefreshTbl();
                        ClearTextBox();
                        connection.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
            connection.Close();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            SqlConnection connection = StudentCon.connect();
            try
            {
                bool name, mobile, roll;
                name = validate.ValidateName(txt_Name.Text);
                mobile = validate.ValidateNumber(txt_Mobile.Text);
                roll = validate.ValidateNumber(Txt_RollNo.Text);

                if (name == false || txt_Name.Text == "")
                {
                    MessageBox.Show("Enter an valid Student Name !");
                }
                else if (roll == false || Txt_RollNo.Text == "")
                {
                    MessageBox.Show("Enter an valid Roll Number !");
                }
                else if (Txt_Gender.Text.Length < 6)
                {
                    MessageBox.Show("Enter an valid Gender !");
                }
                else if (mobile == false || txt_Mobile.Text == "")
                {
                    MessageBox.Show("Enter an valid Mobile Number !");
                }
                else if (Combo_Standrad.Text.Length < 6)
                {
                    MessageBox.Show("Enter an valid Standard !");
                }
                else if (Combo_Section.Text.Length < 6)
                {
                    MessageBox.Show("Enter an valid Section !");
                }
                else if (Txt_Address.Text.Length < 6)
                {
                    MessageBox.Show("Enter an valid Address !");
                }
                else if (Combo_BloodGrp.Text == null)
                {
                    MessageBox.Show("Enter an valid Blood Group !");
                }
                else
                {
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
                        cmd.Parameters.Add(param5).Value = Combo_Standrad.Text;
                        SqlParameter param6 = new SqlParameter("@Section", SqlDbType.Int);
                        cmd.Parameters.Add(param6).Value = Combo_Section.Text;
                        SqlParameter param7 = new SqlParameter("@Address", SqlDbType.VarChar);
                        cmd.Parameters.Add(param7).Value = Txt_Address.Text;
                        SqlParameter param8 = new SqlParameter("@Blood_Group", SqlDbType.VarChar);
                        cmd.Parameters.Add(param8).Value = Combo_BloodGrp.Text;
                        SqlParameter param10 = new SqlParameter("@Student_Roll", SqlDbType.Int);
                        cmd.Parameters.Add(param10).Value = Txt_RollNo.Text;
                        int i = cmd.ExecuteNonQuery();
                        connection.Close();
                        if (i != 0)
                        {
                            MessageBox.Show("Success");
                        }
                        else
                        {
                            MessageBox.Show("here is an problem while inserting");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        connection.Close();
                    }
                    finally
                    {
                        RefreshTbl();
                        ClearTextBox();
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = StudentCon.connect();
            try
            {
                SqlCommand cmd = new SqlCommand("Student_tbl_Delete",connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@Roll",SqlDbType.Int);
                cmd.Parameters.Add(param1).Value = Txt_RollNo.Text;
                int i = cmd.ExecuteNonQuery();
                connection.Close();
                if (i != 0)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("here is an problem while inserting");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("there is an server error :" + ex.Message);
                connection.Close();
            }
            finally
            {
                RefreshTbl();
                ClearTextBox();
                connection.Close();
            }
        }

        private void txt_searchteacher_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = StudentCon.connect();
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Student_tbl where Roll like '%"+txt_searchteacher.Text+"%'", connection);
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                d.Fill(dt);
                Student_GridView.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("wait there is an server error" + ex);
                connection.Close();
            }
        }


        private void Btn_Print_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_MarkList_Click(object sender, EventArgs e)
        {
            try
            {
                Student_Marklist obj = new Student_Marklist();
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
                Library anker = new Library();
                anker.Show();
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
                Events anker = new Events();
                anker.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
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

        private void btn_View_Click(object sender, EventArgs e)
        {
            RefreshTbl();
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

        private void Close_Timer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >= 0)
            {
                this.Opacity -= 0.7;
            }
            else
            {
                Application.Exit();
                Close_Timer.Stop();
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close_Timer.Start();
        }
    }
}

