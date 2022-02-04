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

namespace HBKate.Pages
{
    /// <summary>
    /// Interaction logic for AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void btYes_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы Катушка?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Добро пожаловать!)", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                Classes.FrameObj.MainFrame.Navigate(new Pages.CentralPage());
            }
            else
                MessageBox.Show("Вы не Катушка!\nВ доступе отказано!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Stop);
        }

        private void btNo_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
