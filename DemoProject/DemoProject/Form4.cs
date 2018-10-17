using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProject
{
    public partial class Form4 : Form
    {
       // Form4 f4;
        Form3 f3;
        public Form4(Form3 f3)
        {
            InitializeComponent();
           
        }
        Form5 f5;

        private void button1_Click(object sender, EventArgs e)
        {

        }
        int Score = 0;
        int i;

        private void next_Click(object sender, EventArgs e)
        {


            if (radioButton1.Checked)
            {
                Score++;
                i++;
                //if(i!=1)
                if (i == 1)
                {
                    this.label1.Text = "T for Tiger";
                  
                }
                else if (i == 2)
                {
                    this.label1.Text = "Z for zebra";
                }
                else if (i == 3)
                {
                    this.label1.Text = "S for Six";
                }
                else if (i == 5)
                {
                    this.label1.Text = "D for dog";
                }

                else
                {
                    MessageBox.Show("u got 5 marks,good job kiddo!!");
                    f5 = new Form5(this);
                    this.Hide();
                    f5.Show();
                }
            }

            else if (radioButton2.Checked)
            {

                MessageBox.Show("oops!!wrong answer,kiddo :(");
            }

            }
            

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}
