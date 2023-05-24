using EducationalPractice.ADOApp;
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

namespace EducationalPractice.PagesApp
{
    /// <summary>
    /// Логика взаимодействия для RegistrPage.xaml
    /// </summary>
    public partial class RegistrPage : Page
    {
        public RegistrPage()
        {
            InitializeComponent();
        }
        private void ClEventRevers(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void CLeventAddNewUsers(object sender, RoutedEventArgs e)
        {
            try
            {
                User NewUser = new User()
                {
                    Id = 1,
                    Name = TxtName.Text,
                    Login = TxtLogin.Text,
                    Password = TxtPassword.Text
                };
                App.Connection.User.Add(NewUser);
                App.Connection.SaveChanges();
                MessageBox.Show("Регистрация прошла успено!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.GoBack();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Text_Click(object sender, TextCompositionEventArgs e)
        {
            if (Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void Email_Click(object sender, TextCompositionEventArgs e)
        {
            if (!(Char.IsDigit(e.Text, 0) || (e.Text == ".") || (e.Text == "@")
             && (!TxtEmail.Text.Contains(".")
              && TxtEmail.Text.Contains("@")
             && TxtEmail.Text.Length != 0)))
            {
                e.Handled = true;
            }
        }
    }
}
