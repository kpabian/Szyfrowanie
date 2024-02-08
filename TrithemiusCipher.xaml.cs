using System;
using System.Text;
using System.Windows;

namespace Bezpieczenstwo
{
    public partial class TrithemiusCipher : Window
    {
        private readonly char[] alphabet = { 'a', 'ą', 'b', 'c', 'ć', 'd', 'e', 'ę', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'ł', 'm', 'n', 'ń', 'o', 'ó', 'p', 'q', 'r', 's', 'ś', 't', 'u', 'w', 'x', 'y', 'z', 'ź', 'ż' };

        public TrithemiusCipher() => InitializeComponent();

        private void EncryptButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder encrypted = new StringBuilder();
            string text = cipherText.Text;
            try
            {
                for (int i = 0; i < text.Length; i++)
                {
                    int index = Array.IndexOf(alphabet, text[i]) + i;
                    while (index >= alphabet.Length)
                        index -= alphabet.Length;
                    encrypted.Append(alphabet[index]);
                }
                cipherText.Text = encrypted.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Wprowadź ciąg znaków z samymi małymi literami i spacjami");
            }
        }

        private void DecipherButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder encrypted = new StringBuilder();
            string text = cipherText.Text;

            try
            {
                for (int i = 0; i < text.Length; i++)
                {
                    int index = Array.IndexOf(alphabet, text[i]) - i;
                    while (index < 0)
                        index += alphabet.Length;
                    encrypted.Append(alphabet[index]);
                }
                cipherText.Text = encrypted.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Wprowadź ciąg znaków z samymi małymi literami i spacjami");
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
