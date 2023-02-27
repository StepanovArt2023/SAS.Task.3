using SAS.Task._3.Core;
using SAS.Task._3.View.Pages.TaskPages;
using System.Windows;
using System.Windows.Controls;
namespace SAS.Task._3.View.Pages
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task1Page());
        }
    }
}
