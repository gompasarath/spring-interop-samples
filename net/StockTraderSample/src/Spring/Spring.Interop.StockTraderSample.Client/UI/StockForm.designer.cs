namespace Spring.Interop.StockTraderSample.Client.UI
{
    partial class StockForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tradeRequestButton = new System.Windows.Forms.Button();
            this.tradeRequestStatusTextBox = new System.Windows.Forms.TextBox();
            this.marketDataListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRoutingKey = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tradeQuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.accountNameTextBox = new System.Windows.Forms.TextBox();
            this.failedTradesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tradeQuantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tradeRequestButton
            // 
            this.tradeRequestButton.Location = new System.Drawing.Point(12, 38);
            this.tradeRequestButton.Name = "tradeRequestButton";
            this.tradeRequestButton.Size = new System.Drawing.Size(135, 23);
            this.tradeRequestButton.TabIndex = 0;
            this.tradeRequestButton.Text = "Send Trade Request";
            this.tradeRequestButton.UseVisualStyleBackColor = true;
            this.tradeRequestButton.Click += new System.EventHandler(this.OnSendTradeRequest);
            // 
            // tradeRequestStatusTextBox
            // 
            this.tradeRequestStatusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tradeRequestStatusTextBox.Location = new System.Drawing.Point(154, 39);
            this.tradeRequestStatusTextBox.Name = "tradeRequestStatusTextBox";
            this.tradeRequestStatusTextBox.Size = new System.Drawing.Size(192, 20);
            this.tradeRequestStatusTextBox.TabIndex = 1;
            // 
            // marketDataListBox
            // 
            this.marketDataListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marketDataListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.marketDataListBox.FormattingEnabled = true;
            this.marketDataListBox.ItemHeight = 14;
            this.marketDataListBox.Location = new System.Drawing.Point(90, 153);
            this.marketDataListBox.Name = "marketDataListBox";
            this.marketDataListBox.Size = new System.Drawing.Size(339, 228);
            this.marketDataListBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Market Data :";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(90, 128);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(171, 128);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(355, 128);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Routing Key :";
            // 
            // txtRoutingKey
            // 
            this.txtRoutingKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRoutingKey.Location = new System.Drawing.Point(90, 84);
            this.txtRoutingKey.Name = "txtRoutingKey";
            this.txtRoutingKey.Size = new System.Drawing.Size(258, 20);
            this.txtRoutingKey.TabIndex = 1;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(354, 84);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "i.e. APP.STOCK.QUOTES.nasdaq.MSFT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Qty :";
            // 
            // tradeQuantityNumericUpDown
            // 
            this.tradeQuantityNumericUpDown.Location = new System.Drawing.Point(386, 38);
            this.tradeQuantityNumericUpDown.Name = "tradeQuantityNumericUpDown";
            this.tradeQuantityNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.tradeQuantityNumericUpDown.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Account Name :";
            // 
            // accountNameTextBox
            // 
            this.accountNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountNameTextBox.Location = new System.Drawing.Point(154, 9);
            this.accountNameTextBox.Name = "accountNameTextBox";
            this.accountNameTextBox.Size = new System.Drawing.Size(192, 20);
            this.accountNameTextBox.TabIndex = 1;
            // 
            // failedTradesButton
            // 
            this.failedTradesButton.Location = new System.Drawing.Point(90, 387);
            this.failedTradesButton.Name = "failedTradesButton";
            this.failedTradesButton.Size = new System.Drawing.Size(340, 23);
            this.failedTradesButton.TabIndex = 8;
            this.failedTradesButton.Text = "Show Failed Trades";
            this.failedTradesButton.UseVisualStyleBackColor = true;
            this.failedTradesButton.Click += new System.EventHandler(this.failedTradesButton_Click);
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 422);
            this.Controls.Add(this.failedTradesButton);
            this.Controls.Add(this.tradeQuantityNumericUpDown);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.marketDataListBox);
            this.Controls.Add(this.txtRoutingKey);
            this.Controls.Add(this.accountNameTextBox);
            this.Controls.Add(this.tradeRequestStatusTextBox);
            this.Controls.Add(this.tradeRequestButton);
            this.Name = "StockForm";
            this.Text = "TradeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StockForm_FormClosing);
            this.Load += new System.EventHandler(this.StockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tradeQuantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tradeRequestButton;
        private System.Windows.Forms.TextBox tradeRequestStatusTextBox;
        private System.Windows.Forms.ListBox marketDataListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRoutingKey;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown tradeQuantityNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox accountNameTextBox;
        private System.Windows.Forms.Button failedTradesButton;
    }
}