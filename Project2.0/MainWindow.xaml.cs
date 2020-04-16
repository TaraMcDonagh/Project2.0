using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Items> allProducts = new List<Items>();
        List<Items> selectedProducts = new List<Items>();
        List<Items> filteredProducts = new List<Items>();
        decimal total = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //create some activity objects
            Items l1 = new Items()
            {
                ProductName = "",
                Description = "",
                Brand = "Tarte",
                TypeOfProduct = ProductType.Lips,
                Cost = 35m
            };

            Items l2 = new Items()
            {
                ProductName = "",
                Description = "",
                Brand = "Tarte",
                TypeOfProduct = ProductType.Lips,
                Cost = 35m
            };

            Items l3 = new Items()
            {
                ProductName = "",
                Description = "",
                Brand = "Tarte",
                TypeOfProduct = ProductType.Lips,
                Cost = 35m
            };

            Items l4 = new Items()
            {
                ProductName = "",
                Description = "",
                Brand = "Tarte",
                TypeOfProduct = ProductType.Lips,
                Cost = 35m
            };

            Items e1 = new Items()
            {
                ProductName = "",
                Description = "",
                Brand = "Tarte",
                TypeOfProduct = ProductType.Lips,
                Cost = 35m
            };

            Items e2 = new Items()
            {
                ProductName = "",
                Description = "",
                Brand = "Tarte",
                TypeOfProduct = ProductType.Lips,
                Cost = 35m
            };

            Items e3 = new Items()
            {
                ProductName = "",
                Description = "",
                Brand = "Tarte",
                TypeOfProduct = ProductType.Lips,
                Cost = 35m
            };

            Items e4 = new Items()
            {
                ProductName = "",
                Description = "",
                Brand = "Tarte",
                TypeOfProduct = ProductType.Lips,
                Cost = 35m
            };
            Items f1 = new Items()
            {
                ProductName = "",
                Description = "",
                Brand = "Tarte",
                TypeOfProduct = ProductType.Lips,
                Cost = 35m
            };

            Items f2 = new Items()
            {
                ProductName = "",
                Description = "",
                Brand = "Tarte",
                TypeOfProduct = ProductType.Lips,
                Cost = 35m
            };

            Items f3 = new Items()
            {
                ProductName = "",
                Description = "",
                Brand = "Tarte",
                TypeOfProduct = ProductType.Lips,
                Cost = 35m
            };

            Items f4 = new Items()
            {
                ProductName = "",
                Description = "",
                Brand = "Tarte",
                TypeOfProduct = ProductType.Lips,
                Cost = 35m
            };
            //adding the activities to the list created above
            allProducts.Add(l1);
            allProducts.Add(l2);
            allProducts.Add(l3);
            allProducts.Add(l4);
            allProducts.Add(e1);
            allProducts.Add(e2);
            allProducts.Add(e3);
            allProducts.Add(e4);
            allProducts.Add(f1);
            allProducts.Add(f2);
            allProducts.Add(f3);
            allProducts.Add(f4);
            allProducts.Sort();
            allProducts.Reverse();

            //Displaying them in the listbox
            lbxProducts.ItemsSource = allProducts;
        }

        private void AddToCartBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
