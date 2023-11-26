using Bezpieczenstwo1.Classes;
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
        public char[] alphabet = { 'a', 'ą', 'b', 'c', 'ć', 'd', 'e', 'ę', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'ł', 'm', 'n', 'ń', 'o', 'ó', 'p', 'r', 's', 'ś', 't', 'u', 'w', 'x', 'y', 'z', 'ź', 'ż' };
        public CaesarCipher()
        {
            InitializeComponent();
        }

        private void encryptButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sipher = new StringBuilder();

            foreach (char c in textToBeEncrypted.Text)
            {
                sipher.Append(Convert.ToChar(c + int.Parse(stepNumber.Text)));
            }
            textToBeEncrypted.Text = sipher.ToString();
        }

        private void decipherButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sipher = new StringBuilder();

            foreach (char c in textToBeEncrypted.Text)
            {
                //sipher.Append(Convert.ToChar(c - int.Parse(stepNumber.Text)));


            }
            textToBeEncrypted.Text = sipher.ToString();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
