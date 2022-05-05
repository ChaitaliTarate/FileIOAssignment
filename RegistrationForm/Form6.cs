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
    public partial class Form6 : Form
    {
        FileStream fs;
        public Form6()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try 
            {
                int Eid = Convert.ToInt32(textBoxId.Text);
                string Ename = textBoxName.Text;
                string Designation = textBoxDesignation.Text;
                double salary = Convert.ToDouble(textBoxSalary.Text);
                string Department = textBoxDepartment.Text;

                fs = new FileStream(@"D:\TestFolder1\FirstFile.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Eid);
                bw.Write(Ename);
                bw.Write(Designation);
                bw.Write(salary);
                bw.Write(Department);
                bw.Close();
                MessageBox.Show("Done");

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

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\TestFolder1\FirstFile.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                textBoxId.Text = br.ReadInt32().ToString();
                textBoxName.Text = br.ReadString();
                textBoxDesignation.Text = br.ReadString();
                textBoxSalary.Text = br.ReadDouble().ToString();
               textBoxDepartment.Text = br.ReadString();
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
