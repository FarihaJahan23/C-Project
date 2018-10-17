using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;

namespace DemoProject
{
    class AllChars
    {
       public List<Chars> CharList = new List<Chars>();
       public List<Borno> BanList = new List<Borno>();
       public List<Number> NumList = new List<Number>();
       public List<Shonkha> ShonList = new List<Shonkha>();

        string[] nums = { "0 ", "1", "2 ", "3 ", "4 ", "5 ", "6 ", "7", "8", "9" };
        string[] bang = { "অ", "আ", "ই", "ঈ", "উ", "ঊ", "ঋ", "এ", "ঐ", "ও", "ঔ",  "ক", "খ", "গ", "ঘ", "ঙ", "চ", "ছ", "জ", "ঝ", "ঞ", "ট", "ঠ", "ড", "ঢ", "ণ", "ত", "থ", "দ", "ধ", "ন", "প", "ফ", "ব", "ভ", "ম", "য", "র", "ল", "শ", "ষ", "স", "হ", "ড়", "ঢ়", "য়", "ৎ", "ং", "ঃ", "ঁ" };
        string[] shon = { "0", "১", "২", "৩", "৪", "৫", "৬", "৭", "৮", "৯" };
        string[] chars = { "A", "B", "C", "D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T",
              "U","V","W","X","Y","Z"};

        public AllChars()
        {
            //set Alphabets
            for(int i=0; i <=25;i++)
            {
                int j = i + 1;
                Image a = Image.FromFile("D:\\C#code\\DemoProject\\Rainy\\A" + j+ ".jpg");
                SoundPlayer s = new SoundPlayer("D:\\C#code\\DemoProject\\first\\A" + j+".wav");
                Chars c = new Chars(chars[i], s, a);
                CharList.Add(c);
            }
            //set borno
             for (int i = 0; i <50 ; i++)
            {
               int j = i + 1;
                
                
                    Image a = Image.FromFile("D:\\C#code\\DemoProject\\Rainy\\B" + j + ".jpg");
                    SoundPlayer s = new SoundPlayer(@"D:\C#code\DemoProject\last\b" + j + ".wav");
               
               
               
                Borno b = new Borno(bang[i], s, a);
                BanList.Add(b);
            }
            //set for Number
            for (int i = 0; i <=9; i++)
            {
                int j = i + 1;
                Image a = Image.FromFile("D:\\C#code\\DemoProject\\Rainy\\u" + j + ".jpg");
                
                SoundPlayer s = new SoundPlayer(@"D:\C#code\DemoProject\first\N" + j+ ".wav");
                Number n = new Number(nums[i], s, a);
                NumList.Add(n);
            }
            for (int i = 0; i <= 9; i++)
            {
                int j = i + 1;
                Image a = Image.FromFile("D:\\C#code\\DemoProject\\Rainy\\M" + j + ".jpg");
                SoundPlayer s = new SoundPlayer(@"D:\C#code\DemoProject\last\" + j+ ".wav");
                Shonkha so  = new Shonkha(shon[i], s, a);
                ShonList.Add(so);
            }
        }

    }
}
