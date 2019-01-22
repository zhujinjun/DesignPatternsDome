using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4EventPatterns
{
    //声明委托
    //public delegate void Handler();

    /// <summary>
    /// 发布者
    /// </summary>
    public class PublisherIncrementer
    {        
        //事件声明
        public event EventHandler<IncrementerEventArgs> CountedADozen;
        public void DoCount()
        {
            var incrementerEventArgs = new IncrementerEventArgs();
            for (int i = 1; i <100; i++)
            {
                if (i % 12 == 0 && CountedADozen != null)
                {
                    incrementerEventArgs.IterationCount = i;
                    //触发事件代码
                    CountedADozen(this, incrementerEventArgs);
                }
            }
        }
    }
    public class IncrementerEventArgs : EventArgs
    {
        public int IterationCount { get; set; }
    }
}
