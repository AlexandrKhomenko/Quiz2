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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            File.Delete("C:\\Users\\1895609\\Desktop\\C#\\Users.txt");
            MessageBox.Show("Delete file");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearForm_Click(object sender, EventArgs e)
        {
            firstName.Text = String.Empty;
            lastName.Text = String.Empty;
            phone.Text = String.Empty;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream("C:\\Users\\1895609\\Desktop\\C#\\Users.txt", FileMode. Append);
            //TextWriter txt = new StreamWriter(stream);

            using (StreamWriter writer =  new StreamWriter(stream))
            {
                writer.Write("\n First Name: " + firstName.Text);
                writer.Write(" Last Name: " + lastName.Text);
                writer.Write(" Phone number: " + phone.Text);
            }

            MessageBox.Show("User added");
        }
    }
}
