using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.Models
{
    public class Person : INotifyPropertyChanged
    {
        private string firstname;
        private string lastname;
        private string fullname;

        public string FirstName
        {
            get
            {
                return firstname;
            }
            set
            {
                if (firstname != value)
                    firstname = value;
                OnPropertyChanged("FirstName");
                OnPropertyChanged("FullName");
            }
        }
            
        public string LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                if (lastname != value)
                    lastname = value;
                OnPropertyChanged("LastName");
                OnPropertyChanged("FullName");
            }
        }
        
        public string FullName
        {
            get
            {
                return fullname = firstname + " " + lastname;
            }
        }

        private void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
    
    


       

}
