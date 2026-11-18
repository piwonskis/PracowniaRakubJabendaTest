using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string r_num = R_number.Content?.ToString();
            string g_num = G_number.Content?.ToString();
            string b_num = B_number.Content?.ToString();

            r = (byte)R_slider.Value;
            g = (byte)G_slider.Value;
            b = (byte)B_slider.Value;
            brushFromColor.Color = Color.FromRgb(r, g, b);
            Kolor_blok_2.Content = r_num+ ", "+ g_num + ", "+ b_num;
            Kolor_blok_2.Background = brushFromColor;
        }

        byte r;
        byte g;
        byte b;
        SolidColorBrush brushFromColor = new SolidColorBrush();
        private void R_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            R_number.Content = R_slider.Value;
            r = (byte)R_slider.Value;
            g = (byte)G_slider.Value;
            b = (byte)B_slider.Value;
            brushFromColor.Color = Color.FromRgb(r, g, b);
            kolorBlok.Background = brushFromColor;
        }

        private void G_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            G_number.Content = G_slider.Value;
            r = (byte)R_slider.Value;
            g = (byte)G_slider.Value;
            b = (byte)B_slider.Value;
            brushFromColor.Color = Color.FromRgb(r, g, b);
            kolorBlok.Background = brushFromColor;
        }

        private void B_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            B_number.Content = B_slider.Value;
            r = (byte)R_slider.Value;
            g = (byte)G_slider.Value;
            b = (byte)B_slider.Value;
            brushFromColor.Color = Color.FromRgb(r, g, b);
            kolorBlok.Background = brushFromColor;
        }
    }
}