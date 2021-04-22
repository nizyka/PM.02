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
using System.Windows.Shapes;

namespace _11ПР
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private Владельцы владельцы;
        public Window1(Владельцы владельцы)
        {
            InitializeComponent();
            this.владельцы = владельцы;
            famili_label.Content = владельцы.Фамилия;
            name_label.Content = владельцы.Имя;
            if (!String.IsNullOrEmpty(владельцы.картинка))
            {
                try
                {
                    Image_profiel.Source = new BitmapImage(new Uri(System.IO.Path.GetFullPath("image/" + владельцы.картинка)));
                }
                catch(InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Exit_button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Window_Clossing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Owner.Show();
        }
    }

