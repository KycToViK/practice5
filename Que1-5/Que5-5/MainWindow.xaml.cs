using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace Que5_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnZ_Click(object sender, RoutedEventArgs e)
        {
            double n = Convert.ToDouble(NumberCC.Text);
            double so = 0;
            double k1 = 1;

            double a1 = 1.0, b1 = 1.0;

            for (int k = 2; k <= n; k++)
            {
                double a2 = 3 * b1 + 2 * a1;
                double b2 = 2 * a1 + b1;
                k1 = k1 * (k1 + 1);
                so = (Math.Pow(2, k)) / ((1 + Math.Pow(a2, 2) + Math.Pow(b2, 2))*k1);
                a1 = a2;
                b1 = b2;
            }
            NAnswer.Content = so;
        }
    }
}
