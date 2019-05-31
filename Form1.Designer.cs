namespace Assignment1_ElizabethLombardi
{
    partial class EL_Assign1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EL_Assign1));
            this.lblSavingsAcct = new System.Windows.Forms.Label();
            this.btnOpenNewAcct = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmt = new System.Windows.Forms.Label();
            this.lblDollar = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnCalcInterest = new System.Windows.Forms.Button();
            this.lblBalanceTxt = new System.Windows.Forms.Label();
            this.lblBalanceAmt = new System.Windows.Forms.Label();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSavingsAcct
            // 
            this.lblSavingsAcct.AutoSize = true;
            this.lblSavingsAcct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavingsAcct.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSavingsAcct.Location = new System.Drawing.Point(23, 23);
            this.lblSavingsAcct.Name = "lblSavingsAcct";
            this.lblSavingsAcct.Size = new System.Drawing.Size(138, 19);
            this.lblSavingsAcct.TabIndex = 0;
            this.lblSavingsAcct.Text = "Savings Account";
            // 
            // btnOpenNewAcct
            // 
            this.btnOpenNewAcct.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenNewAcct.Location = new System.Drawing.Point(26, 88);
            this.btnOpenNewAcct.Name = "btnOpenNewAcct";
            this.btnOpenNewAcct.Size = new System.Drawing.Size(125, 28);
            this.btnOpenNewAcct.TabIndex = 1;
            this.btnOpenNewAcct.Text = "Open New Account";
            this.btnOpenNewAcct.UseVisualStyleBackColor = true;
            this.btnOpenNewAcct.Click += new System.EventHandler(this.BtnOpenNewAcct_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(103, 149);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(139, 22);
            this.txtAmount.TabIndex = 2;
            // 
            // lblAmt
            // 
            this.lblAmt.AutoSize = true;
            this.lblAmt.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmt.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAmt.Location = new System.Drawing.Point(23, 151);
            this.lblAmt.Name = "lblAmt";
            this.lblAmt.Size = new System.Drawing.Size(61, 16);
            this.lblAmt.TabIndex = 3;
            this.lblAmt.Text = "Amount:";
            // 
            // lblDollar
            // 
            this.lblDollar.AutoSize = true;
            this.lblDollar.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDollar.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDollar.Location = new System.Drawing.Point(88, 151);
            this.lblDollar.Name = "lblDollar";
            this.lblDollar.Size = new System.Drawing.Size(15, 16);
            this.lblDollar.TabIndex = 4;
            this.lblDollar.Text = "$";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPercent.Location = new System.Drawing.Point(479, 151);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(18, 16);
            this.lblPercent.TabIndex = 7;
            this.lblPercent.Text = "%";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestRate.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblInterestRate.Location = new System.Drawing.Point(308, 151);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(92, 16);
            this.lblInterestRate.TabIndex = 6;
            this.lblInterestRate.Text = "Interest Rate:";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterestRate.Location = new System.Drawing.Point(405, 149);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(74, 22);
            this.txtInterestRate.TabIndex = 5;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Location = new System.Drawing.Point(26, 181);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(105, 28);
            this.btnDeposit.TabIndex = 8;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.BtnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.Location = new System.Drawing.Point(137, 181);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(105, 28);
            this.btnWithdraw.TabIndex = 9;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.BtnWithdraw_Click);
            // 
            // btnCalcInterest
            // 
            this.btnCalcInterest.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcInterest.Location = new System.Drawing.Point(311, 181);
            this.btnCalcInterest.Name = "btnCalcInterest";
            this.btnCalcInterest.Size = new System.Drawing.Size(105, 28);
            this.btnCalcInterest.TabIndex = 10;
            this.btnCalcInterest.Text = "Calculate Interest";
            this.btnCalcInterest.UseVisualStyleBackColor = true;
            this.btnCalcInterest.Click += new System.EventHandler(this.BtnCalcInterest_Click);
            // 
            // lblBalanceTxt
            // 
            this.lblBalanceTxt.AutoSize = true;
            this.lblBalanceTxt.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceTxt.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblBalanceTxt.Location = new System.Drawing.Point(23, 256);
            this.lblBalanceTxt.Name = "lblBalanceTxt";
            this.lblBalanceTxt.Size = new System.Drawing.Size(64, 16);
            this.lblBalanceTxt.TabIndex = 13;
            this.lblBalanceTxt.Text = "Balance:";
            // 
            // lblBalanceAmt
            // 
            this.lblBalanceAmt.AutoSize = true;
            this.lblBalanceAmt.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceAmt.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblBalanceAmt.Location = new System.Drawing.Point(88, 256);
            this.lblBalanceAmt.Name = "lblBalanceAmt";
            this.lblBalanceAmt.Size = new System.Drawing.Size(40, 16);
            this.lblBalanceAmt.TabIndex = 14;
            this.lblBalanceAmt.Text = "$0.00";
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMsg.Location = new System.Drawing.Point(27, 227);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMsg.TabIndex = 15;
            // 
            // EL_Assign1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(521, 293);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.lblBalanceAmt);
            this.Controls.Add(this.lblBalanceTxt);
            this.Controls.Add(this.btnCalcInterest);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.lblDollar);
            this.Controls.Add(this.lblAmt);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnOpenNewAcct);
            this.Controls.Add(this.lblSavingsAcct);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EL_Assign1";
            this.Text = "Savings Account Example";
            this.Load += new System.EventHandler(this.EL_Assign1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSavingsAcct;
        private System.Windows.Forms.Button btnOpenNewAcct;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmt;
        private System.Windows.Forms.Label lblDollar;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnCalcInterest;
        private System.Windows.Forms.Label lblBalanceTxt;
        private System.Windows.Forms.Label lblBalanceAmt;
        private System.Windows.Forms.Label lblErrorMsg;
    }
}

