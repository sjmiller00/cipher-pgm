using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class RailFence
    {
        public string encryptRailFence(string _plainText, int _key)
        {
            string cipherText = null;
            int length = _plainText.Length;
            int iterations = length / _key;
            string[,] encryptionTable = new string[_key, length];
            int letter = 0;

            //place letters from plain text into an encryption table
            for (int i = 0; i < iterations; i++)
            {
                //descending letters
                for (int j = 0; j < _key; j++)
                {
                    if (letter != length)
                    {
                        encryptionTable[j, letter] = _plainText.Substring(letter, 1);
                        letter++;
                    }
                    else
                    {
                        j = _key;
                    }
                }

                // ascending letters
                for (int j = _key - 2; j > 0; j--)
                {
                    if (letter != length)
                    {
                        encryptionTable[j, letter] = _plainText.Substring(letter, 1);
                        letter++;
                    }
                    else
                    {
                        j = 0;
                    }
                }
            }
            
            // iterate through the table placing each letter into a scalar string
            for (int i = 0; i < _key; i++)
            {
                for (int j = 0; j < letter; j++)
                {
                    cipherText += encryptionTable[i, j];
                }
            }

            return cipherText;
        }

        public string decryptRailFence(string cipherText, int key)
        {
            string plainText = null;
            string[,] encryptionTable = new string[key, cipherText.Length];
            int letter = 0;

            // recreate encrption table, but replace each letter with an X
            for(int x = 0; x < cipherText.Length/key; x++)
            {
                //descending letters
                for(int row = 0; row < key; row++)
                {
                    addPlaceholder(encryptionTable, row, letter);
                    letter++;
                }

                // ascending letters
                for(int row = key - 2; row > 0; row--)
                {
                    addPlaceholder(encryptionTable, row, letter);
                    letter++;
                }
            }

            // replace each X with the corresponding letter from the cipher text
            letter = 0;
            for(int row = 0; row < key; row++)
            {
                for(int col = 0; col < cipherText.Length; col++)
                {
                    if(encryptionTable[row, col] == "X")
                    {
                        encryptionTable[row, col] = cipherText.Substring(letter, 1);
                        letter++;
                    }
                }
            }

            // iterate through the table and reorganize the letters into a scalar string
            letter = 0;
            for (int x = 0; x < cipherText.Length / key; x++)
            {
                // descending letters
                for (int row = 0; row < key; row++)
                {
                    plainText += readPlainText(encryptionTable, row, letter);
                    letter++;
                }

                //ascending letters
                for (int row = key - 2; row > 0; row--)
                {
                    plainText += readPlainText(encryptionTable, row, letter);
                    letter++;
                }
            }

            return plainText;
        }

        private void addPlaceholder(string[,] table, int _row, int _letter)
        {
            try
            {
                table[_row, _letter] = "X";
            }
            catch (IndexOutOfRangeException)
            {
                //lazy error handling
            }
        }

        private string readPlainText(string[,] _table, int _row_, int _letter_)
        {
            string _plainText = null;
            try
            {
                _plainText = _table[_row_, _letter_];
                return _plainText;
            }
            catch (IndexOutOfRangeException)
            {
                //lazy error handling
                return null;
            }
        }
    }
}
