using BusinessObject;
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

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for WindowSearchProduct.xaml
    /// </summary>
    public partial class WindowSearchProduct : Window
    {
       
            public WindowSearchProduct()
            {
                InitializeComponent();
            }
            private void onSearch_Click(Object sender, RoutedEventArgs args)
            {
                List<Product> lstProduct = new List<Product>();
                var db = new ShopingMiniContext();
                lstProduct = db.Products.ToList();
                String title = search.Text.ToString();
                dataProduct.ItemsSource = null;
                if (title.ToString().Trim().Equals(""))
                {
                    dataProduct.ItemsSource = lstProduct;
                    return;
                }

                if (lstProduct != null)
                {
                    List<Product> lstProduct2 = new List<Product>();
                    lstProduct2 = lstProduct.FindAll(p =>
                                                    p.ProductId + "" == title
                                                    || p.ProductName == title
                                                    || p.UnitPrice + "" == title
                                                    || p.UnitsInStock + "" == title);
                    dataProduct.ItemsSource = lstProduct2;
                }
            }
            private void onClose_Click(object sender, RoutedEventArgs e)
            {
                this.Close();
            }
            private void onSelectGrid(Object sender, RoutedEventArgs args)
            {
            }
        }
}
