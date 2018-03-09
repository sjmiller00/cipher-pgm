using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class HashFunction
    {

        public string EncrpytHash(string plainText)
        {
            string cipherText = plainText.GetHashCode().ToString();

            return cipherText;
        }

    }
}
