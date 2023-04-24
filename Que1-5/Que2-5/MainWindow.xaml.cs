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

namespace Que2_5
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
            double o = 0;
            int l = 1;

            for (int i = 0; i <= l; i++)
            {
                n = Convert.ToDouble(List.Items[i]);
                if (n % 8 == 0)
                {
                    s += n;
                    o++;
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

            if (o > 0)
            {
            o--;
            s /= o;

            NAnswer.Content = s + "\t" + o;
            }
            else
            {
                NAnswer.Content = "No";
            }
            
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
