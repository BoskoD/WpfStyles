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
using System.Windows.Shapes;

namespace WpfStilovi
{
    /// <summary>
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            TextBlock1.Style = Resources["tbStil"] as Style;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Style stil1 = new Style(typeof(TextBlock));
            Setter s1 = new Setter(TextBlock.FontSizeProperty, 24.0);
            Setter s2 = new Setter(TextBlock.FontFamilyProperty, new FontFamily("Calibri"));
            Setter s3 = new Setter(TextBlock.ForegroundProperty, new SolidColorBrush(Colors.Blue));

            stil1.Setters.Add(s1);
            stil1.Setters.Add(s2);
            stil1.Setters.Add(s3);

            this.Resources.Add("tbStil", stil1);
        }
    }
}
