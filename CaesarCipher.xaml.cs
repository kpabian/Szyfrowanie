using System.Text.RegularExpressions;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bezpieczenstwo1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class CaesarCipher : Window
    {
        public char[] alphabet = { 'a', 'ą', 'b', 'c', 'ć', 'd', 'e', 'ę', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'ł', 'm', 'n', 'ń', 'o', 'ó', 'p', 'q', 'r', 's', 'ś', 't', 'u', 'w', 'x', 'y', 'z', 'ź', 'ż' };
        public CaesarCipher()
        {
            InitializeComponent();
        }

        private void encryptButton_Click(object sender, RoutedEventArgs e)
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

        private void decipherButton_Click(object sender, RoutedEventArgs e)
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

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
        
    }
    
}
