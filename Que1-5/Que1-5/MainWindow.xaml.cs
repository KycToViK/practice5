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

namespace Que1_5
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
            double s = 0;
            double n;
            int l = 1;

            for (int i = 0; i <= l; i++)
            {
                n = Convert.ToDouble(List.Items[i]);
                if (n % 10 == 6 && n % 6 == 0)
                {
                    s = s + n;
                }
                if (n == 0)
                {
                    break;
                }
                else if (n >= 1)
                {
                    
                    l++;
                }

            }

            NAnswer.Content = s;
        }

        private void BtnAd_Click(object sender, RoutedEventArgs e)
        {
            if ((String.IsNullOrEmpty(NumberCC.Text)))
            {
                return;
            }
            List.Items.Add(NumberCC.Text);
        }
    }
}
