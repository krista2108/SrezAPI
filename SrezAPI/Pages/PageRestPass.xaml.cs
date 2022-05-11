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
    /// Логика взаимодействия для PageRestPass.xaml
    /// </summary>
    public partial class PageRestPass : Page
    {
        public PageRestPass()
        {
            InitializeComponent();
        }

        private void fostan_click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageChangePass());
        }

       

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageLogin());
        }
    }
}
