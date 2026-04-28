namespace Poker
{
    partial class frmPicTest
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
            this.lblNum = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.picTest = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTest)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNum.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNum.Location = new System.Drawing.Point(154, 124);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(73, 39);
            this.lblNum.TabIndex = 5;
            this.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.Lavender;
            this.btnTest.Font = new System.Drawing.Font("Microsoft JhengHei", 16F);
            this.btnTest.Location = new System.Drawing.Point(154, 48);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(73, 73);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "換牌";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // picTest
            // 
            this.picTest.Image = global::Poker.Properties.Resources.back;
            this.picTest.Location = new System.Drawing.Point(63, 48);
            this.picTest.Name = "picTest";
            this.picTest.Size = new System.Drawing.Size(85, 115);
            this.picTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTest.TabIndex = 3;
            this.picTest.TabStop = false;
            // 
            // frmPicTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 211);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.picTest);
            this.Name = "frmPicTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "圖片測試資源";
            ((System.ComponentModel.ISupportInitialize)(this.picTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.PictureBox picTest;
    }
}

