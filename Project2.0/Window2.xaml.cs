﻿using System;
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
        decimal total = 0;
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
            
        }

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
