using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
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
using SrezAPI.Classes;

namespace SrezAPI.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageReg.xaml
    /// </summary>
    public partial class PageReg : Page
    {
        bool passShowF = false;
        bool passShowS = false;
        public PageReg()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageLogin());
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

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            using (var wb = new WebClient())
            {
                var data = new NameValueCollection();
                data["Login"] = txbEmail.Text;
                data["Password"] = txbPassS.Text;
                data["SecondName"] = txbFIO.Text;

                var response = wb.UploadValues("http://localhost:53140/api/Accounts", "POST", data);
                string responseInString = Encoding.UTF8.GetString(response);
            }
        }
    }
}
