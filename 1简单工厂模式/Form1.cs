using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1简单工厂模式
{
    /*
     * 实现一个简单的计算器功能包括加减乘除等功能。
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 计算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {            
            var startValue = txtStartValue.Text.Trim();
            var endValue = txtEndValue.Text.Trim();
            var comOperator = Com_Operator.Text;
            double result =0;
            switch (comOperator)
            {
                case "+":
                    result = new OperationAdd().Calculate();                    
                    break;
                case "-":
                    result = new OperationSubtract().Calculate();
                    break;
                case "*":
                    result = new OperationMultiplication().Calculate();
                    break;
                case "/":
                    result = new OperationDiv().Calculate();
                    break;
            }
            txtResult.Text = result.ToString();
        }
    }
}
