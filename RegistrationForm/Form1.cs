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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
           /* MessageBox.Show(textName.Text);
            MessageBox.Show(textEmail.Text);
            MessageBox.Show(textContact.Text);
            MessageBox.Show(textAddress.Text);*/

            MessageBox.Show($"Name {textName.Text} \nEmail{textEmail.Text} \nContact no{textContact.Text} \n Adrress{textAddress.Text}");

            
        }       

        private void btnClear_Click(object sender, EventArgs e)
        {
            textName.Clear();
            textEmail.Clear();
            textContact.Clear();
            textAddress.Clear();
        }
    }
}
