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
    public partial class Student_Marklist : Form
    {
        DBConnection StudentMarklistCon = new DBConnection();
        public Student_Marklist()
        {
            InitializeComponent();
        }

        public void TableRefresh()
        {
            SqlConnection connection = StudentMarklistCon.connect();
            SqlCommand comme = new SqlCommand("select * from StudentMarklist_tbl", connection);
            SqlDataAdapter da = new SqlDataAdapter(comme);
            DataTable dt = new DataTable();
            da.Fill(dt);
            StudentMarkGrid.DataSource = dt;
            connection.Close();
        }
        public void TextClean()
        {
            Name_Text.Text = "";
            Tamil_Text.Text = "";
            Eng_Text.Text = "";
            Maths_Text.Text = "";
            Science_Text.Text = "";
            Hindi_Text.Text = "";
            txt_ID.Text = "";
        }

        private void Student_Marklist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gsms_dbDataSet1.StudentMarklist_tbl' table. You can move, or remove it, as needed.
            //this.studentMarklist_tblTableAdapter.Fill(this.gsms_dbDataSet1.StudentMarklist_tbl);
            // TODO: This line of code loads data into the 'gsms_dbDataSet.Library_tbl' table. You can move, or remove it, as needed.
            //this.library_tblTableAdapter.Fill(this.gsms_dbDataSet.Library_tbl);
            // TODO: This line of code loads data into the 'gsmsDataSet1.stu_table2' table. You can move, or remove it, as needed.
        }
      


        private void Btn_Grade_Click(object sender, EventArgs e)
        {
            Double tamil, english, maths, science, socialscience, tot, avg;
            tamil = int.Parse(Tamil_Text.Text);
            english = int.Parse(Eng_Text.Text);
            maths = int.Parse(Maths_Text.Text);
            science = int.Parse(Science_Text.Text);
            socialscience = int.Parse(Hindi_Text.Text);

            tot = tamil + english + maths + science + socialscience;
            Total_Txt.Text = tot.ToString();

            avg = tot / 5;
            Avg_Txt.Text = avg.ToString();
            char grade = 'T';
            if (avg >= 85)
            {
                grade = 'A';
            }
            else if (avg >= 65)

            {
                grade = 'B';
            }
            else if (avg >= 45)

            {
                grade = 'C';
            }

            else if (avg >= 35)

            {
                grade = 'D';
            }
            Grade_Txt.Text = Convert.ToString(grade);
        }

        private void Btn_view_Click(object sender, EventArgs e)
        {
            TableRefresh();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = StudentMarklistCon.connect();
            try
            {
                SqlCommand cmd = new SqlCommand("StudentMarklist_Delete", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@Student_id", SqlDbType.Int);
                cmd.Parameters.Add(param1).Value = txt_ID.Text;
                int i = cmd.ExecuteNonQuery();
                connection.Close();
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
                TableRefresh();
                TextClean();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlConnection connection = StudentMarklistCon.connect();
            try
            {
                SqlCommand cmd = new SqlCommand("StudentMarklist_Update", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@name", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value = Name_Text.Text;
                SqlParameter param2 = new SqlParameter("@tamil", SqlDbType.Int);
                cmd.Parameters.Add(param2).Value = Tamil_Text.Text;
                SqlParameter param3 = new SqlParameter("@english", SqlDbType.Int);
                cmd.Parameters.Add(param3).Value = Eng_Text.Text;
                SqlParameter param4 = new SqlParameter("@maths", SqlDbType.Int);
                cmd.Parameters.Add(param4).Value = Maths_Text.Text;
                SqlParameter param5 = new SqlParameter("@science", SqlDbType.Int);
                cmd.Parameters.Add(param5).Value = Science_Text.Text;
                SqlParameter param6 = new SqlParameter("@hindi", SqlDbType.Int);
                cmd.Parameters.Add(param6).Value = Hindi_Text.Text;
                SqlParameter param7 = new SqlParameter("@Student_id", SqlDbType.Int);
                cmd.Parameters.Add(param7).Value = txt_ID.Text;
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("success");
                }
                else
                {
                    MessageBox.Show(" not success");
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                Name_Text.Text = "";
                Tamil_Text.Text = "";
                Eng_Text.Text = "";
                Maths_Text.Text = "";
                Science_Text.Text = "";
                Hindi_Text.Text = "";
                txt_ID.Text = "";
            }
            SqlCommand comme = new SqlCommand("select * from StudentMarklist_tbl", connection);
            SqlDataAdapter da = new SqlDataAdapter(comme);
            DataTable dt = new DataTable();
            da.Fill(dt);
            StudentMarkGrid.DataSource = dt;
            connection.Close();
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            StudentMarkGrid.SelectAll();
            DataObject copydata = StudentMarkGrid.GetClipboardContent();
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


        private void Btn_Home_Click(object sender, EventArgs e)
        {
            Index obj = new Index();
            obj.Show();
            this.Hide();
        }
        private void Btn_Students_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
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

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            SqlConnection connection = StudentMarklistCon.connect();
            try
            {

                SqlCommand cmd = new SqlCommand("StudentMarklist_Insert", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@name", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value = Name_Text.Text;
                SqlParameter param2 = new SqlParameter("@tamil", SqlDbType.Int);
                cmd.Parameters.Add(param2).Value = Tamil_Text.Text;
                SqlParameter param3 = new SqlParameter("@english", SqlDbType.Int);
                cmd.Parameters.Add(param3).Value = Eng_Text.Text;
                SqlParameter param4 = new SqlParameter("@maths", SqlDbType.Int);
                cmd.Parameters.Add(param4).Value = Maths_Text.Text;
                SqlParameter param5 = new SqlParameter("@science", SqlDbType.Int);
                cmd.Parameters.Add(param5).Value = Science_Text.Text;
                SqlParameter param6 = new SqlParameter("@hindi", SqlDbType.Int);
                cmd.Parameters.Add(param6).Value = Hindi_Text.Text;
                int i = cmd.ExecuteNonQuery();
                connection.Close();
                if (i != 0)
                {
                    MessageBox.Show("success");
                }
                else
                {
                    MessageBox.Show(" not success");
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                Name_Text.Text = "";
                Tamil_Text.Text = "";
                Eng_Text.Text = "";
                Maths_Text.Text = "";
                Science_Text.Text = "";
                Hindi_Text.Text = "";
                txt_ID.Text = "";
            }
            SqlCommand comme = new SqlCommand("select * from StudentMarklist_tbl", connection);
            SqlDataAdapter da = new SqlDataAdapter(comme);
            DataTable dt = new DataTable();
            da.Fill(dt);
            StudentMarkGrid.DataSource = dt;
            connection.Close();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Events_Click(object sender, EventArgs e)
        {
            Events obj = new Events();
            obj.Show();
            this.Hide();
        }
    }
}






     