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
using System.Windows.Shapes;

namespace Project2._0
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>

    public partial class Window2 : Window
    {
        Order db = new Order();
        //attempt to keep a total going
        decimal costTotal = 0;
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            lbxCartItems.ItemsSource = Items.CartItems;
           /* foreach (Items item in Items.CartItems)
            {
            Here i was trying to have a cart total which would be displayed but it wouldnt 
            seperate the cost property from the list.
                costTotal += Items.CartItems.Cost;

            }*/

        }
        //This Button is supposed to add everything in the listbox to the databse to keep track of the order 
        //but seeing as the database wont work the whole thing jams and freezes
        private void AddToDatabase_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                foreach (Items item in Items.CartItems)
                {
                    db.Orders.Add(item);
                }
                db.SaveChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                string msg = "Insert Error";
                msg += ex.Message;
                throw new Exception(msg);

            }

        }
        private void RefreshPage()
        {
            //refreshing the box
            lbxCartItems.ItemsSource = null;
            lbxCartItems.ItemsSource = Items.CartItems;
        }

        private void RemoveItem_Click(object sender, RoutedEventArgs e)
        {
            Items selectedItems = lbxCartItems.SelectedItem as Items;
            Items.CartItems.Remove(selectedItems);
            RefreshPage();

        }
       
    }
}
