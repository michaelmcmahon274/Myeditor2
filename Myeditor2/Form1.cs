using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Myeditor2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                System.IO.StreamReader sr = new System.IO.StreamReader(path);
                RichTextBox1.Text = sr.ReadToEnd();
                sr.Close();

                //MessageBox.Show(path);



            }
    }

        private void BtnSave_Click(object sender, EventArgs e)
        {


            string path = openFileDialog1.FileName;
            System.IO.StreamWriter sw = new System.IO.StreamWriter(path);
            sw.WriteLine(RichTextBox1.Text);
            sw.Close();


        }    


            
    }   




}
