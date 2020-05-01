using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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
        private Random orderno;
        private DateTime dateorder;
        Random rand = new Random();
        public string ProductName { get; set; }

        public string Brand { get; set; }

        public decimal Cost { get; set; }
        public ProductType TypeOfProduct { get; set; }
        //setting up parts for the database
        //I thought that maybe because there were extra properties in the items class that it wouldnt work
        //but here i was hoping to set a random number as the order id no and the datetime function as the order date
       /* public Random OrderNo {
            get { return orderno; }   // get method
            set { orderno = rand; }  // set method
        }
        public DateTime OrderDate
        {
            get { return dateorder; }   // get method
            set { dateorder = DateTime.Now; }  // set method
        }*/
        //Lists - my lists are here because i tried them in the mainwindow but the second window couldnt access them
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
    //Setting up my database i followed every step in the code first labsheet solution but it didnt work 
    //I even tried setting it up in a console project but even after creating a relation the class and database wasnt found
    public class Order : DbContext
    {

        public Order():base("Order History") { }
        public DbSet<Items> Orders { get; set; }
    }
}
