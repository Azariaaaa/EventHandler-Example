using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTrainingCounter
{
    public class CounterEventArgs : EventArgs
    {
        public int Count { get; set; }

        public CounterEventArgs(int count)
        {
            Count = count;
        }
    }
}
