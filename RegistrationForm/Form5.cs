using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RegistrationForm
{
    public partial class Form5 : Form
    {
        FileStream fs;
        public Form5()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                int Roll = Convert.ToInt32(textBoxRoll.Text);
                string Name = textBoxName.Text;
                double Per = Convert.ToDouble(textBoxPercentage.Text);
                string Stream = textBoxStream.Text;
                string City = textBoxCity.Text;

                FileStream fs = new FileStream(@"D:\TestFolder1\FirstFile.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Roll);
                bw.Write(Name);
                bw.Write(Per);
                bw.Write(Stream);
                bw.Write(City);
                bw.Close();
                MessageBox.Show("Done");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close(); 
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\TestFolder1\FirstFile.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                textBoxRoll.Text = br.ReadInt32().ToString();
                textBoxName.Text = br.ReadString();
                textBoxPercentage.Text = br.ReadDouble().ToString();
                textBoxStream.Text = br.ReadString();
                textBoxCity.Text = br.ReadString();
                br.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
