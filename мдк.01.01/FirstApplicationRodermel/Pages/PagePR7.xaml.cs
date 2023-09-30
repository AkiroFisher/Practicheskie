using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для PagePR7.xaml
    /// </summary>
    public partial class PagePR7 : Page
    {
        public PagePR7()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int index = lstInput.SelectedIndex;
                int[] z = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -1, -2, -3, -4, -5, -6, -7, 
                    -8, -9, -10, -11, -22, -33, -44, -55, -66, -77, -88, -99, -110, 11, 12, 13, 14, 15};
                int i;
                int s = 0;
                int p = 1;
                lstInput.Items.Add("Выполнил студент группы исп.21.2а Родермель А.В. Вариант №18");
                for (i = 0; i < 35; i++)
                {
                    lstInput.Items.Add(z[i]);
                    if (z[i] % 2 == 0 && z[i] < 3) s = s + z[i];
                    if (z[i] % 2 == 1 && z[i] > 1) p = p * z[i];
                }
                int r = s + p;

                txbRwsult.Text = "R = " + r.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
