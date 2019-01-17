namespace _1简单工厂模式
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalculate = new System.Windows.Forms.Button();
            this.Com_Operator = new System.Windows.Forms.ComboBox();
            this.txtStartValue = new System.Windows.Forms.TextBox();
            this.txtEndValue = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(122, 144);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "计 算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // Com_Operator
            // 
            this.Com_Operator.FormattingEnabled = true;
            this.Com_Operator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.Com_Operator.Location = new System.Drawing.Point(201, 82);
            this.Com_Operator.Name = "Com_Operator";
            this.Com_Operator.Size = new System.Drawing.Size(36, 20);
            this.Com_Operator.TabIndex = 1;
            this.Com_Operator.Text = "+";
            // 
            // txtStartValue
            // 
            this.txtStartValue.Location = new System.Drawing.Point(122, 82);
            this.txtStartValue.Name = "txtStartValue";
            this.txtStartValue.Size = new System.Drawing.Size(56, 21);
            this.txtStartValue.TabIndex = 2;
            // 
            // txtEndValue
            // 
            this.txtEndValue.Location = new System.Drawing.Point(259, 81);
            this.txtEndValue.Name = "txtEndValue";
            this.txtEndValue.Size = new System.Drawing.Size(58, 21);
            this.txtEndValue.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(122, 38);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(195, 21);
            this.txtResult.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "计算结果：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 244);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtEndValue);
            this.Controls.Add(this.txtStartValue);
            this.Controls.Add(this.Com_Operator);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ComboBox Com_Operator;
        private System.Windows.Forms.TextBox txtStartValue;
        private System.Windows.Forms.TextBox txtEndValue;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
    }
}

