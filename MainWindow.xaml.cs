using System.Collections.Generic;
using System.Windows;

namespace WpfApp10
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var products = new List<Product>
            {
                new Product { Model = "iPhone 6S", Company = "Apple", Price = 54990 },
                new Product { Model = "Lumia 950", Company = "Microsoft", Price = 39990 },
                new Product { Model = "Nexus 5X", Company = "Google", Price = 29990 },
                new Product { Model = "Galaxy Edge", Company = "Samsung", Price = 45670 }
            };

            ProductListView.ItemsSource = products;
        }
    }

    public class Product
    {
        public string Model { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }
    }
}