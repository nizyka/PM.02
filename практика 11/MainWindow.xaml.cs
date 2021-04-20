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

namespace практика_11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_auth_Click(object sender, RoutedEventArgs e)
        {
            if(!String.IsNullOrEmpty(loginTextBox.Text))
            {
                if(!String.IsNullOrEmpty(passwordTextBox.Password))
                {
                    IQueryable<Владельцы> владельцы_list = Entities.GetContext().Владельцы.Where(p => p.Логин == loginTextBox.Text && p.Пароль == passwordTextBox.Password);
                    if (владельцы_list.Count() == 1)
                        MessageBox.Show("Добро пожаловать, " + владельцы_list.First().ФИО);
                    else MessageBox.Show("Неверный пароль или логин!");


                }
            }
        }
    }
}
