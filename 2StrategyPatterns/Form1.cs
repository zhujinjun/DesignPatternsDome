using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2StrategyPatterns
{
    /// <summary>
    /// 此示例主要介绍策略模式
    /// </summary>
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double price = 0;
            if (!double.TryParse(txtPrice.Text.Trim(), out price))
            {
                MessageBox.Show("单价输入有误，请重新输入!");
                return;
            }
            int count = 0;
            if (!int.TryParse(txtCount.Text.Trim(), out count))
            {
                MessageBox.Show("数量输入有误，请重新输入!");
                return;
            }
            var settlType = this.comSettlementType.Text;
            var settlement = SettleFactory.CreatSettlement(settlType);
            if (settlement != null)
            {
                settlement.Price = price;
                settlement.Count = count;
                var total = settlement.GetTotal();
                labTotal.Text = total.ToString();
            }
        }
    }
}
