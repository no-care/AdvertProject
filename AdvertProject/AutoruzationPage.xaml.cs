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
    /// Логика взаимодействия для AutoruzationPage.xaml
    /// </summary>
    public partial class AutoruzationPage : Page
    {
        public AutoruzationPage()
        {
            InitializeComponent();
            
        }

        private void AutorConfirm_Click(object sender, RoutedEventArgs e)
        {

            Users user = null;
            using (AdvertProjectEntities db = new AdvertProjectEntities())
            {
                user = db.Users.Where(b => b.Логин == AutorLogBox.Text && b.Пароль == AutorPasBox.Text).FirstOrDefault();
            }
            if (user != null)
            {
                UserData.Id = user.ID_Пользователя;
                MessageBox.Show("Успешная авторизация");
                Manager.MainFrame.Content = new AdvertsPage();
            }
            else 
            {
                MessageBox.Show("Данные введены некорретно");
                AutorLogBox.Text = "";
                AutorPasBox.Text = "";
            }
        }
    }
}
