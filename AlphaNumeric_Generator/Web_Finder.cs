using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Threading;

namespace AlphaNumeric_Generator
{
    public partial class AlpaNumeric_Generator
    {
        //https://www.dropbox.com/s/lqm6gvif6ss8zn9/d1.MP4?dl=0
        //https://www.dropbox.com/s/jztyc5moqr59g2u/d2.MP4?dl=0
        Thread Check;
        int lastchecked;
        string[] CurrentURL;
        string[] Testchar;
        public void Checker()
        {
            Testchar = Get_Link("Generated").Split('\n');

        }
        public void CheckLink()
        {
            URL = null;
            string Link = "https://www.dropbox.com/s/";
            Link += Testchar[lastchecked + 1];
            AddMsg("Set to: >" + Link + "<");
            Navi(Link);//Store link to Myurl //URL = Current URL After Navi
            Check = new Thread(() => {
            Wait:
                if (!loading)
                {
                    AddMsg(">" + URL + "<");
                    if (Myurl != URL)
                    { 
                        AddMsg("Working Link");
                        Get_Link("Working");
                        //LinkValue += Chars + " _____ ";// + Curl();
                        string[] Lines = LinkValue.Split('\n');
                        File.WriteAllLines(Working, Lines);
                    }
                    else
                    {
                        AddMsg("Empty Link");
                        Get_Link("Empty");
                        //LinkValue += Chars;
                        string[] Lines = LinkValue.Split('\n');
                        File.WriteAllLines(Empty, Lines);
                    }
                }
                else { goto Wait; }
            });
            Check.Start();
        }
        //
        string LinkValue;
        string[] Links;
        string filename;
        StreamReader Streamvalue;
        public String Get_Link(string type)
        {
            if (type == "Working")
            {
                filename = "Working_Link.txt";
                Streamvalue = new StreamReader(filename);
            }
            else if (type == "Empty")
            {
                filename = "Empty_Link.txt";
                Streamvalue = new StreamReader(filename);
            }
            else if (type == "Generated")
            {
                filename = "Generated.txt";
                Streamvalue = new StreamReader(filename);
            }
            else if (type == "Generated")
            {
                filename = "Generated_Backup.txt";
                Streamvalue = new StreamReader(filename);
            }
            //AddMsg("Accessing > " + filename);
            LinkValue = Streamvalue.ReadToEnd();
            Links = LinkValue.Split('\n');
            LinkValue = null;
            foreach (string link in Links)
            {
                LinkValue += link + Environment.NewLine;
            }
            Streamvalue.Close();
            AddMsg(Date_Time("T") + " Initializing Generated.txt Complete..");
            return LinkValue;
        }
        //
//Random22_____Best Randomizer
        private static Random random = new Random();
        public static string Random22(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
//Randam11_____
        public String Random11(int length)
        {
            var chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[length];
            var random = new Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            string finalString = new string(stringChars);
            return finalString;
        }
//Random3_____
        string get_unique_string(int string_length)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                var bit_count = (string_length * 6);
                var byte_count = ((bit_count + 7) / 8); // rounded up
                var bytes = new byte[byte_count];
                rng.GetBytes(bytes);
                return Convert.ToBase64String(bytes);
            }
        }
    }
}
