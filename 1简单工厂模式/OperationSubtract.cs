using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1简单工厂模式
{
    /// <summary>
    /// 减法操作
    /// </summary>
    public class OperationSubtract: ICalculatingOperation
    {
        public double StartValue { get; set; }
        public double EndValue { get; set; }        
        public double Calculate()
        {
            return StartValue - EndValue;
        }
    }
}
