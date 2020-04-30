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


            Items.allProducts.Sort();
            Items.allProducts.Reverse();

            //Displaying them in the listbox
            lbxProducts.ItemsSource = Items.allProducts;
        }

        private void AddToCartBtn_Click(object sender, RoutedEventArgs e)
        {
            Items selectedItem = lbxProducts.SelectedItem as Items;
            if (selectedItem != null)
            {
                Items.CartItems.Add(selectedItem);

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
            lbxProducts.ItemsSource = Items.allProducts;
        }

        private void rb_All_Checked(object sender, RoutedEventArgs e)
        {
            Items.filteredProducts.Clear();
            if (rb_All.IsChecked == true)
            {

                RefreshPage();
            }
            else if (rb_Face.IsChecked == true)
            {
                foreach (Items item in Items.allProducts)
                {
                    if (item.TypeOfProduct == ProductType.Face)
                    {
                        Items.filteredProducts.Add(item);
                        lbxProducts.ItemsSource = null;
                        lbxProducts.ItemsSource = Items.filteredProducts;

                    }
                }
            }
            else if (rb_Eyes.IsChecked == true)
            {
                foreach (Items item in Items.allProducts)
                {
                    if (item.TypeOfProduct == ProductType.Eyes)
                    {
                        Items.filteredProducts.Add(item);
                        lbxProducts.ItemsSource = null;
                        lbxProducts.ItemsSource = Items.filteredProducts;

                    }
                }
            }
            else if (rb_Lips.IsChecked == true)
            {
                foreach (Items item in Items.allProducts)
                {
                    if (item.TypeOfProduct == ProductType.Lips)
                    {
                        Items.filteredProducts.Add(item);
                        lbxProducts.ItemsSource = null;
                        lbxProducts.ItemsSource = Items.filteredProducts;

                    }
                }
            }
            else if (rb_Skin.IsChecked == true)
            {
                foreach (Items item in Items.allProducts)
                {
                    if (item.TypeOfProduct == ProductType.Skincare)
                    {
                        Items.filteredProducts.Add(item);
                        lbxProducts.ItemsSource = null;
                        lbxProducts.ItemsSource = Items.filteredProducts;

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
