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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel1.Show();
            button1.BackColor = Color.Red;
            button2.BackColor= Color.Silver;
            panel1.Enabled = true;
            panel2.Enabled = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
       
            panel1.SendToBack();
            panel2.Show();
            panel2.BringToFront();
            button2.BackColor = Color.Red;
            button1.BackColor = Color.Silver;
            panel2.Enabled = true;
            panel1.Enabled = false;
            error1.BackColor= Color.Black;
            error2.BackColor = Color.Black;
           
            



        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            var password = Password.Text;
            var name = username.Text;
            var ques = question.Text;
            var ans = answer.Text;
            if(name.Length>0 && name.Length<=20)
            {
                string x = " ";
                if(name.Contains(x))
                {
                    error2.Text = "Username cant contain space";
                    error2.BackColor = Color.White;
                    error2.BringToFront();
                }
                else
                {
                    int i = 0;
                    TextReader tr=new StreamReader("data.txt");
                    bool found = true;
                    string y;
                   
                   while((y=tr.ReadLine())!=null)
                    {
                        if (i % 4 == 0)
                        {

                            Console.Write(y);
                            Console.WriteLine(i);
                            Console.WriteLine(name);
                            if (name == y)
                            {
                                error3.BringToFront();
                                error3.Text = "Username already taken";
                                error3.BackColor = Color.White;
                                found = false;
                                break;

                            }
                        }
                        i++;
                        
                    }
                    tr.Close();
                    if(Password.Text.Length<8|| Password.Text.Length>20)
                    {
                        passerror.BringToFront();
                        passerror.Text = "Password must be between 8 - 20 characters.";
                        passerror.BackColor = Color.White;
                        found = false;
                    }
                    var Pass2 = Password2.Text;
                    if(password!=Pass2)
                    {
                        matcherror.BringToFront();
                        matcherror.Text = "Passwords do not match";
                        matcherror.BackColor = Color.White;
                        found = false;
                    }
                    if (found)
                    {
                        StreamWriter sr = File.AppendText("data.txt");
                        sr.WriteLine(name);
                        sr.WriteLine(password);
                        sr.WriteLine(ques);
                        sr.WriteLine(ans);
                        sr.Close();
                        Form1 frm=new Form1();
                        this.Hide();
                        frm.Show();

                          
                    }
                   
                    
                }
            }
            else
            {
                error1.BringToFront();
                error1.Text = "Username must be between 3 - 20 characters.";
                error1.BackColor = Color.White;
                
            }

            


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            var pass = Pass.Text;
            var name = User.Text;
            TextReader tr = new StreamReader("data.txt");
            string y;
            string z;
            int i = 0;
            while((y=tr.ReadLine())!=null)
            {
                if (i % 4 == 0)
                {
                    z = tr.ReadLine();
                    i++;
                    if (y == name && z == pass)
                    {
                        Form3 frm = new Form3();
                        this.Hide();
                        frm.ShowDialog();

                    }
                    else
                    {
                        Invalid.Text = "Invalid credintials";
                        Invalid.BackColor = Color.White;
                    }
                }
                i++;
            }
            tr.Close();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            var name = User.Text;
           
            bool xs = false;
            TextReader tr = new StreamReader("data.txt");
            string y;
            int i = 0;
            while ((y = tr.ReadLine()) != null)
            {
                
                if (i % 4 == 0)
                {
                    if (y == name)
                    {
                        tr.ReadLine();
                        xs = true;
                        break;
                    }
                }


            }
            tr.Close();
            if(!xs)
            {
                
                
                    textBox1.Text = "User not found";
                    textBox1.BackColor = Color.White;
                
            }
            else
            {
                Form4 frm = new Form4(name);
                this.Hide();
                frm.ShowDialog();
            }






        }
    }
}
