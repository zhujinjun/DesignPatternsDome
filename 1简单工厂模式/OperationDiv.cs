using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1简单工厂模式
{
    /// <summary>
    /// 除法操作
    /// </summary>
    public class OperationDiv : ICalculatingOperation
    {
        public double StartValue { get; set; }
        public double EndValue { get; set; }
        public double Calculate()
        {
            if (EndValue == 0)
                throw new Exception("除数不能为0");
            return StartValue/EndValue;
        }
    }
}
