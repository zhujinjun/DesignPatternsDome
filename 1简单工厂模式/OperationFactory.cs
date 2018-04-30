using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1简单工厂模式
{
    /// <summary>
    /// 
    /// </summary>
    public class OperationFactory
    {
        public static ICalculatingOperation CreateOperation(string opertion)
        {
            ICalculatingOperation calculatingOperation=null;
            switch (opertion)
            {
                case "+":
                    calculatingOperation = new OperationAdd();
                    break;
                case "-":
                    calculatingOperation = new OperationSubtract();
                    break;
                case "*":
                    calculatingOperation = new OperationMultiplication();
                    break;
                case "/":
                    calculatingOperation = new OperationDiv();
                    break;
            }
            return calculatingOperation;
        }
    }
}

