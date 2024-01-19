using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Bezpieczenstwo
{
    /// <summary>
    /// Interaction logic for TrithemiusCipher.xaml
    /// </summary>
    public partial class TrithemiusCipher : Window
    {
        char[] alphabet = { 'a', 'ą', 'b', 'c', 'ć', 'd', 'e', 'ę', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'ł', 'm', 'n', 'ń', 'o', 'ó', 'p', 'q', 'r', 's', 'ś', 't', 'u', 'w', 'x', 'y', 'z', 'ź', 'ż' };

        public TrithemiusCipher()
        {
            InitializeComponent();
        }

        private void encryptButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder encrypted = new StringBuilder();
            string text = cipherText.Text;
            
            for(int i = 0; i < text.Length; i++)
            {
                int x = Array.IndexOf(alphabet, text[i]) + i;
                int z = alphabet.Length;
                while(x >= alphabet.Length)
                    x = x - alphabet.Length;
                encrypted.Append(alphabet[x]);
            }
            cipherText.Text = encrypted.ToString();
        }

        private void decipherButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder encrypted = new StringBuilder();
            string text = cipherText.Text;

            for (int i = 0; i < text.Length; i++)
            {
                int x = Array.IndexOf(alphabet, text[i]) - i;
                int z = alphabet.Length;
                while (x < 0)
                    x = x + alphabet.Length;
                encrypted.Append(alphabet[x]);
            }
            cipherText.Text = encrypted.ToString();
        }
    }
}
