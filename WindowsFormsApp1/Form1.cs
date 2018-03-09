using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace WindowsFormsApp1
{
    public partial class frmCryptography : Form
    {
        public frmCryptography()
        {
            InitializeComponent();
        }

        private void cboCipher_SelectedIndexChanged(object sender, EventArgs e)
        {
            // enables proper buttons and txtKey if neccesary
            if (cboCipher.SelectedIndex != -1)
            {
                btnEncrypt.Enabled = true;
                btnDecrpyt.Enabled = true;
                btnClear.Enabled = true;
                txtCipherText.Enabled = true;
                txtPlainText.Enabled = true;
                if (cboCipher.SelectedIndex == 1 || cboCipher.SelectedIndex == 2 || cboCipher.SelectedIndex == 4)
                {
                    txtKey.Enabled = true;
                }
            }

            if (cboCipher.SelectedIndex != 1 && cboCipher.SelectedIndex != 2 && cboCipher.SelectedIndex != 4)
            {
                txtKey.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clears form
            cboCipher.SelectedIndex = -1;
            txtCipherText.Text = null;
            txtPlainText.Text = null;
            btnDecrpyt.Enabled = false;
            btnEncrypt.Enabled = false;
            btnClear.Enabled = false;
            txtCipherText.Enabled = false;
            txtPlainText.Enabled = false;
            txtKey.Text = null;
            txtKey.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // make sure the user has entered a plain text message
            if (txtPlainText.Text != "" && txtPlainText.Text != " ")
            {
                int cipher = cboCipher.SelectedIndex;
                string plainText = txtPlainText.Text;
                string cipherText = null;

                // instantiate the class for the selected cipher, declare and assign value 
                // to a key variable if neccesary, call the encrypt method
                switch (cipher)
                {
                    case 0:
                        HashFunction hash = new HashFunction();

                        cipherText = hash.EncrpytHash(plainText);

                        break;

                    case 1:
                        Caesar caesar = new Caesar();
                        try
                        {
                            int cKey = Convert.ToInt32(txtKey.Text);

                            cipherText = caesar.EncrpytCaesar(plainText, cKey);
                        }
                        catch(FormatException)
                        {
                            // users must enter a numeric key
                            MessageBox.Show("Please enter a valid encryption key");
                        }
                        break;

                    case 2:
                        try { 
                            RailFence railFence = new RailFence();
                            int rKey = Convert.ToInt32(txtKey.Text);

                            cipherText = railFence.encryptRailFence(plainText, rKey);
                        }
                        catch (FormatException)
                        {
                            // users must enter a numeric key
                            MessageBox.Show("Please enter a valid encryption key");
                        }
                        break;

                    case 3:
                        Polybius polybius = new Polybius();

                        cipherText = polybius.encryptPoly(plainText);

                        break;

                    case 4:
                        try
                        { 
                            Gronsfeld gronsfeld = new Gronsfeld();
                            int gKey = Convert.ToInt32(txtKey.Text);

                            cipherText = gronsfeld.encryptGronsfeld(plainText, gKey);
                        }
                        catch (FormatException)
                        {
                            // users must enter a numeric key
                            MessageBox.Show("Please enter a valid encryption key");
                        }
                        break;

                    case 5:
                        FourSquare fourSquare = new FourSquare();

                        cipherText = fourSquare.encryptFourSquare(plainText);

                        break;
                }
                // ensure that the message was encrypted
                if (cipherText != null)
                {
                    txtCipherText.Text = cipherText;
                }
            }
            else
            {
                MessageBox.Show("Please enter a message to encrypt");
            }
        }

        private void btnDecrpyt_Click(object sender, EventArgs e)
        {
            // make sure the user has entered a cipher text message
            int cipher = cboCipher.SelectedIndex;
            int key = 0;
            string plainText = null;
            string cipherText = txtCipherText.Text;

            // instantiate the class for the selected cipher, declare and assign value 
            // to a key variable if neccesary, call the decrypt method
            switch (cipher)
            {
                case 0:
                    MessageBox.Show("Hash functions cannot be decrypted");

                    break;

                case 1:
                    try { 
                        Caesar dCaesar = new Caesar();
                        key = Convert.ToInt32(txtKey.Text);

                        plainText = dCaesar.EncrpytCaesar(cipherText, -key);
                    }
                    catch (FormatException)
                    {
                        // users must enter a numeric key
                        MessageBox.Show("Please enter a valid encryption key");
                    }
                    break;

                case 2:
                    try { 
                        RailFence dRailFence = new RailFence();
                        key = Convert.ToInt32(txtKey.Text);

                        plainText = dRailFence.decryptRailFence(cipherText, key);
                    }
                    catch (FormatException)
                    {
                        // users must enter a numeric key
                        MessageBox.Show("Please enter a valid encryption key");
                    }
                    break;

                case 3:
                    Polybius dPolybius = new Polybius();

                    plainText = dPolybius.decryptPoly(cipherText);

                    break;

                case 4:
                    try { 
                        Gronsfeld dGronsfeld = new Gronsfeld();
                        key = Convert.ToInt32(txtKey.Text);

                        plainText = dGronsfeld.encryptGronsfeld(cipherText, -key);
                    }
                    catch (FormatException)
                    {
                        // users must enter a numeric key
                        MessageBox.Show("Please enter a valid encryption key");
                    }
                    break;
            }

            // ensure that the message was decrypted
            if (cipherText != null)
            {
                txtPlainText.Text = plainText;
            }
        }

        private void mnuImportPlainText_Click(object sender, EventArgs e)
        {
            //allows user to select a text file and txtPlainText.Text is set to the text from
            //the file
            importFile(txtPlainText);
        }

        private void mnuImportCipherText_Click(object sender, EventArgs e)
        {
            //allows user to select a text file and txtCipherText.Text is set to the text from
            //the file
            importFile(txtCipherText);
        }

        private void mnuExportPlainText_Click(object sender, EventArgs e)
        {
            //allows the user to select a file and the value of txtPlainText.Text is written 
            //to the file
            exportFile(txtPlainText);
        }

        private void mnuExportCipherText_Click(object sender, EventArgs e)
        {
            //allows the user to select a file and the value of txtCipherText.Text is written 
            //to the file
            exportFile(txtCipherText);
        }

        private void importFile(RichTextBox textBox)
        {
            //set initial directory, filter
            openFile.InitialDirectory = "c:\\";
            openFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFile.FilterIndex = 0;
            //display OpenFileDialog, check if the user clicks okay
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //instantiate streamreader class
                StreamReader read = new StreamReader(openFile.FileName);
                //read the entire file and close it
                textBox.Text = read.ReadToEnd();
                read.Close();
            }
        }

        private void exportFile(RichTextBox textBox)
        {
            //set initial directory, filter
            openFile.InitialDirectory = "c:\\";
            openFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFile.FilterIndex = 0;
            //display OpenFileDialog, check if the user clicks okay
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(openFile.FileName);
                //write to file and close it
                write.Write(textBox.Text);
                write.Close();
            }

        }
    }
}
