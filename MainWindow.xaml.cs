using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Week_8_Junk_Notes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    //Observable collection


    public partial class MainWindow : Window
    {

  
        public MainWindow()
        {
            InitializeComponent();

           

            lbShowNames.ItemsSource = Data.names;

            //atatch the field from our static, Data .cs,class
            lblBuisinessName.Content = Data.BuissnessName;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //how to open new window we created.
            // When you create a new window, you are creating a new 
            //instanced object to call


            My_New_Window myNew = new My_New_Window();

            //To open it, you can call the .show() method on our variable name
            myNew.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            Data.names.Add(name);
        }
    }
}