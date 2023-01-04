using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string name = "";
        private void button1_Click(object sender, EventArgs e)
        {
            name = txtName.Text.Trim();
            msgShow();
        }

        public void msgShow()
        {
            MessageBox.Show(name);
        }

        public void show(string text)
        {
            MessageBox.Show(text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string name = txtName.Text.Trim();
            //show(name);
            myLoop(0,10);
        }

        public void myLoop(int start, int finsh)
        {
            
            show(start+"");
            start += 1;
            if (start <= finsh)
            {
                myLoop(start, finsh);
            }

        }

        public void WriteInFile()
        {
            StreamWriter sw = new StreamWriter("d:\\fileTest.txt",true);
            sw.WriteLine(txtName.Text.Trim());
            sw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WriteInFile();
        }

        public void ReadFromFile()
        {
            StreamReader sr = new StreamReader("d:\\fileTest.txt");
            txtNames.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReadFromFile();
        }
    }
    }
