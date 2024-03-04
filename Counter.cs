using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTrainingCounter
{
    public class Counter
    {
        public int StartCount { get; set; }
        public int EndCount { get; set; }
        public int Count { get; set; }

        public event EventHandler<CounterEventArgs> OnPair;

        public Counter(int startCount, int endCount)
        {
            StartCount = startCount;
            EndCount = endCount;
            Count = startCount;
        }

        public void StartCounter() 
        {
            for (int i = StartCount; i <= EndCount; i++)
            {
                Console.Write(Count);

                if (Count % 2 == 0)
                    OnPair?.Invoke(this, new CounterEventArgs(Count));

                Count++;
                Console.WriteLine();
            }
        }
    }
}
