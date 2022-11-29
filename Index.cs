using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSMS
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Close_Timer.Start();
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

        private void Btn_Events_Click(object sender, EventArgs e)
        {
            Events obj = new Events();
            obj.Show();
            this.Hide();
        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void Close_Timer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.25;
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
