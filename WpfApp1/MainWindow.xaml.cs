using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using WpfApp1.Models;
using WpfApp1.ViewModels;
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
     
        public MainWindow()
        {
             
            DataContext = this;
           // Emp = new Employee();
         
            InitializeComponent();
        }
    
      
        //TODO: Getting Null value for EMP. Please resolve this issue
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            // string str = Emp.PName;
            EmployeeVM vm = new EmployeeVM();
            vm.Save(vm.Emp);  
        }
    }
}
