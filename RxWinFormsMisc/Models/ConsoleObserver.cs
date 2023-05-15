using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxWinFormsMisc.Models
{
    public class ConsoleObserver<T> : IObserver<T>
    {
        void IObserver<T>.OnCompleted()
        {
            Console.WriteLine("Sequence Terminated");
        }

        void IObserver<T>.OnError(Exception error)
        {
            Console.WriteLine("Sequence faulted with {0}",error);
        }

        void IObserver<T>.OnNext(T value)
        {
            Console.WriteLine("Received value {0}",value);
        }
    }
}
