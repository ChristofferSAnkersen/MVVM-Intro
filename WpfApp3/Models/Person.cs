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
        //DataManager DMM = new DataManager();
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
            set
            {
                if (fullname != value)
                    fullname = value;
                OnPropertyChanged("FullName");
            }
        }

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
    
    


       

}
