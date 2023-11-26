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
using System.Windows.Shapes;

namespace Bezpieczenstwo1
{
    /// <summary>
    /// Interaction logic for PolybiusSquare.xaml
    /// </summary>
    public partial class PolybiusSquare : Window
    {
        public PolybiusSquare()
        {
            InitializeComponent();
        }

        private void randButton_Click(object sender, RoutedEventArgs e)
        {
            List<EAlphabet> list = Enum.GetValues(typeof(EAlphabet)).Cast<EAlphabet>().ToList();
        }

        private void encryptButton_Click(object sender, RoutedEventArgs e)
        {

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
