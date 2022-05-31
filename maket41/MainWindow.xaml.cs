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

namespace maket41
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Услуга 1\nУслуга 2\nУслуга 3\nУслуга 4\n");
        }

        private void hover1(object sender, MouseEventArgs e)
        {
            Change.Text = "Услуга";
        }

        private void hover2(object sender, MouseEventArgs e)
        {
            Change.Text = "О компании";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Наша компания предоставляет широкий спектр услуг уже многи годы");
        }

        private void hover3(object sender, MouseEventArgs e)
        {
            Change.Text = "Наши работы";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Работа 1\nРабота 2\nРабота 3\nРабота 4\n");
        }

        private void hover4(object sender, MouseEventArgs e)
        {
            Change.Text = "Как нас найти";
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            grid1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(238, 238, 238));
            border1.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0));
            border2.BorderBrush = new SolidColorBrush(Colors.Black);
            border3.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0));
            border4.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0));
            border5.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0));
            border1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            border2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            border3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            border4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            text1.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0));
            tool.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            b1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            b2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            b3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            b4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            status.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            border6.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0));
            border7.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0));
            border8.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0));
        }

        private void hover5(object sender, MouseEventArgs e)
        {
            Change.Text = "Светлая тема";
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            grid1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(24, 23, 53));
            border1.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb(254, 104, 84));
            border2.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb(254, 104, 84));
            border3.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb(254, 104, 84));
            border4.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb(254, 104, 84));
            border5.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb(254, 104, 84));
            border1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(15, 15, 45));
            border2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(15, 15, 45));
            border3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(15, 15, 45));
            border4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(15, 15, 45));
            text1.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            tool.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 109, 89));
            b1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 109, 89));
            b2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 109, 89));
            b3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 109, 89));
            b4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 109, 89));
            status.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 109, 89));
            border2.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb(254, 104, 84));
            border6.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb(254, 104, 84));
            border7.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb(254, 104, 84));
            border8.BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromRgb(254, 104, 84));
        }

        private void hover6(object sender, MouseEventArgs e)
        {
            Change.Text = "Темная тема";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Мы распологаемся по адресу: Большая красная 55");
        }
        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
                var slider = sender as Slider;
                double value = slider.Value;
                text1.FontSize = value * 3;
            }
            catch
            {
            }
        }
    }
}
