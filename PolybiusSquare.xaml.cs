using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Bezpieczenstwo
{
    /// <summary>
    /// Interaction logic for PolybiusSquare.xaml
    /// </summary>
    public partial class PolybiusSquare : Window
    {
        public char[] alphabet = { 'a', 'ą', 'b', 'c', 'ć', 'd', 'e', 'ę', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'ł', 'm', 'n', 'ń', 'o', 'ó', 'p', 'q', 'r', 's', 'ś', 't', 'u', 'w', 'x', 'y', 'z', 'ź', 'ż' };
        Dictionary<char, string> cipher = new Dictionary<char, string>();

        public PolybiusSquare()
        {
            InitializeComponent();
        }

        private void randButton_Click(object sender, RoutedEventArgs e)
        {
            char[] alph = alphabet;
            Random random = new Random();

            int n = alph.Length;
            for (int i = n - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                char temp = alph[i];
                alph[i] = alph[j];
                alph[j] = temp;
            }

            List<TextBox> textboxList = new List<TextBox> { S22, S23, S24, S25, S26, S32, S33, S34, S35, S36, S42, S43, S44, S45, S46, S52, S53, S54, S55, S56, S62, S63, S64, S65, S66, S72, S73, S74, S75, S76, S82, S83, S84, S85, S86, };

            for (int i = 0; i < textboxList.Count; i++)
            {
                if (i < alph.Length)
                {
                    textboxList[i].Text = alph[i].ToString();
                }
            }
        }

        private void encryptButton_Click(object sender, RoutedEventArgs e)
        {
            List<TextBox> textboxList = new List<TextBox> { S22, S23, S24, S25, S26, S32, S33, S34, S35, S36, S42, S43, S44, S45, S46, S52, S53, S54, S55, S56, S62, S63, S64, S65, S66, S72, S73, S74, S75, S76, S82, S83, S84, S85, S86, };

            for (int i = 0; alphabet.Length < i; i++)
            {
                cipher.Add(alphabet[i], textboxList[i].Name);
            }



            StringBuilder newText = new StringBuilder();
            foreach (char c in cipherText.Text)
            {
                newText.Append(cipher[c]);
            }

            cipherText.Text = newText.ToString();

        }

        private void decipherButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
