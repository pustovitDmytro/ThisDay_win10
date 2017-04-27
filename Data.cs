using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Core;
using Windows.Storage;
using Windows.UI.Xaml.Controls;

namespace Цей_день
{
    public class Data
    {
        public List<Day> days;
        public Windows.UI.Xaml.Controls.MediaElement music;
        public bool isPlaying;
        public Data() {
            music = new MediaElement();
            LoadMediaAsync();
            LoadJsonAsync().GetAwaiter().GetResult();            
        }
        private async Task LoadJsonAsync(){
            StorageFile json_file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///data/all.json"));
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(List<Day>));
            Stream j_stream = await json_file.OpenStreamForReadAsync();
            days = (List<Day>)ser.ReadObject(j_stream);
        }
        private async Task LoadMediaAsync(){
            try
            {
                StorageFile music_file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///data/Shopen.mp3"));
                var m_stream = await music_file.OpenReadAsync();
                music.SetSource(m_stream, "");
                music.Play();
                isPlaying = true;
            }
            catch (Exception ex){ Debug.WriteLine(ex.Message); isPlaying = false; }
        }
    }
}
