using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class EventSubscriber
    {
        public static void ElementAdded(object sender, CustomEventArgs e)
        {
            Console.WriteLine("Sender: " + sender);
            Console.WriteLine("Added item is: " + e.message);
            Console.WriteLine();
        }
        public static void ElementRemoved(object sender, CustomEventArgs e)
        {
            Console.WriteLine("Sender: " + sender);
            Console.WriteLine($"Removed from {e.message} index");
            Console.WriteLine();
        }
    }
}
