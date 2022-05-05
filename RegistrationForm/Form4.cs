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
    public partial class Form4 : Form
    {
        FileStream fs;
        public Form4()
        {
            InitializeComponent();
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\TestFolder1";
               
                
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Folder already Exist");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Folder created");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\TestFolder1\FirstFile.txt";
                if (File.Exists(path))
                {
                    MessageBox.Show("File already exists");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File Created");
                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxId.Text);
                string name = textBoxName.Text;
                string location = textBoxLocation.Text;
                FileStream fs = new FileStream(@"D:\TestFolder1\FirstFile.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                //bw.Write(Convert.ToInt32(textBoxId.Text));
                bw.Write(id);
                bw.Write(name);
                bw.Write(location);
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
                textBoxId.Text = br.ReadInt32().ToString();
                textBoxName.Text = br.ReadString();
                textBoxLocation.Text = br.ReadString();
                br.Close();
            }
            catch (Exception ex)
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
