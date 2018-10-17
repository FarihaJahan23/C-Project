using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DemoProject
{
    public partial class Form1 : Form
    {
        Form2 f2;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void UserNameText_TextChanged(object sender, EventArgs e)
        {

        }
      ///  connetionString = "Data Source=DESKTOP-GFHHCHP\\SQLEXPRESS;Initial Catalog=\"Fariha's School\";Persist Security Info=True;User ID=sa;Password=12345";
        private void LoginButton_Click(object sender, EventArgs e)
        {


            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=DESKTOP-L8BM0QI\\SQLEXPRESS;Initial Catalog=\"Fariha's School\";Persist Security Info=True;User ID=sa;Password=12345";
                //Data Source=DESKTOP-GFHHCHP\\SQLEXPRESS;Initial Catalog=\"Fariha's School\";Persist Security Info=True;User ID=sa;Password=12345"
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
               // MessageBox.Show("Connection Open ! ");
                string sql = null;
                sql = "Select * from Login";
                SqlDataReader dataReader;
                SqlCommand command;
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                bool milse = false;
               while(dataReader.Read())
                {
                    if(dataReader.GetValue(0).Equals( this.UserIdText.Text))
                    {
                        milse = true;
                        if(dataReader.GetValue(1).Equals(this.PasswordText.Text))
                          {
                            f2 = new Form2(this);
                            f2.Show();
                            this.Hide();
                            break;
                        }
                        else
                            MessageBox.Show("Wrong Password");
                    }
                }
               if(milse== false ) MessageBox.Show("Wrong User ID");
                dataReader.Close();
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! "+ex);
            }
            
        }

       
    

    

        private void UserNameText_KeyUp(object sender, KeyEventArgs e)
        {
    if(UserIdText.Text==null || UserIdText.Text=="")
            {
                UserIdText.Text = "userid";
                UserIdText.ForeColor = Color.Gray;
            }
        }

        private void UserNameText_KeyDown(object sender, KeyEventArgs e)
        {
            if(UserIdText.Text=="userid")
            {
                UserIdText.Text = "";
                UserIdText.ForeColor = Color.Black;
            }
        }

        private void PasswordText_KeyUp(object sender, KeyEventArgs e)
        {
            if (PasswordText.Text == null || PasswordText.Text == "")
            {
                PasswordText.Text = " Password";
                PasswordText.PasswordChar = '\0';
                PasswordText.ForeColor = Color.Gray;
            }
        }

        private void PasswordText_KeyDown(object sender, KeyEventArgs e)
        {
            if (PasswordText.Text == " Password")
            {
                PasswordText.Text = "";
                PasswordText.PasswordChar = '*';
                PasswordText.ForeColor = Color.Black;
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignIn_Click(object sender, EventArgs e)
        {

            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=DESKTOP-L8BM0QI\\SQLEXPRESS;Initial Catalog=\"Fariha's School\";Persist Security Info=True;User ID=sa;Password=12345";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                // MessageBox.Show("Connection Open ! ");
                string sql = null;
                sql = "insert into Login (UserId,Password) values('"+this.UserIdText.Text+"','"+this.PasswordText.Text+"');";
                SqlDataReader dataReader;
                SqlCommand command;
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                bool milse = false;
               while (dataReader.Read())
                {
                    if (dataReader.GetValue(0).Equals(this.UserIdText.Text))
                    {
                        milse = true;
                        if (dataReader.GetValue(1).Equals(this.PasswordText.Text))
                        {
                            f2 = new Form2(this);
                            f2.Show();
                            this.Hide();
                            break;
                        }
                        else
                            MessageBox.Show("Wrong Password" + dataReader.GetValue(1) + this.PasswordText.Text);
                    }
                }
             //   if (milse == false) MessageBox.Show("Wrong User ID");
                dataReader.Close();
                command.Dispose();
                cnn.Close();
                f2 = new Form2(this);
                f2.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
