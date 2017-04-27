using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.Storage;
using Windows.UI.Xaml.Controls;

namespace Цей_день
{
    public sealed partial class ResultPage : Page
    {
        private ObservableCollection<string> findByQuery(string query, List<Day> days){
            ObservableCollection<string> result = new ObservableCollection<string>();
            foreach (Day d in days)
                foreach (string text in d.description)
                    if (text.Contains(query)){
                        string tmp = System.DateTimeOffset.Parse(d.day_num.ToString() + "/" + d.month_num.ToString() + "/"+Today.Year.ToString()).ToString("dd MMMM") + " :";
                        if ((result.Count < 2) || (result.Count > 1 && result[result.Count - 2] != tmp))
                            result.Add(tmp);
                        result.Add(text);
                    }
            return result;
        }
        private ObservableCollection<string> findByDate(int id, List<Day> days)
        {
            id = (id==0) ? (int)( Today - new DateTime(Today.Year, 1, 1)).TotalDays : id;
            ObservableCollection<string> result = new ObservableCollection<string>();
            result.Add(System.DateTimeOffset.Parse(days[id].day_num.ToString() + "/" + days[id].month_num.ToString() + "/" + Today.Year.ToString()).ToString("dd MMMM") + " в історії :");
            foreach (string text in days[id].description)
                result.Add(text);
            return result;
        }
    }
}