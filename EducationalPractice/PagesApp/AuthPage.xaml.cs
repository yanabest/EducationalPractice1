using EducationalPractice.ClassApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EducationalPractice.PagesApp
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void Registr_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrPage());
        }

        private void Auth_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var DataLogin = App.Connection.User.Where(x => x.Password == TxtPassword.Password && x.Login == TxtLogin.Text).FirstOrDefault();
                if (DataLogin != null)
                {
                    if (DataLogin.Id == 1)
                    {
                        ClassCorrUser.CorrUser = DataLogin;
                        NavigationService.Navigate(new MenuPage());

                    }
                    else
                    {
                        MessageBox.Show("Такого пользователя нет", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Такого пользователя нет", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
