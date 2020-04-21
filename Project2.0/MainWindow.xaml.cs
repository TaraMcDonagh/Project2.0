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
            Window2 win2 = new Window2();
            win2.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //create some activity objects
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
            allProducts.Add(s1);
            allProducts.Add(s2);
            allProducts.Add(s3);
            allProducts.Add(s4);

            allProducts.Sort();
            allProducts.Reverse();

            //Displaying them in the listbox
            lbxProducts.ItemsSource = allProducts;
        }

        private void AddToCartBtn_Click(object sender, RoutedEventArgs e)
        {
            Items selectedItem = lbxProducts.SelectedItem as Items;
            if (selectedItem != null)
            {


                total++;
                NoOfItems.Text = string.Format("{0}", total);
            }
            else
            {
                MessageBox.Show("Nothing has been selected");
            }

        }
        private void RefreshPage()
        {
            //refreshing the box
            lbxProducts.ItemsSource = null;
            lbxProducts.ItemsSource = allProducts;
        }

        private void rb_All_Checked(object sender, RoutedEventArgs e)
        {
            filteredProducts.Clear();
            if (rb_All.IsChecked == true)
            {

                RefreshPage();
            }
            else if (rb_Face.IsChecked == true)
            {
                foreach (Items item in allProducts)
                {
                    if (item.TypeOfProduct == ProductType.Face)
                    {
                        filteredProducts.Add(item);
                        lbxProducts.ItemsSource = null;
                        lbxProducts.ItemsSource = filteredProducts;

                    }
                }
            }
            else if (rb_Eyes.IsChecked == true)
            {
                foreach (Items item in allProducts)
                {
                    if (item.TypeOfProduct == ProductType.Eyes)
                    {
                        filteredProducts.Add(item);
                        lbxProducts.ItemsSource = null;
                        lbxProducts.ItemsSource = filteredProducts;

                    }
                }
            }
            else if (rb_Lips.IsChecked == true)
            {
                foreach (Items item in allProducts)
                {
                    if (item.TypeOfProduct == ProductType.Lips)
                    {
                        filteredProducts.Add(item);
                        lbxProducts.ItemsSource = null;
                        lbxProducts.ItemsSource = filteredProducts;

                    }
                }
            }
            else if (rb_Skin.IsChecked == true)
            {
                foreach (Items item in allProducts)
                {
                    if (item.TypeOfProduct == ProductType.Skincare)
                    {
                        filteredProducts.Add(item);
                        lbxProducts.ItemsSource = null;
                        lbxProducts.ItemsSource = filteredProducts;

                    }
                }
            }
            else
            {
                MessageBox.Show("Nothing has been selected");
            }
        }

        private void lbxProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Figuring out which activity was selected.
            Items selectedItem = lbxProducts.SelectedItem as Items;

            //Null check
            if (selectedItem != null)
            {

               

            }
        }
    }
}
