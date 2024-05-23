using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Xml.Linq;

namespace Week_8_Junk_Notes
{
    /// <summary>
    /// Interaction logic for My_New_Window.xaml
    /// </summary>
    public partial class My_New_Window : Window { 
    
        public My_New_Window()
        {
            InitializeComponent();
          

            lbShowNames2.ItemsSource = Data.supernames;

            lblBuisinessName2.Content = Data.gameFranchise;
        }
        


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //how to open new window we created.
            // When you create a new window, you are creating a new 
            //instanced object to call


           //To open it, you can call the .show() ,ethod
            MainWindow myNewer = new MainWindow();

            myNewer.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            string namer = txtName2.Text;
        Data.supernames.Add(namer);
        }
    }
}
