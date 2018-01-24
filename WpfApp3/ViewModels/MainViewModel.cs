using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp3.Models;

namespace WpfApp3.ViewModels
{

    public class MainViewModel
    {
        public Person ImportantPerson { get; set; }

        public List<Person> ImportantPersons { get; set; }
        
        public MainViewModel()
        {
            DataManager DM = new DataManager();
            ImportantPerson = DM.ImportantPerson;
            ImportantPersons = DM.ImportantPersons;
            
            //ImportantPersons = DM.ImportantPersons;
             
        }
    }
}
