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
    /// Логика взаимодействия для AdvertsPage.xaml
    /// </summary>
    public partial class AdvertsPage : Page
    {
        public AdvertsPage()
        {
            InitializeComponent();
            var currentAdverts = AdvertProjectEntities.GetContext().Adverts.ToList();
            AdvertsLV.ItemsSource = currentAdverts;
        }

        private void Image_TouchUp(object sender, TouchEventArgs e)
        {
            
        }

        private void AdvOpenBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Content = new CurrentAdvert((sender as Button).DataContext as Adverts);
        }
    }
}
