using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_playground
{
    class QueueClass 
    {
        //Queue (pronounced: kju) - Represents a first-in, first-out (FIFO) collection of objects.


        public static void PrintQueueMemeber()
        {
            Queue<string> _myQueue = new Queue<string>();

            _myQueue.Enqueue("First");
            _myQueue.Enqueue("Second");
            _myQueue.Enqueue("Third");
            while (_myQueue.Count > 0)
            {
                Console.WriteLine("Peek-a-boo: {0}", _myQueue.Peek());
                Console.WriteLine("Dequeue: {0}", _myQueue.Dequeue());
            }
        }

    }
}
