using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string log = File.ReadLines("doc1.txt").Skip(0).First();
                string pass = File.ReadLines("doc1.txt").Skip(1).First();
                
                if (textBox1.Text == log && textBox2.Text == pass)
                {
                    Form f = new Form2();
                    f.Show();
                }
                else
                {
                    Form f = new Form3();
                    f.Show();
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("no file");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
