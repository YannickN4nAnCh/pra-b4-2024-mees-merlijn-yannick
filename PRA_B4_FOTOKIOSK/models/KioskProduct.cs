using System.Collections.Generic;

namespace PRA_B4_FOTOKIOSK.models
{
    public static class ShopManager
    {
        public static List<KioskProduct> Products { get; set; } = new List<KioskProduct>();

        private static List<string> priceList = new List<string>();

        public static void SetShopPriceList(string priceListEntry)
        {
            priceList.Clear();
            priceList.Add(priceListEntry);
        }

        public static void AddShopPriceList(string priceListEntry)
        {
            priceList.Add(priceListEntry);
        }

        public static List<string> GetShopPriceList()
        {
            return priceList;
        }
    }
}
