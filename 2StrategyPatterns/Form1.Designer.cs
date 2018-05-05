namespace _2StrategyPatterns
{
    partial class Form
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
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.comSettlementType = new System.Windows.Forms.ComboBox();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(336, 35);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "确 定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "单价：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "数量：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "结算方式：";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl.ForeColor = System.Drawing.Color.Red;
            this.lbl.Location = new System.Drawing.Point(38, 301);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(69, 19);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "总计：";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(336, 80);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "重 置";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(124, 35);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(182, 21);
            this.txtPrice.TabIndex = 6;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(124, 77);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(182, 21);
            this.txtCount.TabIndex = 7;
            // 
            // comSettlementType
            // 
            this.comSettlementType.FormattingEnabled = true;
            this.comSettlementType.Items.AddRange(new object[] {
            "正常结算",
            "八折结算",
            "满300减100"});
            this.comSettlementType.Location = new System.Drawing.Point(124, 122);
            this.comSettlementType.Name = "comSettlementType";
            this.comSettlementType.Size = new System.Drawing.Size(182, 20);
            this.comSettlementType.TabIndex = 8;
            this.comSettlementType.Text = "正常结算";
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(124, 167);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(287, 114);
            this.txtDetail.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "明细：";
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTotal.ForeColor = System.Drawing.Color.Black;
            this.labTotal.Location = new System.Drawing.Point(120, 301);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(53, 19);
            this.labTotal.TabIndex = 10;
            this.labTotal.Text = "0.00";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 351);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.comSettlementType);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Name = "Form";
            this.Text = "收银系统";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.ComboBox comSettlementType;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labTotal;
    }
}

