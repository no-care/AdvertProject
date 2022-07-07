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
    /// Логика взаимодействия для CurrentAdvert.xaml
    /// </summary>
    public partial class CurrentAdvert : Page
    {
        public CurrentAdvert(Adverts CurrentAdvert)
        {
            InitializeComponent();
            DataContext = CurrentAdvert;
        }
    }
}
