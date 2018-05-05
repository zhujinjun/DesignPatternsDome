using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2StrategyPatterns
{
    /// <summary>
    /// 打折结算
    /// </summary>
    public class DiscountSettle: ISettlement
    {
        /// <summary>
        /// 打折金额
        /// </summary>
        private double moneyDiscount;
        public DiscountSettle(double moneyDiscount)
        {
            this.moneyDiscount = moneyDiscount;
        }
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
            return Price * Count * moneyDiscount;
        }
    }
}
