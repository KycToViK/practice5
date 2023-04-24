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

namespace Que3_5
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
            int N = Convert.ToInt32(NumberCC.Text);
            int S = 0;

            for(int i = 0; i<=N; i++)
            {
                S +=(int) Math.Pow(N + i, 2);
            }
            S +=(int) Math.Pow(2 * N, 2);

            NAnswer.Content = S;
        }

        private void BtnZ_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
