using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Pattern_Observer
{
    class Subject : ISubject
    {
        public string SubjectState { get; set; }
        public List<IObserver> Observers { get; private set; }

        public Simulator simulator;


        public Subject()
        {
            Observers = new List<IObserver>();
            simulator = new Simulator();
        }

        public void AddObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void NotifyObservers(string s)
        {
            foreach (var observer in Observers)
            {
                observer.Update(s);
            }
        }

        public void Go()
        {
            new Thread(new ThreadStart(Run)).Start();
        }

        void Run()
        {
            string s = String.Empty;
            string[] moves = simulator.GetState();
            for (int i=0; i<4; i++) //сверху направо
            {
                s = moves[i];
                SubjectState = s;
                NotifyObservers(s);

            }
        }
    }
}
