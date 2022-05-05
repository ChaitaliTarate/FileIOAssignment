using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(textBoxId.Text=="admin" && textBoxPass.Text=="Pass@123")
            {
                MessageBox.Show("Successful");
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxId.Clear();
            textBoxPass.Clear();
        }
    }
}
