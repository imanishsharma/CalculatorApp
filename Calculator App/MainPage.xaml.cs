using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ValueBox.IsReadOnly = true;
        }
        string opration;
        double num1, num2, result;


        private void PlusButton_Click_1(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                opration = "+";
                TextBox.Text = "";
                ValueBox.Text = num1 + "+";
            }
        }

        private void MinusButton_Click_1(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                opration = "-";
                TextBox.Text = "";
                ValueBox.Text = num1 + "-";
            }
        }

        private void MultiButton_Click_1(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                opration = "*";
                TextBox.Text = "";
                ValueBox.Text = num1 + "*";
            }
        }

        private void DivButton_Click_1(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                opration = "/";
                TextBox.Text = "";
                ValueBox.Text = num1 + "/";
            }
        }

        private void EqualButton_Click_1(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num2 = double.Parse(TextBox.Text);
                ValueBox.Text = "";
                switch (opration)
                {
                    case "+":
                        result = num1 + num2;
                        TextBox.Text = result.ToString();
                        break;
                    case "-":
                        result = num1 - num2;
                        TextBox.Text = result.ToString();
                        break;
                    case "*":
                        result = num1 * num2;
                        TextBox.Text = result.ToString();
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            ValueBox.Text = "Cannot divide by zero";
                            break;
                        }
                        else
                        {
                            result = num1 / num2;
                            TextBox.Text = result.ToString();
                            break;
                        }

                }
            }
        }



        private void Btn7_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "7";
        }

        private void Btn4_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "4";
        }

        private void Btn1_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "1";
        }

        private void DotButton_Click_1(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Contains("."))
            {
                TextBox.Text = TextBox.Text;
            }
            else
            {
                TextBox.Text = TextBox.Text + ".";
            }
        }

        private void Btn8_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "8";
        }

        private void Btn5_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "5";
        }

        private void Btn2_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "2";
        }

        private void Btn0_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "0";
        }

        private void Btn9_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "9";
        }

        private void Btn6_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "6";
        }

        private void Btn3_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "3";
        }

        private void BtnClear_Click_1(object sender, RoutedEventArgs e)
        {
            int length = TextBox.Text.Length;
            if (length > 0)
            {
                TextBox.Text = TextBox.Text.Remove(length - 1);
            }
            else
            {
                TextBox.Text = TextBox.Text;
            }
        }


    }
}

