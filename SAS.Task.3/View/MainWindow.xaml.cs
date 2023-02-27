using SAS.Task._3.View.Pages;
using SAS.Task._3.Core;
using System.ComponentModel;
using System.Windows;

namespace SAS.Task._3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CoreNavigate.MyConnection = MainFrame;
            MainFrame.Navigate(new MainPage());

        }

    }
}