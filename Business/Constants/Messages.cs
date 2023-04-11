using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages //static verilen yapı newlenmez.
    {
        public static string ProductAdded = "Ürün Eklendi.";

        public static string ProductNameInvalid = "Ürün ismi geçersiz.";

        public static string ProductsListed = "Ürünler Listelendi";

        public static string MaintenanceTime = "Sistem Bakımda";

        public static string CategoryListed = "Kategoriye Göre Listelendi";

        public static string ProductsListedByDetails = "Ürün Detayları Geldi";

        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir.";

        public static string ProductNameAlreadyExist = "Bu isimde zaten ürün var";

        public static string CategoryLimitExceded = "Kategori limiti aşıldı";
    }
}
