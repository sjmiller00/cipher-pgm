using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Polybius
    {
        string[,] encryptionGrid = new string[5, 5];
        char[] alphaArray = null;

        public Polybius()
        {
            // 25 character alphabet, U > V
            string alpha = "ABCDEFGHIJKLMNOPQRSTVWXYZ";
            alphaArray = alpha.ToCharArray();
            int letter = 0;

            // create 5x5 alphabet table
            for (int row = 0; row < 5; row++)
            {
                for (int letterNum = 0; letterNum < 5; letterNum++)
                {
                    encryptionGrid[row, letterNum] = alphaArray[letter].ToString();
                    letter++;
                }
            }
        }

        public string encryptPoly(string _plainText) 
        {
            string cipherText = null;

            // convert entire string to uppercase, replace U with V
            _plainText = _plainText.ToUpper();
            _plainText = _plainText.Replace("U", "V");

            bool spaceConverted = false;

            // replace each letter with the corresponding row/col numbers, spaces replaced 
            // with - and place the cipher text for each letter in a scalar string
            foreach (char letterToSearchFor in _plainText)
            {
                spaceConverted = false;
                {
                    for(int row = 0; row < 5; row++)
                    {
                        for(int letterNum = 0; letterNum < 5; letterNum++)
                        {
                            if(letterToSearchFor.ToString() == " " && !spaceConverted)
                            {
                                cipherText += "- ";
                                spaceConverted = true;
                            }
                            else if (encryptionGrid[row, letterNum] == letterToSearchFor.ToString())
                            {
                                cipherText += row.ToString() + letterNum.ToString() + " ";
                            }
                        }
                    }
                }
            }
            
            return cipherText;
        }

        public string decryptPoly(string _cipherText)
        {
            string plainText = null;

            //cuts any extra spaces out of the cipher text
            _cipherText = _cipherText.Trim();

            //place the plain text in a scalar string 
            for (int letterNum = 0; letterNum <= _cipherText.Length; letterNum += 3)
            {
                if(letterNum > 0 && _cipherText.Substring(letterNum, 1) == "-")
                {
                    plainText += " ";
                    letterNum--;
                }
                else
                {
                    plainText += encryptionGrid[Convert.ToInt32(_cipherText.Substring(letterNum, 1)), Convert.ToInt32(_cipherText.Substring(letterNum + 1, 1))];
                }
            }

            return plainText;
        }

    }
}
