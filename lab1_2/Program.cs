namespace lab1_2
{
    public static class Program
    {
        static void Main()
        {
            Subscriber1 sub1 = new Subscriber1("Dasha");
            Subscriber2 sub2 = new Subscriber2("Lisa");
            Subscriber3 sub3 = new Subscriber3("Kate");

            Countdown countdown = new Countdown();

            countdown.subscribe(sub1);
            countdown.subscribe(sub2);
            countdown.subscribe(sub3);

            Console.WriteLine("Введите время ожидания: ");
            int time = Convert.ToInt32(Console.ReadLine());
            countdown.notifySubscribers(time);
        }
    }
}
