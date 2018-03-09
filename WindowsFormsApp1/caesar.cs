using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Caesar
    {
        string eText = null;

        public string EncrpytCaesar(string plainText, int key)
        {
            string cipherText = null;
            bool lowercase = false;
            string cipherChar = null;
            char[] plainTextArray = plainText.ToCharArray();

            // for each character call encryption method
            foreach (char x in plainTextArray)
            {
                cipherText = encryption(x, lowercase, cipherChar, key);
            }

            return cipherText;
        }

        public string encryption(char __plainText, bool __lowercase, string __cipherChar, int __key)
        {
            // alphabet string
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789~`!@#$%^&*()-+=_[]{}|\\/;:\"\'?.,<> ";

            // if the letter is lowercase designate it as such
            if (__plainText.ToString() == __plainText.ToString().ToLower())
            {
                __lowercase = true;
            }

            //get the position of the character in the alphabet string and use that as the 
            //number of characters to move, if the number is greater than the length of the 
            //alphabet string start back at the beginning
            int letterNum = alpha.IndexOf(__plainText.ToString().ToUpper());
            int moveDistance = (letterNum + __key) % alpha.Length;

            //get cipher character 
            __cipherChar = alpha.Substring(moveDistance, 1);

            //if the plain text character was lowercase, make the cipher text character 
            //lowercase
            if (__lowercase)
            {
                __cipherChar = __cipherChar.ToLower();
            }

            eText += __cipherChar;

            return eText;
        }

    }
}
