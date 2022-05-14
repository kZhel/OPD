using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_2
{
    public class Subscriber1 : ISubscribers
    {
        private string name;
        public Subscriber1(string name)
        {
            this.name = name;
        }

        public string Name { get { return name; } }

        public void actionForSub(string mess)
        {
            Console.WriteLine(mess + "первого подписчика: " + name );
        }
    }
}
