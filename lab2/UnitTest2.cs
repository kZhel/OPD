using NUnit.Framework;
using lab1_2;

namespace lab2
{
    public class UnitTests_task2
    {
        [Test]
        public void Subscriber1Login()
        {
            Subscriber1 subscriber = new Subscriber1("Kate");
            string name = subscriber.Name;

            string res = "Kate";

            Assert.AreEqual(res, name);
        }

        [Test]
        public void Subscribe2Login()
        {
            Subscriber2 subscriber = new Subscriber2("Kate");
            string name = subscriber.Name;

            string res = "Kate";

            Assert.AreEqual(res, name);
        }

        [Test]
        public void Subscriber3Login()
        {
            Subscriber3 subscriber = new Subscriber3("Kate");
            string name = subscriber.Name;

            string res = "Kate";

            Assert.AreEqual(res, name);
        }
    }
}
