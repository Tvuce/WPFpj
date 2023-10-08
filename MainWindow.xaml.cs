using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace testbinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public class User
    {
        public string name {  get; set; }
        public string surn { get; set; }
        public int age { get; set; }

        
    }
    
    


    public partial class MainWindow : Window
    {

        public ObservableCollection<User> o = null;
        public MainWindow()
        {
            InitializeComponent();
            o = new ObservableCollection<User>();
            testgrid.DataContext = o;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User p = new User() { name = "cane", surn = "lupo", age = 15 };
            o.Add(p);
        }
    }

}

