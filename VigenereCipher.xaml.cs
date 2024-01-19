using System;
using System.Text;
using System.Windows;

namespace Bezpieczenstwo
{
    /// <summary>
    /// Interaction logic for TrithemiusCipher.xaml
    /// </summary>
    public partial class VigenereCipher : Window
    {
        readonly char[] alphabet = { 'a', 'ą', 'b', 'c', 'ć', 'd', 'e', 'ę', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'ł', 'm', 'n', 'ń', 'o', 'ó', 'p', 'q', 'r', 's', 'ś', 't', 'u', 'w', 'x', 'y', 'z', 'ź', 'ż' };

        public VigenereCipher() => InitializeComponent();

        private void EncryptButton_Click(object sender, RoutedEventArgs e)
        {
            string text = cipherText.Text;
            string key = keyText.Text;
            StringBuilder newText = new StringBuilder();
            try
            {
                for (int i = 0; i < text.Length; i++)
                {
                    int index = (Array.IndexOf(alphabet, key[i % key.Length]) + Array.IndexOf(alphabet, text[i])) % alphabet.Length;
                    newText.Append(alphabet[index]);
                }
                cipherText.Text = newText.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Wprowadź ciąg znaków z samymi małymi literami i spacjami oraz poprawnie wprowadzoną wartość klucza");
            }

        }

        private void DecipherButton_Click(object sender, RoutedEventArgs e)
        {
            string text = cipherText.Text;
            string key = keyText.Text;
            StringBuilder newText = new StringBuilder();

            try
            {
                for (int i = 0; i < text.Length; i++)
                {
                    int index = (Array.IndexOf(alphabet, text[i]) - Array.IndexOf(alphabet, key[i % key.Length]));
                    if (index < 0)
                        index += alphabet.Length;
                    newText.Append(alphabet[index]);
                }
                cipherText.Text = newText.ToString();
            }
            catch (Exception)
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
