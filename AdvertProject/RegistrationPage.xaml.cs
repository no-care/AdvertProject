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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        private Users _currentUser = new Users();
        public RegistrationPage()
        {
            InitializeComponent();
            DataContext = _currentUser;
        }

        private void RegConfirm_Click(object sender, RoutedEventArgs e)
        {
            AdvertProjectEntities.GetContext().Users.Add(_currentUser);
            AdvertProjectEntities.GetContext().SaveChanges();
            Manager.MainFrame.Content = new AutoruzationPage();
        }

        private void RegLoginBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
