using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp3.ViewModels;

namespace WpfApp3.Models
{
    public class DataManager
    {
        public Person ImportantPerson { get; set; }

        public DataManager()
        {
            ImportantPerson = new Person { FirstName = "Anders", LastName = "And" };
        }
    }

}
