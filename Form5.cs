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
    
    public partial class Form5 : Form
    {

        string x;
        public Form5()
        {
            InitializeComponent();
        }
        public Form5(string name)
        {
            InitializeComponent();
    ;
            x = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool found = true; 
            if (Password.Text.Length < 8 || Password.Text.Length > 20)
            {
                passerror.BringToFront();
                passerror.Text = "Password must be between 8 - 20 characters.";
                passerror.BackColor = Color.White;
                found = false;
            }
            var Pass2 = Password2.Text;
            if (Password.Text != Pass2)
            {
                matcherror.BringToFront();
                matcherror.Text = "Passwords do not match";
                matcherror.BackColor = Color.White;
                found = false;
            }
            if(found)
            {
                string y="";
                int i = 0;
                TextReader tr2 = new StreamReader("data.txt");
                while ((y = tr2.ReadLine()) != null)
                {
                    if(i==0)
                    { Console.WriteLine(x); }
                    if (i % 4 == 0)
                    {
                        if (y == x)
                        {
                            
                            break;
                        }
                    }
                    i++;


                }
                tr2.Close();
                int lenght = 0;
                TextReader tr3 = new StreamReader("data.txt");
                while ((y = tr3.ReadLine()) != null)
                {
                    lenght++;

                }
                tr3.Close();
                string[]arr=new string[lenght];
                int j = 0;
                TextReader tr4 = new StreamReader("data.txt");
                while ((y = tr4.ReadLine()) != null)
                {
                    arr[j++] = y;
                }
                tr4.Close();
                arr[++i] = Password.Text;
                StreamWriter sr=new StreamWriter("data.txt");
                for(int l=0;l<arr.Length;l++)
                {
                    sr.WriteLine(arr[l]);

                }
                sr.Close();
                Form2 form= new Form2();
                this.Hide();
                form.Show();









            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
