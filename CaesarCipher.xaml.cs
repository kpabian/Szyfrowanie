using System;
using System.Text;
using System.Windows;

namespace Bezpieczenstwo
{
    public partial class CaesarCipher : Window
    {
        public char[] alphabet = { 'a', 'ą', 'b', 'c', 'ć', 'd', 'e', 'ę', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'ł', 'm', 'n', 'ń', 'o', 'ó', 'p', 'q', 'r', 's', 'ś', 't', 'u','v', 'w', 'x', 'y', 'z', 'ź', 'ż' };
        public CaesarCipher() => InitializeComponent();

        private void EncryptButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sipher = new StringBuilder();

            try
            {
                foreach (char c in textToBeEncrypted.Text)
                {
                    if (c == ' ')
                        sipher.Append(c);
                    else
                    {
                        int i = 0;
                        while (c != alphabet[i])
                            i++;

                        int charSipher = i + int.Parse(stepNumber.Text);
                        if (charSipher >= alphabet.Length)
                            charSipher = charSipher - alphabet.Length;

                        sipher.Append(alphabet[charSipher]);
                    }
                }
                textToBeEncrypted.Text = sipher.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Wprowadź ciąg znaków z samymi małymi literami i spacjami oraz poprawnie wprowadzoną wartość przesunięcia");
            }
        }

        private void DecipherButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sipher = new StringBuilder();
            try
            {
                foreach (char c in textToBeEncrypted.Text)
                {
                    int i = 0;
                    while (c != alphabet[i])
                        i++;

                    int charSipher = i - int.Parse(stepNumber.Text);
                    if (charSipher < 0)
                        charSipher = charSipher + alphabet.Length;

                    sipher.Append(alphabet[charSipher]);
                }
                textToBeEncrypted.Text = sipher.ToString();
            }
            catch( Exception )
            {
                MessageBox.Show("Wprowadź ciąg znaków z samymi małymi literami i spacjami oraz poprawnie wprowadzoną wartość przesunięcia");
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    
    }

}
