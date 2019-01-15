using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2StrategyPatterns
{
    /// <summary>
    /// 结算上下文，用于配置和维护ISettlement接口
    /// 此处用到了工程模式和策略模式
    /// </summary>
    public class SettleContext
    {
        private ISettlement settlement;
        public SettleContext(string settlType)
        {
            ISettlement settlement=null;
            switch (settlType)
            {
                case "正常结算":
                    settlement = new NormalSettle();
                    break;
                case "八折结算":
                    settlement = new DiscountSettle(0.8);
                    break;
                case "满300减100":
                    settlement = new ReturnSettle(300, 100);
                    break;
            }
            this.settlement = settlement;
        }
        public double ContextInterface(double money)
        {
            return settlement.GetTotal(money);
        }
    }
}
