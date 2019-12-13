using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Observer
{
    class Observer : IObserver
    {
        string name;

        ISubject subject;

        string state;

        public string stateNow; //для передачи в текстбокс

        string gap;

        public Observer(ISubject subject, string name, string gap)
        {
            this.subject = subject;
            this.name = name;
            this.gap = gap;
            subject.AddObserver(this);
        }

        public void Update(string subjectState)
        {
            state = subjectState;
            stateNow += state + "\t";
        }
    }
}
