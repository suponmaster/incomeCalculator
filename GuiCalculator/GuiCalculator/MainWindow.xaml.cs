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

namespace GuiCalculator
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

        private void cal_Click(object sender, RoutedEventArgs e)
        {
                txtDay.Text = sum().ToString();
        }
        private double sum()
        {
            double income = double.Parse(txtIncome.Text);
            double pay = double.Parse(txtPay.Text);
            double item = double.Parse(txtItem.Text);
            double day = item/(income-pay);
            return day;
        }
    }
}
