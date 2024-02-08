﻿using System;
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
        private readonly Dictionary<char, string> cipher = new Dictionary<char, string>();
        private readonly Random random = new Random();
        private List<TextBox> textboxList;

        public PolybiusSquare() => InitializeComponent();

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            textboxList = new List<TextBox> { S22, S23, S24, S25, S26, S32, S33, S34, S35, S36, S42, S43, S44, S45, S46, S52, S53, S54, S55, S56, S62, S63, S64, S65, S66, S72, S73, S74, S75, S76, S82, S83, S84, S85, S86, };
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
                cipher.Add(alphabet[i], textboxList[i].Name);
            }
            try
            {
                foreach (char c in cipherText.Text)
                {
                    newText.Append(cipher.First(x => x.Key == c).Value[1]);
                    newText.Append(cipher.First(x => x.Key == c).Value[2]);
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
                    StringBuilder value = new StringBuilder();
                    value.Append('S');
                    value.Append(cipherText.Text[i]);
                    value.Append(cipherText.Text[i + 1]);
                    char a = cipher.First(x => x.Value == value.ToString()).Key;
                    newText.Append(a);
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
            Close();
        }
    }
}