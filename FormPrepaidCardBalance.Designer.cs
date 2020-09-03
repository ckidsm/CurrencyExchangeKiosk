namespace CurrencyExchangeKiosk
{
    partial class FormPrepaidCardBalance
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(208, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(648, 56);
            this.label2.TabIndex = 2;
            this.label2.Text = "선불카드 잔액을 확인해주세요";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(558, 1603);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 199);
            this.label1.TabIndex = 3;
            this.label1.Text = "확인";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(64, 1589);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 199);
            this.label3.TabIndex = 3;
            this.label3.Text = "충전하기";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(106, 1160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(833, 199);
            this.label4.TabIndex = 3;
            this.label4.Text = "잔액이 부족할 경우 충전하기를 통해\r\n선불카드를 충전해주세요\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Result
            // 
            this.textBox_Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Result.Font = new System.Drawing.Font("나눔스퀘어", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Result.Location = new System.Drawing.Point(118, 623);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_Result.Size = new System.Drawing.Size(678, 179);
            this.textBox_Result.TabIndex = 6;
            this.textBox_Result.Text = "\r\n15,500";
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Result.WordWrap = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(802, 651);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 113);
            this.label5.TabIndex = 2;
            this.label5.Text = "KGS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPrepaidCardBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CurrencyExchangeKiosk.Properties.Resources.선불카드잔액확인_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 1920);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrepaidCardBalance";
            this.Text = "FormPrepaidCardBalance";
            this.RegionChanged += new System.EventHandler(this.FormPrepaidCardBalance_RegionChanged);
            this.Resize += new System.EventHandler(this.FormPrepaidCardBalance_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label label5;
    }
}