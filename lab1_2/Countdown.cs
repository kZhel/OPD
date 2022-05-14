using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_2
{
    public class Countdown
    {
        private List<ISubscribers> subscribers;

        public Countdown()
        {
            subscribers = new List<ISubscribers>();
        }

        public List<ISubscribers> Subscribers
        {

            get { return subscribers; }
        }

        public void subscribe(ISubscribers subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void unsubscribe(ISubscribers subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void notifySubscribers(int time)
        {
            foreach (ISubscribers subscriber in subscribers)
            {
                Thread.Sleep(time);
                Console.WriteLine("Ожидание: " + time.ToString() + " ms");
                subscriber.actionForSub("Имя ");
            }
        }


    }


}
