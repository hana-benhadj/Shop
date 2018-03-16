using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
   public class Shop
    {
       

        public String Title { get; set; }
        public String Type { get; set; }
        public String Price { get; set; }
        public String Image { get; set; }
        public String Categorie { get; set; }

        public bool IsVisible { get; set; }
    }
    public class ShopProduct : Tuple<Shop, Shop>
    {
        public ShopProduct(Shop item1, Shop item2)
      : base(item1, item2 ?? CreateEmptyModel()) { }

        private static Shop CreateEmptyModel()
        {
            return new Shop { IsVisible = false };

        }
    }

}
