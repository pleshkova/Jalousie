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

namespace жалюзи
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
        double heidht, width, prise, sum;

        private void txt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if ((!Char.IsDigit(e.Text, 0)) && e.Text != ",") e.Handled = true;
        }

        private void btnSchet1_Click(object sender, RoutedEventArgs e)
        {
            prise = 0;
            try
            {
                switch (lstbx.SelectedIndex)
                {
                    case 0:
                        prise = 100;
                        break;
                    case 1:
                        prise = 150;
                        break;
                }
                heidht = double.Parse(txtHeight1.Text) / 100;
                width = double.Parse(txtWidth1.Text) / 100;
                sum = heidht * width * prise;
                lblSize1.Content = txtHeight1.Text + "см x " + txtWidth1.Text + "см";
                lblPrise1.Content = prise;
                lblSumm1.Content = Math.Round(sum, 2);
            }
            catch { MessageBox.Show("Не все поля заполнены!"); }
        }

        private void btnSchet2_Click(object sender, RoutedEventArgs e)
        {
            prise = 0;
            try
            {
                switch (cmbbx.SelectedIndex)
                {
                    case 0:
                        prise = 100;
                        break;
                    case 1:
                        prise = 150;
                        break;
                }
                heidht = double.Parse(txtHeight2.Text) / 100;
                width = double.Parse(txtWidth2.Text) / 100;
                sum = heidht * width * prise;
                lblSize2.Content = txtHeight2.Text + "см x " + txtWidth2.Text + "см";
                lblPrise2.Content = prise;
                lblSumm2.Content = Math.Round(sum, 2);
            }
            catch { MessageBox.Show("Не все поля заполнены!"); }
        }
    }
}
