using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Цей_день
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    
    public sealed partial class ResultPage : Page
    {
        private DateTime Today = System.DateTimeOffset.Now.DateTime;
        private ObservableCollection<string> text = new ObservableCollection<string>();
        private ViewModel model;
        public class ViewModel : INotifyPropertyChanged
        {
            private bool pauseVisible;
            private bool playVisible;

            public event PropertyChangedEventHandler PropertyChanged = delegate { };

            public ViewModel()
            {
                this.pauseVisible = App.data.isPlaying;
                this.playVisible = !this.pauseVisible;
            }

            public bool isGoing
            {
                get { return this.pauseVisible; }
                set
                {
                    this.pauseVisible = value;
                    this.playVisible = !(bool)value;
                    App.data.isPlaying = value;
                    this.OnPropertyChanged();
                }
            }
            public void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public ResultPage()
        {
            this.InitializeComponent();
            this.model = new ViewModel();
        }
        private void Menu_Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MenuPage));
        }
        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null && e.Parameter.ToString() != "")
                text = (e.Parameter is string)?findByQuery(e.Parameter.ToString(),App.data.days) : findByDate(Convert.ToInt32(e.Parameter),App.data.days);
            base.OnNavigatedTo(e);
        }        

        //buttons OnClics
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ResultPage), 0);
        }

        private void Share_Click(object sender, RoutedEventArgs e)
        {
            Windows.ApplicationModel.DataTransfer.DataTransferManager.ShowShareUI();
        }
        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SetupPage));
        }
        
        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            App.data.music.Pause();
            model.isGoing = false;
        }
        private void Play_Click(object sender, RoutedEventArgs e)
        {
            App.data.music.Play();
            model.isGoing = true;
        }
    }
    
}
