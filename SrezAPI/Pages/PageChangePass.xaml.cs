using SrezAPI.Classes;
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

namespace SrezAPI.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageChangePass.xaml
    /// </summary>
    public partial class PageChangePass : Page
    {
        bool passShowF = false;
        bool passShowS = false;
        public PageChangePass()
        {
            InitializeComponent();
        }

        private void btnShowFPass_Click(object sender, RoutedEventArgs e)
        {
            if (!passShowF)
            {
                txbPassF.Text = psbPassF.Password;
                psbPassF.Visibility = Visibility.Collapsed;
                txbPassF.Visibility = Visibility.Visible;
                passShowF = true;
            }
            else
            {
                psbPassF.Password = txbPassF.Text;
                psbPassF.Visibility = Visibility.Visible;
                txbPassF.Visibility = Visibility.Collapsed;
                passShowF = false;
            }
        }

        private void btnShowPassS_Click(object sender, RoutedEventArgs e)
        {
            if (!passShowS)
            {
                txbPassS.Text = psbPassS.Password;
                psbPassS.Visibility = Visibility.Collapsed;
                txbPassS.Visibility = Visibility.Visible;
                passShowS = true;
            }
            else
            {
                psbPassS.Password = txbPassS.Text;
                psbPassS.Visibility = Visibility.Visible;
                txbPassS.Visibility = Visibility.Collapsed;
                passShowS = false;
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageLogin());
        }

        private void fostan_click(object sender, RoutedEventArgs e)
        {

        }
    }
}
