using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4EventPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            PublisherIncrementer incrementer = new PublisherIncrementer();
            var dozen = new SubscriberDozens(incrementer);
            incrementer.DoCount();
            Console.WriteLine("计数：{0}", dozen.DozensCount);
        }
    }
}
