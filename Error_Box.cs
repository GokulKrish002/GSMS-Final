using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSMS.App_Code
{
    public partial class Error_Box : Form
    {
        public Error_Box()
        {
            InitializeComponent();
        }

        private void Error_click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Close();
        }
    }
}
