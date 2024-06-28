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

namespace lab5
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

        private void rescalc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Date dt1 = new Date(int.Parse(year.Text), int.Parse(month.Text), int.Parse(day.Text));
                Date dt2 = new Date(int.Parse(year1.Text), int.Parse(month1.Text), int.Parse(day1.Text));

                int diffday = Calc(dt1, dt2);
                res.Text = diffday.ToString();
            }
            catch {
                MessageBox.Show("Вводите только числа и помните в году 12 месяцев и в месяце не более 31 дня");
            }
        }
        static int Calc(Date dt1, Date dt2)
        {
            DateTime date1 = new DateTime(dt1.years, dt1.months, dt1.days);
            DateTime date2 = new DateTime(dt2.years, dt2.months, dt2.days);
            TimeSpan diff = date1 - date2;
            return diff.Days;

        }
    }
}
