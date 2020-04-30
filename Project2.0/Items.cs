using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2._0
{

    public enum ProductType
    {
        Face, Eyes, Lips, Skincare
    }
    public class Items : IComparable<Items>
    {
        //These are my properties
        public string ProductName { get; set; }

        public string Brand { get; set; }

        public decimal Cost { get; set; }
        public ProductType TypeOfProduct { get; set; }

        public static List<Items> allProducts = new List<Items>();
        public static List<Items> selectedProducts = new List<Items>();
        public static List<Items> filteredProducts = new List<Items>();
        public static List<Items> CartItems = new List<Items>();


        Items l1 = new Items()
        {
            ProductName = "Matte Revolution",
            Brand = "CHARLOTTE TILBURY",
            TypeOfProduct = ProductType.Lips,
            Cost = 32m
        };

        Items l2 = new Items()
        {
            ProductName = "Power Bullet Matte Lipstick",
            Brand = "HUDA BEAUTY",
            TypeOfProduct = ProductType.Lips,
            Cost = 25m
        };

        Items l3 = new Items()
        {
            ProductName = "Nudies Matte Blush & Bronze",
            Brand = "NUDESTIX",
            TypeOfProduct = ProductType.Lips,
            Cost = 35m
        };

        Items l4 = new Items()
        {
            ProductName = "Lip Injection Extreme ",
            Brand = "TOO FACED",
            TypeOfProduct = ProductType.Lips,
            Cost = 26m
        };

        Items e1 = new Items()
        {
            ProductName = "Bigger, Brighter Eyes - Exaggereyes",
            Brand = "CHARLOTTE TILBURY",
            TypeOfProduct = ProductType.Eyes,
            Cost = 55m
        };

        Items e2 = new Items()
        {
            ProductName = "Sunrise Palette",
            Brand = "NATASHA DENONA",
            TypeOfProduct = ProductType.Eyes,
            Cost = 75m
        };

        Items e3 = new Items()
        {
            ProductName = "Rose Gold Remastered Palette",
            Brand = "HUDA BEAUTY",
            TypeOfProduct = ProductType.Eyes,
            Cost = 60m
        };

        Items e4 = new Items()
        {
            ProductName = "Soft Glam Eye Shadow Palette",
            Brand = "ANASTASIA BEVERLY HILLS",
            TypeOfProduct = ProductType.Eyes,
            Cost = 40m
        };
        Items f1 = new Items()
        {
            ProductName = "Airbrush Flawless Foundation",
            Brand = "CHARLOTTE TILBURY",
            TypeOfProduct = ProductType.Face,
            Cost = 40m
        };

        Items f2 = new Items()
        {
            ProductName = "Sheer Glow Foundation",
            Brand = "NARS",
            TypeOfProduct = ProductType.Face,
            Cost = 41m
        };

        Items f3 = new Items()
        {
            ProductName = "Shimmering Skin Perfector Pressed Highlighter",
            Brand = "BECCA",
            TypeOfProduct = ProductType.Face,
            Cost = 38m
        };

        Items f4 = new Items()
        {
            ProductName = "Shimmering Skin Perfector Luminous Blush",
            Brand = "BECCA",
            TypeOfProduct = ProductType.Face,
            Cost = 34m
        };
        Items s1 = new Items()
        {
            ProductName = "Dermaflash Luxe",
            Brand = "DERMAFLASH",
            TypeOfProduct = ProductType.Skincare,
            Cost = 220m
        };
        Items s2 = new Items()
        {
            ProductName = "Watermelon Glow Pink Juice Moisturizer",
            Brand = "GLOW RECIPE",
            TypeOfProduct = ProductType.Skincare,
            Cost = 26m
        };
        Items s3 = new Items()
        {
            ProductName = "100 % Organic Cold - Pressed Rose Hip Seed Oil",
            Brand = "THE ORDINARY",
            TypeOfProduct = ProductType.Skincare,
            Cost = 15m
        };
        Items s4 = new Items()
        {
            ProductName = "Lait - Creme Concentre",
            Brand = "EMBRYOLISSE LABORATORIES",
            TypeOfProduct = ProductType.Skincare,
            Cost = 30m
        };



        //these are my constructers
        public Items()
        {

        }
        public void addItems()
        {
            //create some activity objects
           

            Items.allProducts.Add(l1);
            Items.allProducts.Add(l2);
            Items.allProducts.Add(l3);
            Items.allProducts.Add(l4);
            Items.allProducts.Add(e1);
            Items.allProducts.Add(e2);
            Items.allProducts.Add(e3);
            Items.allProducts.Add(e4);
            Items.allProducts.Add(f1);
            Items.allProducts.Add(f2);
            Items.allProducts.Add(f3);
            Items.allProducts.Add(f4);
            Items.allProducts.Add(s1);
            Items.allProducts.Add(s2);
            Items.allProducts.Add(s3);
            Items.allProducts.Add(s4);
        }
        public Items(string name, string brand, ProductType type, decimal cost)
        {
            ProductName = name;
           Brand = brand;
            TypeOfProduct = type;
            Cost = cost;
        }
        //Methods
        public override string ToString()
        {
            return $"{ProductName}- {Brand} - {Cost:c}";
        }
        //Implement IComparable to sort by date, utilised by both listboxes. 
        public int CompareTo(Items other)
        {
            if (this.ProductName == other.ProductName)
            {
                return this.Cost.CompareTo(other.Cost);
            }
            return other.ProductName.CompareTo(this.ProductName);
        }

    }
}
