using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intro
{
    public partial class Form4 : Form
    {
        string origname;
        public Form4()
        {
            InitializeComponent();
            
        }
        public Form4(string name)
        {
            InitializeComponent();
            string y;
            origname = name;    
            TextReader tr = new StreamReader("data.txt");
            int i = 0;
           
            while ((y = tr.ReadLine()) != null)
            {
                if (i % 4 == 0)
                {
                    if (y == name)
                    {
                        tr.ReadLine();
                        questions.Text = tr.ReadLine();
                        Console.WriteLine(i);
                        break;
                    }
                }
                i++;


            }
            tr.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string y;
            TextReader tr = new StreamReader("data.txt");
            int i = 0;
            string real_ans="";
            while ((y = tr.ReadLine()) != null)
            {
                if (i % 4 == 2)
                {
                    if (y==questions.Text)
                    {
                        real_ans=tr.ReadLine();
                        

                        break;
                        
                    }
                    

                }
                
                i++;


            }
            i = i - 2;
            tr.Close();
            int t = 0;
            string name="";
            TextReader tr2 = new StreamReader("data.txt");
            while ((y = tr2.ReadLine()) != null)
            {
                if (t == i)
                {
                    name = y;
                }


            }
            i = i - 2;
            tr2.Close();

            if (Ans.Text==real_ans)
            {
                Form5 frm=new Form5(origname);
                this.Hide();
                frm.ShowDialog();   
            }
            else
            {
                error.Text = "Wrong answer";
                error.BackColor = Color.White;
            }
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void questions_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
