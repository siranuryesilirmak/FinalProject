using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        internal static string MaintenanceTime="Sistem bakımda";
        internal static string ProductsListed="ürünler listelendi";
        public static string ProductCountOfCategoryError = "bu kategoride en fazla 10 ürün olabilir";
        internal static string ProductNameAlreadyExist = "Aynı isimde zaten başka bir ürün var";
        internal static string CategoryLimitExceded = "kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        public static string AuthorizationDenied = "yetkiniz yok.";
        internal static string UserAlreadyExists ="kullanıcı bulunamadı";
        internal static string AccessTokenCreated = "token oluşturuldu.";
        internal static string SuccessfulLogin = "başarılı";
        internal static string PasswordError ="şifre yanlış";
        internal static string UserNotFound = "kullanıcı bulunamadı.";
        internal static string UserRegistered = "kullanıcı kaydedildi";
    }
}
