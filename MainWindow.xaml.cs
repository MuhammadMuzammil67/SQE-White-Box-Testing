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

namespace Calculator1
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

        private void Answer(object sender, RoutedEventArgs e)
        {
            int num1, num2, result;
            num1 = Convert.ToInt32(LoprTxtbox.Text);
            num2 = Convert.ToInt32(RoprTxtbox.Text);

           if(addRB.IsChecked==true)
           {
               addValues();
           }
           else if (mulRB.IsChecked==true)
           {
               mulValues();
           }
          else if(subRB.IsChecked==true)
           {
               subValues();
           }
         else if(divRB.IsChecked==true)
           {
               divValues();
           }
         else if(remRB.IsChecked==true)
           {
               remValues();
           }



        }



        private void remValues()
        {
            
            
           int num1 = Convert.ToInt32(LoprTxtbox.Text);
          int  num2 = Convert.ToInt32(RoprTxtbox.Text);
         int   result = num1 % num2;
            ResTxtblc.Text = result.ToString();
            ExpTxtblc.Text = num1.ToString() + " % " + num2.ToString();
        }

        private void divValues()
        {
            
         int num1 = Convert.ToInt32(LoprTxtbox.Text);
         int    num2 = Convert.ToInt32(RoprTxtbox.Text);
         int     result = num1 / num2;
            ResTxtblc.Text = result.ToString();
            ExpTxtblc.Text = num1.ToString() + " / " + num2.ToString();
        }

        private void subValues()
        {
            int num1, num2, result;
            num1 = Convert.ToInt32(LoprTxtbox.Text);
            num2 = Convert.ToInt32(RoprTxtbox.Text);
            result = num1 - num2;
            ResTxtblc.Text = result.ToString();
            ExpTxtblc.Text = num1.ToString() + " - " + num2.ToString();
        }

        private void mulValues()
        {
           
          int  num1 = Convert.ToInt32(LoprTxtbox.Text);
          int  num2 = Convert.ToInt32(RoprTxtbox.Text);
          int  result = num1 * num2;
            ResTxtblc.Text = result.ToString();
            ExpTxtblc.Text = num1.ToString() + " * " + num2.ToString();
        }

        private void addValues()
        {
            
         int  num1 = Convert.ToInt32(LoprTxtbox.Text);
         int   num2 = Convert.ToInt32(RoprTxtbox.Text);
         int   result = num1 + num2;
            ResTxtblc.Text = result.ToString();
            ExpTxtblc.Text = num1.ToString() + " + " + num2.ToString();
        }

    
        private void exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       
    }
}