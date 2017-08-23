using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegateDemo
{
    public delegate int MyEventPointer(int firstNumber, int secondNumber);
    class Program
    {
        static void Main(string[] args)
        {
            //Publisher pub = new Publisher();
            //Subscriber sub1 = new Subscriber("sub1", pub);
            //Subscriber sub2 = new Subscriber("sub2", pub);

            //pub.DoSomething();
            
            Calculator c = new Calculator();
            c.OnMultipleOfFiveReached += new Calculator.MyEventRaiser(MultipleOfFiveReached);
            MyEventPointer p = new MyEventPointer(c.Add);
            Console.WriteLine(p(4, 7));
            Console.WriteLine(p(4, 6));
            Console.WriteLine(p(4, 8));
            Console.ReadKey();


        }
        static void MultipleOfFiveReached()
        {
            Console.WriteLine("Mulitiple of five reached!");
        }
    }

    public class CustomEventAgrs: EventArgs
    {
        public CustomEventAgrs(string s)
        {

        }
        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }

    public class Publisher
    {
        public event EventHandler<CustomEventAgrs> RaiseCustomEvent;

        protected virtual void OnRaiseCustomEvent(CustomEventAgrs e)
        {
            EventHandler<CustomEventAgrs> handler = RaiseCustomEvent;
            if (handler != null)
            {
                e.Message += string.Format("at {0}", DateTime.Now.ToString());
                handler(this, e);
            }
        }
        public void DoSomething()
        {
            OnRaiseCustomEvent(new CustomEventAgrs("Did Something"));
        }
    }

    public class Subscriber
    {
        private string id;
        public Subscriber(string id,Publisher pub)
        {
            this.id = id;
            pub.RaiseCustomEvent += HandleCustomEvent;
        }

        void HandleCustomEvent(object sender,CustomEventAgrs e)
        {
            Console.WriteLine(id + " received this message: {0}", e.Message);
        }
    }
}
