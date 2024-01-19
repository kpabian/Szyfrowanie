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

namespace Bezpieczenstwo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CaesarButton_Click(object sender, RoutedEventArgs e)
        {
            CaesarCipher caesarCipher = new CaesarCipher();
            caesarCipher.Show();
            this.Close();
        }

        private void PolybiusButton_Click(object sender, RoutedEventArgs e)
        {
            PolybiusSquare polybiusSquare = new PolybiusSquare();
            polybiusSquare.Show();
            this.Close();
        }

        private void TrithemiusButton_Click(object sender, RoutedEventArgs e)
        {
            TrithemiusCipher trithemiusCipher = new TrithemiusCipher();
            trithemiusCipher.Show();
            this.Close();
        }

        private void VigenereButton_Click(object sender, RoutedEventArgs e)
        {
            VigenereCipher vigenereCipher = new VigenereCipher();
            vigenereCipher.Show();
            this.Close();
        }
    }
}
