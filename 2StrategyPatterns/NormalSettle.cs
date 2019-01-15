using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2StrategyPatterns
{
    /// <summary>
    /// 正常结算
    /// </summary>
    public class NormalSettle: ISettlement
    {
        public double GetTotal(double money)
        {
            return money;
        }
    }
}
