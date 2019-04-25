using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarCipherWindowsForm
{
    public partial class CaesarForm : Form
    {
        public CaesarForm()
        {
            InitializeComponent();
        }

        private void CipherButton_Click(object sender, EventArgs e)
        {
            string originalMsg = inputTextBox.Text;
            int shiftBy = 0;
            try
            {
                shiftBy = Int32.Parse(shiftBox.Text);
            }
            catch (Exception)
            {
                shiftBy = 0; // Do nothing
            }
            encodedTextBox.Text = Encrypt(originalMsg.ToLower(), shiftBy);
        }

        private static string Encrypt(string words, int shiftNo)
        {
            char[] buffer = words.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                letter = (char)(letter + shiftNo);

                if (letter > 'z')
                {
                    letter = (char)(letter - 26);
                }
                else if (letter < 'a')
                {
                    letter = (char)(letter + 26);
                }

                buffer[i] = letter;
            }

            return new string(buffer);
        }
    }
}
