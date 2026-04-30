namespace Poker
{
    partial class frmPoker
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
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnChangeCard = new System.Windows.Forms.Button();
            this.btnDealCard = new System.Windows.Forms.Button();
            this.grpPoker = new System.Windows.Forms.GroupBox();
            this.grpBet = new System.Windows.Forms.GroupBox();
            this.btnBet = new System.Windows.Forms.Button();
            this.txtBetAmount = new System.Windows.Forms.TextBox();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblBetAmount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblLoseStreak = new System.Windows.Forms.Label();
            this.lblWinStreak = new System.Windows.Forms.Label();
            this.grpButton.SuspendLayout();
            this.grpBet.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpButton
            // 
            this.grpButton.Controls.Add(this.lblResult);
            this.grpButton.Controls.Add(this.btnCheck);
            this.grpButton.Controls.Add(this.btnChangeCard);
            this.grpButton.Controls.Add(this.btnDealCard);
            this.grpButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpButton.Location = new System.Drawing.Point(67, 419);
            this.grpButton.Margin = new System.Windows.Forms.Padding(4);
            this.grpButton.Name = "grpButton";
            this.grpButton.Padding = new System.Windows.Forms.Padding(4);
            this.grpButton.Size = new System.Drawing.Size(647, 118);
            this.grpButton.TabIndex = 3;
            this.grpButton.TabStop = false;
            this.grpButton.Text = "功能";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(373, 49);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(265, 38);
            this.lblResult.TabIndex = 3;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(245, 49);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(120, 38);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "判斷牌型";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnChangeCard
            // 
            this.btnChangeCard.Enabled = false;
            this.btnChangeCard.Location = new System.Drawing.Point(137, 49);
            this.btnChangeCard.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeCard.Name = "btnChangeCard";
            this.btnChangeCard.Size = new System.Drawing.Size(100, 38);
            this.btnChangeCard.TabIndex = 1;
            this.btnChangeCard.Text = "換牌";
            this.btnChangeCard.UseVisualStyleBackColor = true;
            this.btnChangeCard.Click += new System.EventHandler(this.btnChangeCard_Click);
            // 
            // btnDealCard
            // 
            this.btnDealCard.Location = new System.Drawing.Point(29, 49);
            this.btnDealCard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDealCard.Name = "btnDealCard";
            this.btnDealCard.Size = new System.Drawing.Size(100, 38);
            this.btnDealCard.TabIndex = 0;
            this.btnDealCard.Text = "發牌";
            this.btnDealCard.UseVisualStyleBackColor = true;
            this.btnDealCard.Click += new System.EventHandler(this.btnDealCard_Click);
            // 
            // grpPoker
            // 
            this.grpPoker.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpPoker.Location = new System.Drawing.Point(67, 48);
            this.grpPoker.Margin = new System.Windows.Forms.Padding(4);
            this.grpPoker.Name = "grpPoker";
            this.grpPoker.Padding = new System.Windows.Forms.Padding(4);
            this.grpPoker.Size = new System.Drawing.Size(647, 200);
            this.grpPoker.TabIndex = 2;
            this.grpPoker.TabStop = false;
            this.grpPoker.Text = "牌桌";
            // 
            // grpBet
            // 
            this.grpBet.Controls.Add(this.btnBet);
            this.grpBet.Controls.Add(this.txtBetAmount);
            this.grpBet.Controls.Add(this.lblTotalValue);
            this.grpBet.Controls.Add(this.lblBetAmount);
            this.grpBet.Controls.Add(this.lblTotalAmount);
            this.grpBet.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpBet.Location = new System.Drawing.Point(67, 277);
            this.grpBet.Margin = new System.Windows.Forms.Padding(4);
            this.grpBet.Name = "grpBet";
            this.grpBet.Padding = new System.Windows.Forms.Padding(4);
            this.grpBet.Size = new System.Drawing.Size(647, 117);
            this.grpBet.TabIndex = 3;
            this.grpBet.TabStop = false;
            this.grpBet.Text = "下注";
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(541, 53);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(97, 38);
            this.btnBet.TabIndex = 4;
            this.btnBet.Text = "押注";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // txtBetAmount
            // 
            this.txtBetAmount.Location = new System.Drawing.Point(370, 55);
            this.txtBetAmount.Name = "txtBetAmount";
            this.txtBetAmount.Size = new System.Drawing.Size(161, 34);
            this.txtBetAmount.TabIndex = 3;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalValue.Location = new System.Drawing.Point(102, 53);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(162, 38);
            this.lblTotalValue.TabIndex = 2;
            // 
            // lblBetAmount
            // 
            this.lblBetAmount.AutoSize = true;
            this.lblBetAmount.Location = new System.Drawing.Point(273, 60);
            this.lblBetAmount.Name = "lblBetAmount";
            this.lblBetAmount.Size = new System.Drawing.Size(92, 25);
            this.lblBetAmount.TabIndex = 1;
            this.lblBetAmount.Text = "押注金額";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(24, 60);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(72, 25);
            this.lblTotalAmount.TabIndex = 0;
            this.lblTotalAmount.Text = "總資金";
            // 
            // lblLoseStreak
            // 
            this.lblLoseStreak.AutoSize = true;
            this.lblLoseStreak.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold);
            this.lblLoseStreak.Location = new System.Drawing.Point(368, 580);
            this.lblLoseStreak.Name = "lblLoseStreak";
            this.lblLoseStreak.Size = new System.Drawing.Size(96, 35);
            this.lblLoseStreak.TabIndex = 8;
            this.lblLoseStreak.Text = "連敗：";
            // 
            // lblWinStreak
            // 
            this.lblWinStreak.AutoSize = true;
            this.lblWinStreak.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold);
            this.lblWinStreak.Location = new System.Drawing.Point(90, 580);
            this.lblWinStreak.Name = "lblWinStreak";
            this.lblWinStreak.Size = new System.Drawing.Size(96, 35);
            this.lblWinStreak.TabIndex = 7;
            this.lblWinStreak.Text = "連勝：";
            // 
            // frmPoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 655);
            this.Controls.Add(this.lblLoseStreak);
            this.Controls.Add(this.lblWinStreak);
            this.Controls.Add(this.grpBet);
            this.Controls.Add(this.grpButton);
            this.Controls.Add(this.grpPoker);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPoker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "五張撲克牌";
            this.grpButton.ResumeLayout(false);
            this.grpBet.ResumeLayout(false);
            this.grpBet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpButton;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnChangeCard;
        private System.Windows.Forms.Button btnDealCard;
        private System.Windows.Forms.GroupBox grpPoker;
        private System.Windows.Forms.GroupBox grpBet;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblBetAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtBetAmount;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Label lblLoseStreak;
        private System.Windows.Forms.Label lblWinStreak;
    }
}