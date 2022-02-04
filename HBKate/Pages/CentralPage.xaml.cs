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
    /// Interaction logic for CentralPage.xaml
    /// </summary>
    public partial class CentralPage : Page
    {
        public CentralPage()
        {
            InitializeComponent();
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
        }

        private void Image_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (MessageBox.Show("Вам уже есть 18?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Classes.SecretWindow secret = new Classes.SecretWindow();
                secret.Show();
            }
            else
                MessageBox.Show("Тогда что ты тут забыл, малой?", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Classes.GeniusWindow genius = new Classes.GeniusWindow();
            genius.Show();

        }
    }
}
