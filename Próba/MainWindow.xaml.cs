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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Próba
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}


        bool atvaltas = false;
        

        private void meter_Checked(object sender, RoutedEventArgs e)
        {
            
            szélmérték.Text = "m-ben:";
            hosszmérték.Text = "m-ben:";
            //bemérték.Text = "m2-ként:";
            atvaltas = false;
        }

        private void mili_Checked(object sender, RoutedEventArgs e)
        {
            
            szélmérték.Text= "mm-ben:";
            hosszmérték.Text = "mm-ben:";
            //bemérték.Text = "mm2-ként:";
            atvaltas = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double v = 0;
            double sz = Convert.ToDouble(textBox_téglasz.Text);
            double m =  Convert.ToDouble(textBox1_téglam.Text);
            double ar = Convert.ToDouble(ár.Text);
            
            if (atvaltas == false)
            {
                v = m * sz * ar;
            }
            if (atvaltas == true)
            {
                v = (m * sz * ar) / 1000000;
            }
            string kiirt = Convert.ToString(v);
            textBox2.Text = kiirt;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void ár_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }
    }
}
