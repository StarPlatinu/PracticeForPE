using Microsoft.EntityFrameworkCore;
using Q1.Models;
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

namespace Q1
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        private PRN_Spr23_B1Context _context;
        public ProductWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _context = new PRN_Spr23_B1Context();
            LoadProduct();
        }

        public void LoadProduct()
        {
            var products = _context.Products.Include(p => p.Category).ToList();
            lvProduct.ItemsSource = products;

            var categories = _context.Categories.ToList();
            cbCategory.ItemsSource = categories;
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            lvProduct.UnselectAll();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Product p = new Product();
            p.ProductName = txtProductName.Text;
            p.CategoryId = int.Parse(cbCategory.SelectedValue.ToString());
            p.QuantityPerUnit = txtQuantityPerUnit.Text;
            p.Discontinued = checkBoxDisContinued.IsChecked.Value;
            p.UnitsInStock = short.Parse(tbUnitsInStock.Text);
            p.UnitsOnOrder = short.Parse(txtUnitsOnOrder.Text);

            _context.Products.Add(p);
            _context.SaveChanges();
            LoadProduct();

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            int proId = int.Parse(txtProductId.Text);
            var p = _context.Products.Where(p => p.ProductId == proId).FirstOrDefault();
            p.ProductName = txtProductName.Text;
            p.CategoryId = int.Parse(cbCategory.SelectedValue.ToString());
            p.QuantityPerUnit = txtQuantityPerUnit.Text;
            p.Discontinued = checkBoxDisContinued.IsChecked.Value;
            p.UnitsInStock = short.Parse(tbUnitsInStock.Text);
            p.UnitsOnOrder = short.Parse(txtUnitsOnOrder.Text);

            _context.SaveChanges();
            LoadProduct();

        }
    }
}
