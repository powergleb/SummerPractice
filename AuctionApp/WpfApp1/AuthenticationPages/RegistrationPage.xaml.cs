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
using BLLInterfaces;
using Dependencies;
using Entities;
using Exceptions;

namespace WpfApp1.AuthenticationPages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {

        IUserLogic userbll;
        public RegistrationPage()
        {
            InitializeComponent();
            userbll = Dependencies.DependencyResolver.UserLogic;
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            var user = new User();
            user.Login = LoginText.Text;
            user.Name = NameText.Text;
            user.Pass = PassText.Text;
            user.Patronymic = PatronymicText.Text;
            user.Surname = SurnameText.Text;
            user.DateofBirth = DateOfBirthPicker.SelectedDate;


            try
            {
                userbll.CreateUser(user);
            }
            catch (InvalidValueException exception)
            {
                MessageBox.Show("Имя, фамилия, номер телефона и пароль не могут быть пустыми.", "Ошибка", MessageBoxButton.OK);
            }
            catch (ValueAlreadyExistsException exception)
            {
                MessageBox.Show("Пользователь с таким номером телефона уже существует.", "Ошибка", MessageBoxButton.OK);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Что-то пошло не так: {exception.Message}.", "Ошибка", MessageBoxButton.OK);
            }
            NavigationService.Navigate(new LoginPage());
        }
    }
}
