using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace DynamicListOfStudentsInClassroom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<string> studnets = new ObservableCollection<string>();

            studnets.CollectionChanged += (sender, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                    Console.WriteLine($"New Student Added: {e.NewItems[0]}");
                if (e.Action == NotifyCollectionChangedAction.Remove)
                    Console.WriteLine($"Student Removed: {e.OldItems[0]}");
            };

            studnets.Add("Alice");
            studnets.Add("Bob");
            studnets.Remove("Alice");
            Console.ReadKey();
        }
    }
}
