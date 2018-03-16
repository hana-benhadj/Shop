using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Shop
{
    public partial class MainPage : ContentPage
    {
        Shop s1, s2, s3, s4, s5, s6;
        List<Shop> l;
        List<ShopProduct> PairShop;
        List<Shop> list;

        public MainPage()
        {
            
            InitializeComponent();
            s1 = new Shop { Title = "BROWNIE HIP SUN GLASSES", Type = "ALMOST NEW", Price = "770.00 SAR", Image = "glasses.png", Categorie = "Accessoires" };
            s2 = new Shop { Title = "BROWNIE GLASSES HOLDER", Type = "ACCEPTABLE", Price = "770.00 SAR", Image = "brownieGlases.png", Categorie = "Accessoires" };
            s3 = new Shop { Title = "HAND BAG NATURAL LEATHER", Type = "NEW", Price = "770.00 SAR", Image = "BrownieSac.png", Categorie = "Bags" };
            s4 = new Shop { Title = "CONCORD HAND WATCH", Type = "ALMOST NEW", Price = "770.00 SAR", Image = "watch.png", Categorie = "Accessoires" };
            s5 = new Shop { Title = "EVENING SHOES HIGH HEAL", Type = "ALMOST NEW", Price = "770.00 SAR", Image = "shoes.png", Categorie = "Shoes" };
            s6 = new Shop { Title = "BELT NATURAL LEATHER", Type = "ALMOST NEW", Price = "770.00 SAR", Image = "belt.png", Categorie = "Accessoires" };

            l = new List<Shop> { s1, s2, s3, s4, s5, s6 };
            PairShop = new List<ShopProduct> {
                new ShopProduct (s1, s2),
                new ShopProduct (s3, s4),
                new ShopProduct (s5, s6),
           };

            ListShop.ItemsSource = PairShop;

        }

        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            list=new List<Shop>();
            List<ShopProduct> lp = new List<ShopProduct>();

            
            if (sender.Equals(Bags))
            {
                foreach (ShopProduct sp in PairShop)
                {
                    if (sp.Item1.Categorie == "Bags")
                    {
                        list.Add(sp.Item1);
                    }
                    if (sp.Item2.Categorie == "Bags")
                    {
                        list.Add(sp.Item2);
                    }
                }

                for (int i = 0; i < list.Count; i++)
                {
                    while (list.Count - 1 > i)
                    {
                        ShopProduct prod = new ShopProduct(list[i], list[i + 1]);
                        lp.Add(prod);
                    }
                    if (list.Count - 1 == i)
                    {
                        ShopProduct prod = new ShopProduct(list[i], null);
                        lp.Add(prod);
  
                    }

                }
                ListShop.ItemsSource = lp;
             
            }

           
            if (sender.Equals(Shoes))
            {
                foreach (ShopProduct sp in PairShop)
                {
                    if (sp.Item1.Categorie == "Shoes")
                    {
                        list.Add(sp.Item1);
                    }
                    if (sp.Item2.Categorie == "Shoes")
                    {
                        list.Add(sp.Item2);
                    }
                }

                for (int i = 0; i < list.Count; i++)
                {
                    while (list.Count - 1 > i)
                    {
                        ShopProduct prod = new ShopProduct(list[i], list[i + 1]);
                        lp.Add(prod);
                    }
                    if (list.Count - 1 == i)
                    {
                        ShopProduct prod = new ShopProduct(list[i], null);
                        lp.Add(prod);
                    }

                }
                ListShop.ItemsSource = lp;
            }

            
            //if (sender.Equals(Accessoires))
            //{
            //    foreach (ShopProduct sp in PairShop)
            //    {
            //        if (sp.Item1.Categorie == "Accessoires")
            //        {
            //            list.Add(sp.Item1);
            //        }
            //        if (sp.Item2.Categorie == "Accessoires")
            //        {
            //            list.Add(sp.Item2);
            //        }
            //    }

            //    for (int i = 0; i < list.Count; i++)
            //    {
            //        while (list.Count - 1 > i)
            //        {
            //            ShopProduct prod = new ShopProduct(list[i], list[i + 1]);
            //            lp.Add(prod);
            //        }
            //        if (list.Count - 1 == i)
            //        {
            //            ShopProduct prod = new ShopProduct(list[i], null);
            //            lp.Add(prod);
            //        }

            //    }
            //    ListShop.ItemsSource = lp;
            //}

            
            if (sender.Equals(Clothes))
            {
                foreach (ShopProduct sp in PairShop)
                {
                    if (sp.Item1.Categorie == "Clothes")
                    {
                        list.Add(sp.Item1);
                    }
                    if (sp.Item2.Categorie == "Clothes")
                    {
                        list.Add(sp.Item2);
                    }
                }

                for (int i = 0; i < list.Count; i++)
                {
                    while (list.Count - 1 > i)
                    {
                        ShopProduct prod = new ShopProduct(list[i], list[i + 1]);
                        lp.Add(prod);
                    }
                    if (list.Count - 1 == i)
                    {
                        ShopProduct prod = new ShopProduct(list[i], null);
                        lp.Add(prod);
                    }

                }

                ListShop.ItemsSource = lp;

            }

        }

    }
}
