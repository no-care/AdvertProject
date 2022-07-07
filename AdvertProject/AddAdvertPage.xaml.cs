using System;
using System.Collections.Generic;
using System.IO;
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
using f = System.Windows.Forms;

namespace AdvertProject
{
    /// <summary>
    /// Логика взаимодействия для AddAdvertPage.xaml
    /// </summary>
    public partial class AddAdvertPage : Page
    {
        private Adverts _currentAdvert = new Adverts();
        public AddAdvertPage()
        {
            InitializeComponent();
            DataContext =_currentAdvert;
           
        }

        private void SelectImage_Click(object sender, RoutedEventArgs e)
        {
            f.OpenFileDialog pic = new f.OpenFileDialog();
            pic.Filter = "Фильтр картинок |*.png; *.jpg";
            if (pic.ShowDialog() == f.DialogResult.OK) 
            {
                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                bi.UriSource = new Uri(pic.FileName, UriKind.Relative);
                bi.CacheOption = BitmapCacheOption.OnLoad;
                bi.EndInit(); 
                ByteImg(bi);
                AdvImage.Source = bi;

            }
        }

        private void AddAdvConfirm_Click(object sender, RoutedEventArgs e)
        {
            _currentAdvert.ID_Пользователя = UserData.Id;
            AdvertProjectEntities.GetContext().Adverts.Add(_currentAdvert);
            AdvertProjectEntities.GetContext().SaveChanges();
            MessageBox.Show("Успешнр");
        }

        private void ByteImg(BitmapImage bi) 
        {
            PngBitmapEncoder pe = new PngBitmapEncoder();
            MemoryStream ms = new MemoryStream();
            pe.Frames.Add(BitmapFrame.Create(bi));
            pe.Save(ms);
            byte[] imgB = ms.ToArray();
            _currentAdvert.Ссылка_на_изображение = imgB;
        }

    }
}
