using ShopMag.Pages;
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

namespace ShopMag
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

        private void AuthBtn_Click(object sender, RoutedEventArgs e)
        {
            var enter = AppData.Helpers.ClassConnect.panas.admin.Where(i => i.Name == LogTb.Text && i.password== PassTb.Password).FirstOrDefault();
            if (enter != null)
            {
               

                OknoProfile oknoProfile = new OknoProfile();
                oknoProfile.Show();
                Close();

            }
            if (enter == null)
            {
               
                MessageBox.Show("Пользователь не зарегестрирован ");

            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            OknoRegistration oknoRegistration = new OknoRegistration();
            oknoRegistration.Show();
            this.Close();
        }

        private void SbrosBtn_Click(object sender, RoutedEventArgs e)
        {
            SbrosParoyla sbrosParoyla = new SbrosParoyla();
            sbrosParoyla.Show();
            this.Close();
        }
    }
}
