using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        AdvertProject.AdvertProjectEntities ADV = new AdvertProject.AdvertProjectEntities();
        AdvertProject.Users user = new AdvertProject.Users();
        AdvertProject.Adverts advert = new AdvertProject.Adverts();

        public string AddUser(string log, string mail, string pass) 
        {
            user.Логин = log;
            user.Почта = mail;
            user.Пароль = pass;
            ADV.Users.Add(user);
            ADV.SaveChanges();
            return log;
        }
        public bool DeleteUser(int userid)
        {
            var currentUser = ADV.Users.Where(u => u.ID_Пользователя == userid).FirstOrDefault();
            ADV.Users.Remove(currentUser);
            ADV.SaveChanges();
            return true;
        }
        public string EditUser(string log, string mail, string pass, int userid) 
        {
            var currentUser = ADV.Users.Where(u => u.ID_Пользователя == userid).FirstOrDefault();
            currentUser.Логин = log;
            currentUser.Почта = mail;
            currentUser.Пароль = pass;
            ADV.SaveChanges();
            return log;
        }

        public string addAdvert(string title, string time, string location, string dicrib, int userid) 
        {
            advert.Краткое_описание = title;
            advert.Место_находки = location;
            advert.Время_находки = time;
            advert.Подробное_описание = dicrib;
            advert.ID_Пользователя = userid;
            ADV.Adverts.Add(advert);
            ADV.SaveChanges();
            return title;
        }

        public bool deleteAdvert(int advertid) 
        {
            var currentAdvert = ADV.Adverts.Where(a => a.ID_Объявления == advertid).FirstOrDefault();
            ADV.Adverts.Remove(currentAdvert);
            ADV.SaveChanges();
            return true;
        }

    }
}
