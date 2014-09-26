using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _02.AsynchronousTimer
{
    class AsyncTimer
    {
        private int ticks;
        private int interval;
        private Action method;

        public AsyncTimer(int ticks, int interval, Action method)
        {
            this.Ticks = ticks;
            this.Interval = interval;
            this.method = method;
        }

        public int Ticks { get { return this.ticks; } private set { this.ticks = value; } }

        public int Interval { get { return this.interval; } private set { this.interval = value; } }

        public virtual void run()
        {
            if (null != this.method)
            {
                Thread newThread = new Thread(() =>
                {
                    int tickCount = 0;
                    while (tickCount < this.Ticks)
                    {
                        this.method();
                        tickCount++;
                        Thread.Sleep(this.Interval);
                    }
                });
                newThread.Start();
            }
        }
    }
}
