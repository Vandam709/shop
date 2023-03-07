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

namespace ShopMag.Pages
{
    /// <summary>
    /// Логика взаимодействия для OknoRegistration.xaml
    /// </summary>
    public partial class OknoRegistration : Window
    {
        public OknoRegistration()
        {
            InitializeComponent();
            
        }


        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(FemTB.Text))
            {
                TB.Foreground = Brushes.Red;
            }
            if (string.IsNullOrWhiteSpace(emailTB.Text))
            {
                TBL.Foreground = Brushes.Red;
            }
            if (string.IsNullOrWhiteSpace(PassTb.Password))
            {
                TBP.Foreground = Brushes.Red;
            }
            if (string.IsNullOrWhiteSpace(NoomberTB.Text))
            {
                TBN.Foreground = Brushes.Red;
            }


            if (mes != "")
            {

                return;

            }
            Models.admin admin = new Models.admin()
            {
                Name = FemTB.Text,
                email = emailTB.Text,
                password = PassTb.Password
            };
            AppData.Helpers.ClassConnect.panas.admin.Add(admin);
            AppData.Helpers.ClassConnect.panas.SaveChanges();
            MessageBox.Show("Добавлен");

            FemTB.Text = "";
            emailTB.Text = "";
            PassTb.Password = "";
            NoomberTB.Text = "";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
