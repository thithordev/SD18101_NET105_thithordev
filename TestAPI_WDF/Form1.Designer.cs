namespace TestAPI_WDF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tb_money = new TextBox();
            tb_percent = new TextBox();
            label2 = new Label();
            tb_month = new TextBox();
            label3 = new Label();
            btn_tinhtoan = new Button();
            lb_profit = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 0;
            label1.Text = "Tiền gốc:";
            // 
            // tb_money
            // 
            tb_money.Location = new Point(15, 70);
            tb_money.Margin = new Padding(4, 4, 4, 4);
            tb_money.Name = "tb_money";
            tb_money.Size = new Size(278, 29);
            tb_money.TabIndex = 1;
            // 
            // tb_percent
            // 
            tb_percent.Location = new Point(15, 171);
            tb_percent.Margin = new Padding(4, 4, 4, 4);
            tb_percent.Name = "tb_percent";
            tb_percent.Size = new Size(278, 29);
            tb_percent.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 130);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 2;
            label2.Text = "Tỉ lệ lãi:";
            // 
            // tb_month
            // 
            tb_month.Location = new Point(15, 266);
            tb_month.Margin = new Padding(4, 4, 4, 4);
            tb_month.Name = "tb_month";
            tb_month.Size = new Size(278, 29);
            tb_month.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 225);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 4;
            label3.Text = "Số tháng:";
            // 
            // btn_tinhtoan
            // 
            btn_tinhtoan.Location = new Point(15, 321);
            btn_tinhtoan.Margin = new Padding(4, 4, 4, 4);
            btn_tinhtoan.Name = "btn_tinhtoan";
            btn_tinhtoan.Size = new Size(96, 32);
            btn_tinhtoan.TabIndex = 6;
            btn_tinhtoan.Text = "Tính toán:";
            btn_tinhtoan.UseVisualStyleBackColor = true;
            btn_tinhtoan.Click += btn_tinhtoan_Click;
            // 
            // lb_profit
            // 
            lb_profit.AutoSize = true;
            lb_profit.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_profit.Location = new Point(15, 378);
            lb_profit.Margin = new Padding(4, 0, 4, 0);
            lb_profit.Name = "lb_profit";
            lb_profit.Size = new Size(59, 23);
            lb_profit.TabIndex = 7;
            lb_profit.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 423);
            Controls.Add(lb_profit);
            Controls.Add(btn_tinhtoan);
            Controls.Add(tb_month);
            Controls.Add(label3);
            Controls.Add(tb_percent);
            Controls.Add(label2);
            Controls.Add(tb_money);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Tính tiền lãi:";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_money;
        private TextBox tb_percent;
        private Label label2;
        private TextBox tb_month;
        private Label label3;
        private Button btn_tinhtoan;
        private Label lb_profit;
    }
}