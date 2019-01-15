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
        /// 获取总价
        /// </summary>
        /// <returns></returns>
        public double GetTotal(double money)
        {            
            var result = money;
            if (result >= moneyCondition)
            {
                result -= moneyReturn;
                //money = money- Math.Floor(money / moneyCondition) * moneyReturn;
            }
            return result;
        }
    }
}
