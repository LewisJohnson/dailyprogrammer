using System.Collections.Generic;
using System.Text;
using System;

namespace Cipher
{
    public class Cipher
    {

        public string Encrypt(string text)
        {
            string value = "";
            var l = "";

            //Here you can define the scramble

            var Scrambbler = new Dictionary<char, string>(){
                { 'a' , "45546" },
                { 'b' , "4564387" },
                { 'c' , "4221201" },
                { 'd' , "1132131" },
                { 'e' , "012305" },
                { 'f' , "006" },
                { 'g' , "017107" },
                { 'h' , "008" },
                { 'i' , "0709" },
                { 'j' , "07810" },
                { 'k' , "711" },
                { 'l' , "01865722" },
                { 'm' , "013" },
                { 'n' , "0127785274" },
                { 'o' , "015" },
                { 'p' , "02121216" },
                { 'q' , "174171" },
                { 'r' , "1471171" },
                { 's' , "012121219" },
                { 't' , "020" },
                { 'u' , "17117" },
                { 'v' , "022" },
                { 'w' , "01717123" },
                { 'x' , "017124" },
                { 'y' , "17171" },
                { 'z' , "17171" },
            };

            foreach (char item in text)
            {
                if (Scrambbler.TryGetValue(item, out l))
                {
                    //You can also sperate with any Character
                    value += l + " ";
                }

            }

            return value;
        }

        public string EncryptWithEncoder(string text)
        {
            var TextBytes = Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(TextBytes);
        }

        public string DecryptWithEncoder(string text)
        {
            var EncodedBytes =Convert.FromBase64String(text);
            return Encoding.UTF8.GetString(EncodedBytes);
        }

    }
}
