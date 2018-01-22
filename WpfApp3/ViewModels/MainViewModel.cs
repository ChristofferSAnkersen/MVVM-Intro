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
        //DataManager DM = new Models.DataManager();
        //Window1 MW = new WpfApp3.Views.Window1();

        public Person ImportantPerson { get; set; }

        
        public MainViewModel()
        {
            DataManager DM = new DataManager();
            ImportantPerson = DM.ImportantPerson;
        }

    }
}
