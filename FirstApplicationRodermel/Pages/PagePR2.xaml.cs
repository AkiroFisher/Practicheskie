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

namespace FirstApplicationRodermel.Pages
{
    /// <summary>
    /// Логика взаимодействия для PagePR2.xaml
    /// </summary>
    public partial class PagePR2 : Page
    {
        public PagePR2()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            lstResult.Items.Clear();
            double x = double.Parse(txtX.Text);
            double m = double.Parse(txtM.Text);
            double j = 0;
            double sh = (Math.Exp(x) - Math.Exp(-x)) / 2;
            lstResult.Items.Add("Лаб.раб.№2. Выполнил Родермель А.В.");
            lstResult.Items.Add($"X={x}");
            lstResult.Items.Add($"M={m}");
            int n = 0;
            if (rbtX2.IsChecked == true) n = 1;
            else if (rbtExpX.IsChecked == true) n = 2;
            switch (n)
            {
                case 0:
                    if (x > m) j = Math.Cos(3 * sh + 5 * m * Math.Abs(sh));
                    else if (x == m) j = Math.Pow(sh + m, 2);
                    else if (-1 < m && m < x) j = Math.Sin(5 * sh + 3 * m * Math.Abs(sh));
                    else goto default;
                    lstResult.Items.Add($"Результат j={Math.Round(j, 3)}");
                    break;
                case 1:
                    if (x > m) j = Math.Cos(3 * Math.Pow(x, 2) + 5 * m * Math.Abs(Math.Pow(x, 2)));
                    else if (x == m) j = Math.Pow(Math.Pow(x, 2) + m, 2);
                    else if (-1 < m && m < x) j = Math.Sin(5 * Math.Pow(x, 2) + 3 * m * Math.Abs(Math.Pow(x, 2)));
                    else goto default;
                    lstResult.Items.Add($"Результат j={Math.Round(j, 3)}");
                    break;
                case 2:
                    if (x > m) j = Math.Cos(3 * Math.Exp(x) + 5 * m * Math.Abs(Math.Exp(x)));
                    else if (x == m) j = Math.Pow(Math.Exp(x) + m, 2);
                    else if (-1 < m && m < x) j = Math.Sin(5 * Math.Exp(x) + 3 * m * Math.Abs(Math.Exp(x)));
                    else goto default;
                    lstResult.Items.Add($"Результат j={Math.Round(j, 3)}");
                    break;
                default:
                    lstResult.Items.Add("Решение не найдено");
                    break;
            }
        }

            private void btnClear_Click(object sender, RoutedEventArgs e)
            {
                txtX.Clear();
                txtM.Clear();
                lstResult.Items.Clear();
            }
        }
    }
