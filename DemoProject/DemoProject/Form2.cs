using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Drawing;

namespace DemoProject
{
    public partial class Form2 : Form
    {

        Form1 f1;
        Form3 f3;
      

        public Form2(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
          
           
        }
        AllChars chars = new AllChars();
        private int i = 0;
        string[] nums = { "0 ", "1 apples", "2 apples", "3 apples", "4 apples", "5 apples", "6 apples", "7 apples", "8 apples", "9 apples" };
        string[] bang = { "অ", "আ", "ই", "ঈ", "উ", "ঊ", "ঋ", "এ", "ঐ", "ও", "ঔ", "ৠ", "ক", "খ", "গ", "ঘ", "ঙ", "চ", "ছ", "জ", "ঝ", "ঞ", "ট", "ঠ", "ড", "ঢ", "ণ", "ত", "থ", "দ", "ধ", "ন", "প", "ফ", "ব", "ভ", "ম", "য", "র", "ল", "শ", "ষ", "স", "হ", "ড়", "ঢ়", "য়", "ৎ", "ং", "ঃ", "ঁ" };
        string[] shon = { "0", "১", "২", "৩", "৪", "৫", "৬", "৭", "৮", "৯" };
        /*  string[] chars = { "A", "B", "C", "D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T",
              "U","V","W","X","Y","Z"};*/
        Boolean workingChar = false, workingNums = false, workingBang = false, workingShon = false;


        private void Alphabet_Click(object sender, EventArgs e)
        {
            i = 0;
            this.TextChar.Text = chars.CharList[i].Character;
            this.pictureBox1.Image = chars.CharList[i].image;
            SoundPlayer s = chars.CharList[i].sound;
            if (audio.Checked == true)

                s.Play();
            this. panel1.Visible = true;
            workingChar = true;
            workingBang = false;
            workingShon = false;
            workingNums = false;

        }

        private void Next_Click(object sender, EventArgs e)
        {
            if(workingChar && i<25)
            {
                i++;
                this.TextChar.Text = chars.CharList[i].Character;
                this.pictureBox1.Image = chars.CharList[i].image;
                SoundPlayer s = chars.CharList[i].sound;
                if (audio.Checked == true)

                    s.Play();
            }
                else if (workingNums && i<9)
            {
                i++;
                this.TextChar.Text = chars.NumList[i].Character;
                this.pictureBox1.Image = chars.NumList[i].image;
                SoundPlayer s = chars.NumList[i].sound;
                if (audio.Checked == true)

                    s.Play();
            }
            else if (workingBang && i < 49)
            {
                i++;
                this.TextChar.Text = chars.BanList[i].Character;
                this.pictureBox1.Image = chars.BanList[i].image;
                SoundPlayer s = chars.BanList[i].sound;
                if (audio.Checked == true)

                    s.Play(); ;
            }
            else if (workingShon && i < 9)
            {
                i++;
                this.TextChar.Text = chars.ShonList[i].Character;
                this.pictureBox1.Image = chars.ShonList[i].image;
                SoundPlayer s = chars.ShonList[i].sound;
                if (audio.Checked == true)

                    s.Play();
            }
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (workingChar && i > 0)
            {
                i--;
                this.TextChar.Text = chars.CharList[i].Character;
                this.pictureBox1.Image = chars.CharList[i].image;
                SoundPlayer s = chars.CharList[i].sound;
                if (audio.Checked == true)

                    s.Play();
            }
               else if (workingNums && i > 0)
               {
                i--;
                this.TextChar.Text = chars.NumList[i].Character;
                this.pictureBox1.Image = chars.NumList[i].image;
                SoundPlayer s = chars.NumList[i].sound;
                if (audio.Checked == true)

                    s.Play();
            }
                   else if (workingBang && i > 0)
                   {
                      
                i--;
                this.TextChar.Text = chars.BanList[i].Character;
                this.pictureBox1.Image = chars.BanList[i].image;
                SoundPlayer s = chars.BanList[i].sound;
                s.Play();
                   }
                   else if (workingShon && i > 0)
                   {
                i--;
                this.TextChar.Text = chars.ShonList[i].Character;
                this.pictureBox1.Image = chars.ShonList[i].image;
                SoundPlayer s = chars.ShonList[i].sound;
                if(audio.Checked==true)
                
                s.Play();
            }
        }

        private void audio_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void blackboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            f3 = new Form3(f1, this);
            f3.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TextChar_Click(object sender, EventArgs e)
        {

        }

        private void Digit_Click(object sender, EventArgs e)
        {
            i = 0;
            this.TextChar.Text = chars.NumList[i].Character;
            this.pictureBox1.Image = chars.NumList[i].image;
            SoundPlayer s = chars.NumList[i].sound;
            if (audio.Checked == true)

                s.Play();
            this.panel1.Visible = true;
            workingChar = false;
            workingBang = false;
            workingShon = false;
            workingNums = true;
        }

        private void Bangla_Click(object sender, EventArgs e)
        {
            i = 0;
            this.TextChar.Text = chars.BanList[i].Character;
            this.pictureBox1.Image = chars.BanList[i].image;
            SoundPlayer s = chars.BanList[i].sound;
            if (audio.Checked == true)

                s.Play();
            this.panel1.Visible = true;
            workingChar = false;
            workingBang = true;
            workingShon = false;
            workingNums = false;
        }

        private void Shonkha_Click(object sender, EventArgs e)
        {
            i = 0;
            this.TextChar.Text = chars.ShonList[i].Character;
            this.pictureBox1.Image = chars.ShonList[i].image;
            SoundPlayer s = chars.ShonList[i].sound;

            if (audio.Checked == true)

                s.Play();
            this.panel1.Visible = true;
            workingChar = false;
            workingBang = false;
            workingShon = true;
            workingNums = false;
        }
    }
}
