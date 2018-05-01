using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2StrategyPatterns
{
    public class DiscountSettle: ISettlement
    {
        /// <summary>
        /// 单价
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// 获取总价
        /// </summary>
        /// <returns></returns>
        public double GetTotal()
        {
            return Price * Count * 0.08;
        }
    }
}
