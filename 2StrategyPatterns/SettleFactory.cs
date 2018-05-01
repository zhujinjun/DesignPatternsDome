using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2StrategyPatterns
{
    /// <summary>
    /// 结算工厂类
    /// </summary>
    public class SettleFactory
    {
        /// <summary>
        /// 创建结算方式
        /// </summary>
        public static ISettlement CreatSettlement(string settlType)
        {
            ISettlement settlement = null;
            switch (settlType)
            {
                case "正常结算":
                    settlement = new NormalSettle();
                    break;
                case "八折结算":
                    settlement = new DiscountSettle();
                    break;
            }
            return settlement;
        }
    }
}
