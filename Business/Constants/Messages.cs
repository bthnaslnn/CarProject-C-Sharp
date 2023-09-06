using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarsListed = "Arabalar Listelendi";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandListed = "Markalar listelendi";
        public static string ListedByBrandId = "Marka Id'sine göre marka getirildi";
        public static string BrandUpdated = "Marka güncellendi";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorListed = "Renkler listelendi";
        public static string ColorById = "Renk Id'sine göre renk getirildi";
        public static string ColorUpdated = "Renk güncellendi";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomersListed = "Müşteriler listelendi";
        public static string CustomerById = "Müşteri Id'sine göre müşteri getirildi";
        public static string UserById = "Id'ye göre kullanıcı getirildi";
        public static string CustomerUpdated = "Müşteri güncellendi";

        public static string RentalAdded = "Kiralama eklendi";
        public static string RentalUnsucceed = "Kiralama başarısız";
        public static string RentalDeleted = "Kiralama silindi";
        public static string RentalsListed = "Kiralamalar listelendi";
        public static string RentalByRentalId = "Kiralama Id'sine göre kiralama getirildi";
        public static string RentalByCarId = "Araba id'sine göre kiralama getirildi";
        public static string RentalUpdated = "Kiralama güncellendi";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UsersListed = "Kullanıcılar listelendi";
        public static string UserByUserId = "Kullanıcı Id'sine göre kullanıcı getirildi";
        public static string UserByCustomerId = "Müşteri id'sine göre kullanıcı getirildi";
        public static string UserUpdated = "Kullanıcı güncellendi";
    }
}
