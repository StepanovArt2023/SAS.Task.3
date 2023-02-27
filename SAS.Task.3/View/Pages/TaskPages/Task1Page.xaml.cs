using System;
using System.Windows;
using System.Windows.Controls;

namespace SAS.Task._3.View.Pages.TaskPages
{
    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
        }

        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TbX.Text);
                double a = 0.2, b = 0.5, z = Math.Exp(a * x);
                if(x <  -Math.Log10(a))
                MessageBox.Show($"y = {a * Math.Pow(Math.Sin(x),2) + b * Math.Cos(z * x)}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                a = 0.15;
                b = 0.2; 
                z = Math.Exp(2 * a * x);

                if (x >= -Math.Log10(a) && x <= b)
                    MessageBox.Show($"y = {Math.Pow(a, b) - Math.Pow(Math.Cos(a + z * x),3)}", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);

                a = 0.9;
                b = 5;
                z = Math.Exp(2.5 * a * x);

                if (x > b)
                    MessageBox.Show($"y = {Math.Sqrt(2.5 * Math.Pow(a,3)) + Math.Pow(b - z * Math.Pow(x,2),6)}", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                TbX.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}