using Q1.DataAccess;
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

namespace Q1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
		private readonly PRN_Spr23_B1Context _context = new PRN_Spr23_B1Context();
		public List<Customer> c;
		public MainWindow()
        {
            InitializeComponent();
			c = _context.Customers.ToList();
			
	}

		private void Button_Add(object sender, RoutedEventArgs e)
		{

		}

		private void Button_Import(object sender, RoutedEventArgs e)
		{

		}

		private void Button_Db(object sender, RoutedEventArgs e)
		{

		}

		private void List_emp_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}
	}
}
