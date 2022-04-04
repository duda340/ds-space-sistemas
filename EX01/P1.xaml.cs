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

namespace EX01
{
    /// <summary>
    /// Lógica interna para P1.xaml
    /// </summary>
    public partial class P1 : Window
    {
        public P1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n1 = 0, n2 = 0, resul = 0;

             n1= Convert.ToInt32(Textn1.Text);
          
             n2 = Convert.ToInt32(Textn2.Text);

             resul = n1 + n2;

            Textresul.Text = resul.ToString();
           
            
        }

        private void Textn1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Textn2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Textresul_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtSub_Click(object sender, RoutedEventArgs e)
        {
            int n1 = 0, n2 = 0, resul = 0;

            n1 = Convert.ToInt32(Textn1.Text);

            n2 = Convert.ToInt32(Textn2.Text);

            resul = n1 - n2;

            Textresul.Text = resul.ToString();
        }

        private void BtLimpa_Click(object sender, RoutedEventArgs e)
        {
            Textresul.Clear();
            Textn1.Clear();
            Textn2.Clear();
        }
    }
}
