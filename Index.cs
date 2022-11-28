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

        private void Students_btn_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            obj.Show();
            this.Hide();
        }

        private void Library_btn_Click(object sender, EventArgs e)
        {
            Library obj = new Library();
            obj.Show();
            this.Hide();
        }

        private void Events_btn_Click(object sender, EventArgs e)
        {
            Events obj = new Events();
            obj.Show();
            this.Hide();
        }

        private void Teachers_btn_Click(object sender, EventArgs e)
        {
            Teacher obj = new Teacher();
            obj.Show();
            this.Hide();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Landing_app obj = new Landing_app();
            obj.Show();
            this.Hide();
        }
    }
}
