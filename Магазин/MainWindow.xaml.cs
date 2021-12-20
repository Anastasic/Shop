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

namespace Магазин
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            output();
        }
        public void output()
        {
            var List1 = App.DB.products.ToList();

            var vi = viv.SelectedIndex.ToString();
            if(vi == "1")
            {
                List1 = App.DB.products.Where(p => p.id <= 20).ToList();
                dl.IsEnabled = true;
                if (sch == 1)
                {
                    List1 = App.DB.products.Where(p => p.id > 20 && p.id <= 40).ToList();
                    dl.IsEnabled = true;
                }
                if (sch == 2)
                {
                    List1 = App.DB.products.Where(p => p.id > 40 && p.id <= 60).ToList();
                    dl.IsEnabled = true;
                }
                if (sch == 3)
                {
                    List1 = App.DB.products.Where(p => p.id > 60 && p.id <= 80).ToList();
                    dl.IsEnabled = true;
                }
                if (sch == 4)
                {
                    List1 = App.DB.products.Where(p => p.id > 80 && p.id <= 100).ToList();
                    dl.IsEnabled = false;
                }

            }
            if (vi == "2")
            {
                dl.IsEnabled = true;
                List1 = App.DB.products.Where(p => p.id <= 50).ToList();
                if (sch == 1)
                {
                    List1 = App.DB.products.Where(p => p.id > 50 && p.id <= 100).ToList();
                    dl.IsEnabled = false;
                }

            }

            List.ItemsSource = List1;
        }

        private void vibr(object sender, SelectionChangedEventArgs e)
        {
            sch = 0;
            output();
        }
        public int sch;
        private void Dalee(object sender, RoutedEventArgs e)
        {
            var vi = viv.SelectedIndex.ToString();
            if (vi == "1" || vi == "2")
            {
                sch++;
                output();
            }
        }
        
        private void Nasad(object sender, RoutedEventArgs e)
        {
            var vi = viv.SelectedIndex.ToString();
            if (vi == "1" || vi == "2")
            {
                if (sch > 0)
                {
                    sch--;
                    output();
                }
            }
            if(sch < 0) { sch = 0; }
        }
    }
}
