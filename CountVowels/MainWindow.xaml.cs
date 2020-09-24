// Author : Jeffrey Benn
// Date   : 2020-09-24
// Chapter 5 Problem 13 CountVowels

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CountVowels
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

        //Event to count the number of vowels in the paragraph when the user clicks the count button
        private void btnCount_Click(object sender, RoutedEventArgs e)
        {
            int vowels = 0;         //The amount of vowels the paragraph has
            String paragraph = txtParagraph.Text.ToLower();       //The content of the paragraph in lowercase

            //Loop to count the vowels
            for(int i = 0; i < paragraph.Length; i++)
            {
                if(paragraph[i] == 'a' || paragraph[i] == 'e' || paragraph[i] == 'i' 
                    || paragraph[i] == 'o' || paragraph[i] == 'u')
                {
                    vowels++;
                }
            }

            //Update the count textbox with the amount of vowels
            txtCount.Text = Convert.ToString(vowels);


        }

        //Event to make the contents of the count textbox blank if the paragraph text box is changed
        private void txtParagraph_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtCount.Text = "";
        }

        //Event that lets the user hit the enter key in the paragraph textbox to fire the counting event
        private void txtParagraph_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                btnCount_Click(sender, e);
            }

        }
    }
}
