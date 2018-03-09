using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Gronsfeld
    {

        public string encryptGronsfeld(string _plainText, int _key)
        {
            string cipherText = null;
            bool lowercase = false;
            string cipherChar = null;
            int letterNum = 0;

            // use algorithm from Caesar cipher because gronsfeld is just a modified caesar 
            // cipher
            Caesar modifiedCaesar = new Caesar();

            try
            {
                // loop through each digit within the key
                for (int x = 0; x < (_plainText.Length / Convert.ToInt32(Math.Abs(_key).ToString().Length)) + 1; x++)
                {
                    for (int y = 0; y < Convert.ToInt32(Math.Abs(_key).ToString().Substring(Math.Abs(_key).ToString().Length - 1)); y++)
                    {
                        // pass the character and the correspoinding number from the key to 
                        // Caesar.encryption
                        cipherText = modifiedCaesar.encryption(Convert.ToChar(_plainText.Substring(letterNum, 1)), lowercase, cipherChar, -Convert.ToInt32(Math.Abs(_key).ToString().Substring(y, 1)));
                        letterNum++;
                    }
                }
            }
            catch(Exception)
            {
                //lazy error handling
            }

            return cipherText;
        }

    }
}
