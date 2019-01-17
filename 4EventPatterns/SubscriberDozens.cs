using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4EventPatterns
{
    /// <summary>
    /// 订阅者类
    /// </summary>
    public class SubscriberDozens
    {
        public int DozensCount { get; set; }
        public SubscriberDozens(PublisherIncrementer incrementer)
        {
            DozensCount = 0;
            incrementer.CountedADozen +=new Handler(IncrementDozensCount);   //订阅事件
        }
        void IncrementDozensCount()
        {
            DozensCount++;    //声明事件处理
        }
    }
}
