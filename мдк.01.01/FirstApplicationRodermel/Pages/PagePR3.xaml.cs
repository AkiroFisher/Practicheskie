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
    /// Логика взаимодействия для PagePR3.xaml
    /// </summary>
    public partial class PagePR3 : Page
    {
        public PagePR3()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            lstResult.Items.Clear();
            double x0 = double.Parse(txtX0.Text);
            double xk = double.Parse(txtXk.Text);
            double dx = double.Parse(txtDx.Text);
            double b = double.Parse(txtB.Text);
            double y = 0;
            lstResult.Items.Add("Лаб.раб.№3. Выполнил Родермель А.В.");
            lstResult.Items.Add($"Отрезок{x0}-{xk}");
            lstResult.Items.Add($"шаг={dx}");
            lstResult.Items.Add($"a={b}");
            while(x0 <= xk)
            {
                y = 0.8 * Math.Pow(10, -5) * Math.Pow(Math.Pow(x0, 3) + Math.Pow(b, 3), 7 / 6);
                lstResult.Items.Add($"x={x0}; y={y}");
                x0 = x0 + dx;
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtX0.Clear();
            txtXk.Clear();
            txtDx.Clear();
            txtB.Clear();
            lstResult.Items.Clear();
        }
    }
}
