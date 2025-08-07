using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace DynamicWeatherUpdates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<string> weatherUpdates = new ObservableCollection<string>();

            weatherUpdates.CollectionChanged += (sender, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                    Console.WriteLine($"Weather Update: {e.NewItems[0]}");

            };

            weatherUpdates.Add("New York: Sunny, 25°");
            weatherUpdates.Add("London: Rainy, 15°");

            Console.ReadKey();
        }
    }
}
