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

namespace Black_Out_Challenge
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SetBlackOutDates(firstDateLabel, secondDateLabel);
        }

        private void SetBlackOutDates(Label firstDateLabel, Label secondDateLabel)
        {
            throw new NotImplementedException();
        }

        //first date
        public void firstCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            firstDateLabel.Content = firstCalendar.SelectedDate.ToString();
        }

        //second date
        public void secondCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            secondDateLabel.Content = secondCalendar.SelectedDate.ToString();
        }

    }
}
