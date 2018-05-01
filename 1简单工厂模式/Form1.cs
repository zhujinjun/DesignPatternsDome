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
            double startValue =0;
            if (!double.TryParse(txtStartValue.Text.Trim(), out startValue))
            {
                MessageBox.Show("输入的第一个计算内容有误，请重新输入!");
                return;
            }            
            double endValue=0;
            if (!double.TryParse(txtEndValue.Text.Trim(), out endValue))
            {
                MessageBox.Show("输入的第二个计算内容有误，请重新输入!");
                return;
            }
            var comOperator = Com_Operator.Text;
            var oper= OperationFactory.CreateOperation(comOperator);
            oper.StartValue = startValue;
            oper.EndValue = endValue;
            var result=oper.Calculate();
            txtResult.Text = result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
