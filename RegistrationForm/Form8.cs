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
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;

namespace RegistrationForm
{
    public partial class Form8 : Form
    {
        FileStream fs;
        public Form8()
        {
            InitializeComponent();
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(textBoxId.Text);
                string BookName = textBoxBook.Text;
                string Author = textBoxAuthor.Text;
                int Price = Convert.ToInt32(textBoxPrice.Text);
                fs = new FileStream(@"D:/TestFolder2/Book.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);

                bw.Write(Id);
                bw.Write(BookName);
                bw.Write(Author);
                bw.Write(Price);
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

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:/TestFolder2/Book.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                textBoxId.Text = br.ReadInt32().ToString();
                textBoxBook.Text = br.ReadString();
                textBoxAuthor.Text = br.ReadString();
                textBoxPrice.Text = br.ReadInt32().ToString();
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

        private void btnWriteBinary_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.Id = Convert.ToInt32(textBoxId.Text);
                book.BookName = textBoxBook.Text;
                book.Author = textBoxAuthor.Text;
                book.Price = Convert.ToInt32(textBoxPrice.Text);
                fs = new FileStream(@"D:/TestFolder2/Book", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, book);
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

        private void btnReadBinary_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                fs = new FileStream(@"D:/TestFolder2/Book", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                book = (Book)binary.Deserialize(fs);
                textBoxId.Text = book.Id.ToString();
                textBoxBook.Text = book.BookName;
                textBoxAuthor.Text = book.Author;
                textBoxPrice.Text = book.Price.ToString();
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

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.Id = Convert.ToInt32(textBoxId.Text);
                book.BookName = textBoxBook.Text;
                book.Author = textBoxAuthor.Text;
                book.Price = Convert.ToInt32(textBoxPrice.Text);
                fs = new FileStream(@"D:/TestFolder2/BookXml", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Book));
                xml.Serialize(fs, book);
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

        private void btnXmlRead_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                fs = new FileStream(@"D:/TestFolder2/BookXml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Book));
                book = (Book)xml.Deserialize(fs);
                textBoxId.Text = book.Id.ToString();
                textBoxBook.Text = book.BookName;
                textBoxAuthor.Text = book.Author;
                textBoxPrice.Text = book.Price.ToString();
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

        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.Id = Convert.ToInt32(textBoxId.Text);
                book.BookName = textBoxBook.Text;
                book.Author = textBoxAuthor.Text;
                book.Price = Convert.ToInt32(textBoxPrice.Text);
                fs = new FileStream(@"D:/TestFolder2/BookSoap", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, book);
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

        private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                fs = new FileStream(@"D:/TestFolder2/BookSoap", FileMode.Open, FileAccess.Read);
                SoapFormatter soap = new SoapFormatter();

                book = (Book)soap.Deserialize(fs);
                textBoxId.Text = book.Id.ToString();
                textBoxBook.Text = book.BookName;
                textBoxAuthor.Text = book.Author;
                textBoxPrice.Text = book.Price.ToString();
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

        private void btnJsonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.Id = Convert.ToInt32(textBoxId.Text);
                book.BookName = textBoxBook.Text;
                book.Author = textBoxAuthor.Text;
                book.Price = Convert.ToInt32(textBoxPrice.Text);
                fs = new FileStream(@"D:/TestFolder2/BookJson", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, book);
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

        private void btnJSonRead_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                fs = new FileStream(@"D:/TestFolder2/BookJson", FileMode.Open, FileAccess.Read);
                book = JsonSerializer.Deserialize<Book>(fs);
                textBoxId.Text = book.Id.ToString();
                textBoxBook.Text = book.Author;
                textBoxAuthor.Text = book.Author;
                textBoxPrice.Text = book.Price.ToString();

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
