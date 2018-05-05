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
        /// 获取总价
        /// </summary>
        /// <returns></returns>
        public double GetTotal(double money)
        {
            return money * moneyDiscount;
        }
    }
}
