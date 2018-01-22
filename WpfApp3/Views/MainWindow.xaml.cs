using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using WpfApp3.ViewModels;

namespace WpfApp3.Views
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        MainViewModel mainViewModel = new MainViewModel();
        public Window1()
        {
            InitializeComponent();
            textFirstName.Text = mainViewModel.ImportantPerson.FirstName;
            textLastName.Text = mainViewModel.ImportantPerson.LastName;
            textFullName.Text = mainViewModel.ImportantPerson.FullName;

        }

        public void  GemKnap_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.ImportantPerson.FirstName = textFirstName.Text;
            mainViewModel.ImportantPerson.LastName = textLastName.Text;
            textFullName.Text = mainViewModel.ImportantPerson.FirstName + " " + mainViewModel.ImportantPerson.LastName;

        }
    }
}
