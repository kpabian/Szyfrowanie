using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Bezpieczenstwo
{
    public partial class PolybiusSquare : Window
    {
        private readonly char[] alphabet = { 'a', 'ą', 'b', 'c', 'ć', 'd', 'e', 'ę', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'ł', 'm', 'n', 'ń', 'o', 'ó', 'p', 'q', 'r', 's', 'ś', 't', 'u', 'w', 'x', 'y', 'z', 'ź', 'ż', ' ' };
        private readonly Dictionary<char, int> cipher = new Dictionary<char, int>();
        private readonly Random random = new Random();
        private List<TextBox> textboxList;

        public PolybiusSquare() => InitializeComponent();

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            textboxList = new List<TextBox> {S11, S12, S13, S14, S15, S21, S22, S23, S24, S25, S31, S32, S33, S34, S35, S41, S42, S43, S44, S45, S51, S52, S53, S54, S55, S61, S62, S63, S64, S65, S71, S72, S73, S74, S75, };
        }

        private void RandButton_Click(object sender, RoutedEventArgs e)
        {
            char[] alph = alphabet;

            int n = alph.Length;
            for (int i = n - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                (alph[j], alph[i]) = (alph[i], alph[j]);
            }


            for (int i = 0; i < textboxList.Count; i++)
            {
                if (i < alph.Length)
                    textboxList[i].Text = alph[i].ToString();
            }
        }

        private void EncryptButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder newText = new StringBuilder();
            cipher.Clear();
            for (int i = 0; alphabet.Length > i; i++)
            {
                cipher.Add(alphabet[i], int.Parse(textboxList[i].Name.Substring(1)));
            }
            try
            {
                for (int i = 0; i < cipherText.Text.Length; i++)
                {
                    int val = cipher.First(x => x.Key == cipherText.Text[i]).Value;
                    if (i % 2 != 0) val += 11;
                    newText.Append(val);
                }

                cipherText.Text = newText.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Wprowadź ciąg znaków z samymi małymi literami i spacjami oraz poprawnie wprowadzoną wartość przesunięcia");
            }
        }

        private void DecipherButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder newText = new StringBuilder();

            try
            {
                for (int i = 0; i < cipherText.Text.Length; i += 2)
                {
                    int val = int.Parse(cipherText.Text.Substring(i, 2));
                    if (i % 4 != 0) val -= 11;
                    char c = cipher.First(x => x.Value == val).Key;
                    newText.Append(c);
                }

                cipherText.Text = newText.ToString();
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