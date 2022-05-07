using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace RegistrationForm
{
    public partial class Form7 : Form
    {
        FileStream fs;
        public Form7()
        {
            InitializeComponent();
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            try
            {
              string path = @"D:/TestFolder2";
                if(Directory.Exists(path))
                {
                    MessageBox.Show("Folder Already exist");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Created Successfully");
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
                string path = @"D:/TestFolder2/FirstFile.txt";
                if(File.Exists(path))
                {
                    MessageBox.Show("File Already Exist");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File Created Successfully");
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
                int Id = Convert.ToInt32(textBoxId.Text);
                string Name = textBoxName.Text;
                int Price = Convert.ToInt32(textBoxPrice.Text);
                string Category = textBoxCategory.Text;
                fs = new FileStream(@"D:/TestFolder2/FirstFile.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Id);
                bw.Write(Name);
                bw.Write(Price);
                bw.Write(Category);
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
                fs = new FileStream(@"D:\TestFolder2\FirstFile.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                textBoxId.Text = br.ReadInt32().ToString();
                textBoxName.Text = br.ReadString();
                textBoxPrice.Text = br.ReadInt32().ToString();
                textBoxCategory.Text = br.ReadString();
               
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

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product pro = new Product();
                pro.Id = Convert.ToInt32(textBoxId.Text);
                pro.Name = textBoxName.Text;
                pro.Price = Convert.ToInt32(textBoxPrice.Text);
                pro.Category = textBoxCategory.Text;
                fs = new FileStream(@"D:\TestFolder2\Product", FileMode.Create, FileAccess.ReadWrite);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs,pro);
                MessageBox.Show("Done");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                Product pro = new Product();
                fs = new FileStream(@"D:\TestFolder2\Product", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                pro = (Product)binary.Deserialize(fs);
                textBoxId.Text = pro.Id.ToString();
                textBoxName.Text = pro.Name;
                textBoxPrice.Text = pro.Price.ToString();
                textBoxCategory.Text = pro.Category;

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

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product pro = new Product();
                pro.Id = Convert.ToInt32(textBoxId.Text);
                pro.Name = textBoxName.Text;
                pro.Price = Convert.ToInt32(textBoxPrice.Text);
                pro.Category = textBoxCategory.Text;
                fs = new FileStream(@"D:\TestFolder2\ProductXml", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Product));
                xml.Serialize(fs, pro);
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

        private void btnXmlRead_Click(object sender, EventArgs e)
        {
            try
            {
                Product pro = new Product();
                fs = new FileStream(@"D:\TestFolder2\ProductXml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Product));
                pro = (Product)xml.Deserialize(fs);
                textBoxId.Text = pro.Id.ToString();
                textBoxName.Text = pro.Name;
                textBoxPrice.Text = pro.Price.ToString();
                textBoxCategory.Text = pro.Category;


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product pro = new Product();
                pro.Id = Convert.ToInt32(textBoxId.Text);
                pro.Name = textBoxName.Text;
                pro.Price = Convert.ToInt32(textBoxPrice.Text);
                pro.Category = textBoxCategory.Text;
                fs = new FileStream(@"D:/TestFolder2/ProductSoap", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, pro);
                MessageBox.Show("Done");


            }
            catch(Exception  ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try
            {
                Product pro = new Product();
                fs = new FileStream(@"D:/TestFolder2/ProductSoap", FileMode.Open, FileAccess.Read);
                SoapFormatter soap = new SoapFormatter();
                pro = (Product)soap.Deserialize(fs);
                textBoxId.Text = pro.Id.ToString();
                textBoxName.Text = pro.Name;
                textBoxPrice.Text = pro.Price.ToString();
                textBoxCategory.Text = pro.Category;
               
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

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product pro = new Product();
                pro.Id = Convert.ToInt32(textBoxId.Text);
                pro.Name = textBoxName.Text;
                pro.Price = Convert.ToInt32(textBoxPrice.Text);
                pro.Category = textBoxCategory.Text;
                fs = new FileStream(@"D:/TestFolder2/ProductJson", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, pro);
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

        private void btnJSONRead_Click(object sender, EventArgs e)
        {
            try
            {
                Product pro = new Product();
                fs = new FileStream(@"D:/TestFolder2/ProductJson", FileMode.Open, FileAccess.Read);
                pro=JsonSerializer.Deserialize<Product>(fs);

                textBoxId.Text = pro.Id.ToString();
                textBoxName.Text = pro.Name;
                textBoxPrice.Text = pro.Price.ToString();
                textBoxCategory.Text = pro.Category;
               
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
