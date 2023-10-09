using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class Employee : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
     
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            // if(PropertyChanged!=null)
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string name;
        public string PName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("PName");
            }
        }

    }
}
