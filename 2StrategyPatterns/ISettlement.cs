using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2StrategyPatterns
{
    /// <summary>
    /// 结算接口
    /// </summary>
    public interface ISettlement
    {
        /// <summary>
        /// 单价
        /// </summary>
        double Price { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        int Count { get; set; }
        /// <summary>
        /// 获取总价
        /// </summary>
        /// <returns></returns>
        double GetTotal();
    }
}
