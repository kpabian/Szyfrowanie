using System.Windows;

namespace Bezpieczenstwo
{
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void CaesarButton_Click(object sender, RoutedEventArgs e)
        {
            CaesarCipher caesarCipher = new CaesarCipher();
            caesarCipher.Show();
            Close();
        }

        private void PolybiusButton_Click(object sender, RoutedEventArgs e)
        {
            PolybiusSquare polybiusSquare = new PolybiusSquare();
            polybiusSquare.Show();
            Close();
        }

        private void TrithemiusButton_Click(object sender, RoutedEventArgs e)
        {
            TrithemiusCipher trithemiusCipher = new TrithemiusCipher();
            trithemiusCipher.Show();
            Close();
        }

        private void VigenereButton_Click(object sender, RoutedEventArgs e)
        {
            VigenereCipher vigenereCipher = new VigenereCipher();
            vigenereCipher.Show();
            Close();
        }
    }
}
