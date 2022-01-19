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

namespace WpfApp1
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

        private void ComboBox_SelectionChanged1 (object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(fontName);

            }
    
        }

        //Размер шрифта

        private void ComboBox_SelectionChanged2(object sender, SelectionChangedEventArgs e)
        {
            double fontSize = ((sender as ComboBox).SelectedItem as TextBlock).FontSize;
            if (textBox != null)
            {
                textBox.FontSize = fontSize;
            }
        }

        //Жирный шрифт

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string fontWeight = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(fontWeight);

            }
        }

        //Наклонный шрифт

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string fontStyle = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(fontStyle);

            }
        }

        //Подчеркнтый шрифт

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string textDecorations = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(textDecorations);

            }
        }



        //Радиокнопки

        private void Black_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Green_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Yellow_Checked(object sender, RoutedEventArgs e)
        {

        }


    }

}
