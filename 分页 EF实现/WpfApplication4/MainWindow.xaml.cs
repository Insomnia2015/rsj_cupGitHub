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

namespace WpfApplication4
{
    using System.Data.Entity;

    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded; 
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            using (var context = new NorthwindContext())
            {
                var em = new Employee() {pk="Lucy" ,EmployeeID=78, FirstName = "Lucy", LastName = "Smith" };
                context.Employees.Add(em);
                var user = new User
                {
                    Data = new byte[] { 1, 2, 3, 4 },
                    Name = "Mark",
                    Time = DateTime.Now,
                    Val = 2.2,
                    TestE = User.TestENUM.B
                };
                context.Users.Add(user);
                context.SaveChanges();
                this.dataGrid.ItemsSource = context.Employees.Local; 
            }
        }
    }
}
