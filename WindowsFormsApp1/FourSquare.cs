using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class FourSquare
    {
        //declare three 2d arrays to use as tables
        //Two of the four tables used are identical, they represent the plain text pairs
        char[,] square1 = new char[5,5];
        char[,] square2 = new char[5, 5];
        char[,] square3 = new char[5, 5];

        public FourSquare()
        {
            // three different alphabet strings, each for a different table
            string alpha1 = "ABCDEFGHIJKLMNOPQRSTVWXYZ";
            string alpha2 = "SHIPXABCDEFGJKLMNOQRTVWYZ";
            string alpha3 = "AGMSZBFHLNRTYCEIKOQVXDJPW";

            // fills the tables
            fillTables(alpha1, square1);
            fillTables(alpha2, square2);
            fillTables(alpha3, square3);
        }

        private void fillTables(string alphabet, char[,] sqaure)
        {
            int letter = 0;

            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    sqaure[row, col] = Convert.ToChar(alphabet.Substring(letter, 1));
                    letter++;
                }
            }
        }

        public string encryptFourSquare(string plainText)
        {
            string cipherText = null;
            plainText = plainText.ToUpper();

            for (int letterPair = 0; letterPair < plainText.Length; letterPair += 2)
            {
                string letterPairOneCoords = findLetterCoords(square1, plainText, letterPair, 0);
                string letterPairTwoCoords = findLetterCoords(square1, plainText, letterPair, 1);


            }

                return cipherText;
        }

        private string findLetterCoords(char[,] _square, string message, int _letterPair, int letterPairNum)
        {
            string _letterCoords = null;

            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    if (_square[row, col] == Convert.ToChar(message.Substring(_letterPair, 2).Substring(_letterPair + letterPairNum, 1)))
                    {
                        _letterCoords = row.ToString() + "," + col.ToString();
                        col = 5;
                        row = 5;
                    }
                }
            }

            return _letterCoords;
        }
    }
}
