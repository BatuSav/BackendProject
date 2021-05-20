using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Aracınız eklendi";
        public static string BrandAdded = "Yeni bir marka eklendi";
        public static string ColorAdded = "Yeni bir renk eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string ColorDeleteError = "Renk ekleme başarısız";
        public static string ColorUpdated = "Renk güncellendi";
        public static string CarDeleted="Araç silindi";
        public static string CarListed = "Araçlar listelendi";
        public static string CarDetailsListed = "Araç detayları listelendi";
        public static string CarAddedGoneWrong = "Araç ekleme başarısız";
        public static string CarAddedSuccessfull = "Araça ekleme başarılı";
        public static string CarsListedByBrandName = "Markaya göre araçlar getirildi";
        public static string CarUpdated = "Araç güncellendi";
        public static string CustomerAddSuccess = "Müşteri ekleme başarılı";
        public static string CustomerDeletedSuccess = "Müşteri silme başarılı";
        public static string CustomerUpdateSuccess = "Müşteri güncelleme başarılı";
        public static string NewRentalSuccess = "Araç kiralama başarılı";
        public static string RentalDeleteSuccess = "Araç kiralama bilgisi silindi";
        public static string RentalUpdated = "Araç kiralama bilgisi güncellendi";
        public static string GetRentalListSuccess = "Araç bilgileri listelendi";
        public static string UserAddSuccess = "Kullanıcı ekleme başarılı";
        public static string UserDeleteSuccess = "Kullanıcı silme başarılı";
        public static string UserUpdateSuccess = "Kullanıcı güncelleme başarılı";
        public static string CarCheckImageLimited="Fotoğraf sayısı sınırlıdır";
        public static string CarImagesListed="Fotoğraflar listelendi";
        public static string CarImageDeleted = "Fotoğraf silindi";
        public static string CarImageAdded = "Fotoğraf eklendi";
        public static string UserListed = "Kullanıcılar listelendi";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string UserRegistered = "Kayıt olundu";
        public static string SuccessfulLogin = "Giriş işlemi başarılı";
        public static string PasswordError = "Hatalı şifre";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Erişim anahtarı yaratıldı";
        public static string AuthorizationDenied = "Yetki yok";
    }
}
