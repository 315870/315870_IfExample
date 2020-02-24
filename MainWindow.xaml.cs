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

namespace _315870_IfExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random r = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            int diel = r.Next(6) + 1;
            int diel2 = r.Next(6) + 1;
            int numberToGuess = 10;
            lblOutput.Content = "";
            int countwins = 0;

            for (int i = 0; i < 1000; i++)
            {
                diel = r.Next(6) + 1;
                diel2 = r.Next(6) + 1;
                lblOutput.Content += "Test " + i.ToString() + "Die 1: " + diel.ToString() + Environment.NewLine
                    + "Die 2: " + diel2.ToString() + Environment.NewLine +
                    "Number to Guess: " + numberToGuess.ToString();

                if (numberToGuess == (diel + diel2))
                {
                    lblOutput.Content += Environment.NewLine + "You Guessed IT!!";
                    countwins++;

                }
                else if (numberToGuess > (diel + diel2))
                {
                    lblOutput.Content += Environment.NewLine + "Your guess was too high.";
                    lblOutput.Content += " I guess you lost";

                }
                else
                {
                    lblOutput.Content += Environment.NewLine + "Your guess was too low. Sorry... ";
                    lblOutput.Content += " I guess you lost";
                }
            } // End for the loop
            lblOutput.Content = "You've Won: " + countwins.ToString() +
                Environment.NewLine + lblOutput.Content;


        }
    }
}
