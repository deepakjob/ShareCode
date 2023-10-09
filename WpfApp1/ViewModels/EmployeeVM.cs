using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    public class EmployeeVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
      
        public EmployeeVM()
        {
           

        
        }

     
        private void OnPropertyChanged( string propertyName )
        {
            // if(PropertyChanged!=null)
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Employee emp;

        public Employee Emp
        {
            get { return emp; }
            set { emp = value; OnPropertyChanged("Emp"); }
        }
        public void Save(Employee emp)
        {
            if (emp != null)
            {
               // string str;

            }
        }
    }
}
