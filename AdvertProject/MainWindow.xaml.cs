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

namespace AdvertProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new RegistrationPage();
            Manager.MainFrame = MainFrame;
            UserData.Id = 0;
           
        }

        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void AutorizationBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new AutoruzationPage();
            
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                AutorizationBtn.Visibility = Visibility.Hidden;
                RegistrationBtn.Visibility = Visibility.Visible;
            }
            else 
            {
                AutorizationBtn.Visibility = Visibility.Visible;
                RegistrationBtn.Visibility = Visibility.Hidden;
            }
        }

        private void AddAdvertBtn_Click(object sender, RoutedEventArgs e)
        {
            if (UserData.Id > 0)
            {
                Manager.MainFrame.Content = new AddAdvertPage();
            }
            else 
            {
                MessageBox.Show("Необходимо авторизироваться");
            }
        }

        private void UserProfileBtn_Click(object sender, RoutedEventArgs e)
        {
            if (UserData.Id > 0)
            {
                Manager.MainFrame.Content = new UserProfilePage();
            }
            else
            {
                MessageBox.Show("Необходимо авторизироваться");
            }
        }
    }
}
