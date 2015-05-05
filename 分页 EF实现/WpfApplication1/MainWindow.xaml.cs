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

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private int index = 0;

        private NorthwindEntities conxt = new NorthwindEntities();
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
                IQueryable<Supplier> list = from item in conxt.Suppliers orderby item.SupplierID select item;
                var list2 = list.Skip(--index * Convert.ToInt32(textbox.Text)).Take(Convert.ToInt32(textbox.Text));
                this.datagrid.ItemsSource = list2.ToList();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
                IQueryable<Supplier> list = from item in conxt.Suppliers orderby item.SupplierID select item;
                var list2 = list.Skip(++index * Convert.ToInt32(textbox.Text)).Take(Convert.ToInt32(textbox.Text));
                this.datagrid.ItemsSource = list2.ToList();
        }
    }
}
