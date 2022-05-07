using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Form9 : Form
    {
        FileStream fs;
        public Form9()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(textBoxId.Text);
                string Name = textBoxName.Text;
                string Startdate = textBoxStart.Text;
                string Enddate = textBoxEnd.Text;
                string Location = textBoxLocation.Text;
                string Trainer = textBoxTrainer.Text;
                fs = new FileStream(@"D:\TestFolder2\FirstFile1.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Id);
                bw.Write(Name);
                bw.Write(Startdate);
                bw.Write(Enddate);
                bw.Write(Location);
                bw.Write(Trainer);
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
            try {
                fs = new FileStream(@"D:\TestFolder2\FirstFile1.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                textBoxId.Text = br.ReadInt32().ToString();
                textBoxName.Text = br.ReadString();
                textBoxStart.Text = br.ReadString();
                textBoxEnd.Text = br.ReadString();
                textBoxLocation.Text = br.ReadString();
                textBoxTrainer.Text = br.ReadString();
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
