using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2StrategyPatterns
{
    /// <summary>
    /// 满额返利
    /// </summary>
    public class ReturnSettle:ISettlement
    {
        /// <summary>
        /// 返利条件
        /// </summary>
        public double moneyCondition;
        /// <summary>
        /// 返利金额
        /// </summary>
        public double moneyReturn;
        public ReturnSettle(double moneyCondition,double moneyReturn)
        {
            this.moneyCondition = moneyCondition;
            this.moneyReturn = moneyReturn;
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
            var money=Price * Count;
            if (money > moneyCondition)
            {
                money-=moneyReturn;
                //money = money- Math.Floor(money / moneyCondition) * moneyReturn;
            }
            return money;
        }
    }
}
