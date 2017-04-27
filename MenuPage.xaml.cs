using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Цей_день
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MenuPage : Page
    {
        private int current_year;
        public MenuPage()
        {
            this.current_year = System.DateTimeOffset.Now.Year;
            this.InitializeComponent();
        }

        private void Setup_Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SetupPage));
        }

        private void Search_box_QuerySubmitted(SearchBox sender, SearchBoxQuerySubmittedEventArgs args)
        {
            if(sender.QueryText!="") Frame.Navigate(typeof(ResultPage),sender.QueryText);
        }

        private void select_date_DateChanged(CalendarDatePicker sender, CalendarDatePickerDateChangedEventArgs args)
        {
                Frame.Navigate(typeof(ResultPage), (int)(sender.Date.Value - new DateTime(sender.Date.Value.Year, 1,1) ).TotalDays);            
        }

        private void Today_Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ResultPage), 0);
        }

        private void About_button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
