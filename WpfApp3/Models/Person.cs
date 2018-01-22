using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp3.ViewModels;

namespace WpfApp3.Models
{
    public class Person
    {
        //DataManager DMM = new DataManager();
        //MainViewModel mainViewModel = new MainViewModel();
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
    
    


       

}
