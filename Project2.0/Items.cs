using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2._0
{
    public enum ProductType
    {
        Face, Eyes, Lips
    }
    public class Items : IComparable<Items>
    {
        //These are my properties
        private string _description;
        public string ProductName { get; set; }

        public string Brand { get; set; }

        public decimal Cost { get; set; }
        public ProductType TypeOfProduct { get; set; }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        //these are my constructers
        public Items()
        {

        }
        public Items(string name, string description, string brand, ProductType type, decimal cost)
        {
            ProductName = name;
            Description = description;
            Brand = brand;
            TypeOfProduct = type;
            Cost = cost;
        }
        //Methods
        public override string ToString()
        {
            return $"{ProductName} - {Cost}";
        }
        //Implement IComparable to sort by date, utilised by both listboxes. 
        public int CompareTo(Items other)
        {
            if (this.TypeOfProduct == other.TypeOfProduct)
            {
                return this.ProductName.CompareTo(other.ProductName);
            }
            return other.TypeOfProduct.CompareTo(this.TypeOfProduct);
        }
    }
}
