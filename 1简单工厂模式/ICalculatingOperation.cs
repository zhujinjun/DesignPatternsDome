using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1简单工厂模式
{
    public interface ICalculatingOperation
    {
        double StartValue { get;set;}
        double EndValue { get; set; }
        //计算
        double Calculate();
    }
}
