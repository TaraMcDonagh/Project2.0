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





        //these are my constructers
        public Items()
        {

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
