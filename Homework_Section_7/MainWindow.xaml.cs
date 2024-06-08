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

namespace Homework_Section_7
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
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /* int numberIncome = int.Parse(txtIncome.Text);
             int numberExpenses = int.Parse(txtExpenses.Text);
             int numberWich = int.Parse(txtWich.Text);
             //float numberResult = float.Parse(txtResult.Text);
             int DayResult;
             int numberMoney;
             numberMoney = (numberIncome - numberExpenses);
             if (numberMoney > numberWich)
             {
                 DayResult = 1;
             }
             else
             {
                 DayResult = numberWich/numberMoney;

             }*/

            float numberIncome = float.Parse(txtIncome.Text);
            float numberExpenses = float.Parse(txtExpenses.Text);
            float numberWich = float.Parse(txtWich.Text);
            
            int DayResult;
            
            float numberMoney = (numberIncome - numberExpenses);
            if (numberMoney > numberWich)
            {
                DayResult = 1;
            }
            else
            {
               
                DayResult = (int)Math.Ceiling(numberWich / numberMoney);

            }
            txtResult.Text = DayResult.ToString();

        }
    }
}
