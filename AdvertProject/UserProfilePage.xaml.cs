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
    /// Логика взаимодействия для UserProfilePage.xaml
    /// </summary>
    public partial class UserProfilePage : Page
    {
        private Users _currentUser = new Users();
        public UserProfilePage()
        {
            InitializeComponent();
            _currentUser = AdvertProjectEntities.GetContext().Users.Find(UserData.Id);
            UsersAdvertsLV.ItemsSource = AdvertProjectEntities.GetContext().Adverts.Where(p => p.ID_Пользователя == UserData.Id).ToList();
            DataContext = _currentUser;
        }

        private void ProfileEdit_btn_Click(object sender, RoutedEventArgs e)
        {
            ReadOnlyOf();
            Switch();
        }

        private void EditConfirmBtn_Click(object sender, RoutedEventArgs e)
        {
            AdvertProjectEntities.GetContext().SaveChanges();
            MessageBox.Show("Изменения успешно сохранены");
            ReadOnlyOn();
            BackToNormal();
        }
        private void BackToNormal() 
        {
            EditConfirmBtn.Visibility = Visibility.Hidden;
            ProfileEdit_btn.Visibility = Visibility.Visible;
        }
        private void Switch() 
        {
            EditConfirmBtn.Visibility = Visibility.Visible;
            ProfileEdit_btn.Visibility = Visibility.Hidden;
        }
        private void ReadOnlyOn() 
        {
            ProfileLogBox.IsReadOnly = true;
            ProfileMailBox.IsReadOnly = true;
            ProfilePassBox.IsReadOnly = true;
        }
        private void ReadOnlyOf() 
        {
            ProfileLogBox.IsReadOnly = false;
            ProfileMailBox.IsReadOnly = false;
            ProfilePassBox.IsReadOnly = false;
        }
    }
}
