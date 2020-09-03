namespace CurrencyExchangeKiosk
{
    partial class FormPrepaidCardCharging
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textProgressBar1 = new CurrencyExchangeKiosk.TextProgressBar();
            this.colorLabel2 = new CurrencyExchangeKiosk.ColorLabel();
            this.colorLabel1 = new CurrencyExchangeKiosk.ColorLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::CurrencyExchangeKiosk.Properties.Resources.충전할카드_1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1080, 1920);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Resize += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // textProgressBar1
            // 
            this.textProgressBar1.Location = new System.Drawing.Point(288, 1425);
            this.textProgressBar1.Maximum = 0;
            this.textProgressBar1.Name = "textProgressBar1";
            this.textProgressBar1.Size = new System.Drawing.Size(575, 55);
            this.textProgressBar1.TabIndex = 3;
            this.textProgressBar1.Text = "충전상태";
            // 
            // colorLabel2
            // 
            this.colorLabel2.BackColor = System.Drawing.Color.White;
            this.colorLabel2.Font = new System.Drawing.Font("나눔스퀘어", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.colorLabel2.Location = new System.Drawing.Point(267, 1235);
            this.colorLabel2.Name = "colorLabel2";
            this.colorLabel2.Size = new System.Drawing.Size(610, 151);
            this.colorLabel2.TabIndex = 1;
            this.colorLabel2.Text = "충전하고자 하는 카드를 \r\n카드 리더기에 올려주세요";
            this.colorLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorLabel1
            // 
            this.colorLabel1.AutoSize = true;
            this.colorLabel1.BackColor = System.Drawing.Color.White;
            this.colorLabel1.Font = new System.Drawing.Font("나눔스퀘어", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.colorLabel1.Location = new System.Drawing.Point(267, 384);
            this.colorLabel1.Name = "colorLabel1";
            this.colorLabel1.Size = new System.Drawing.Size(531, 53);
            this.colorLabel1.TabIndex = 1;
            this.colorLabel1.Text = "충전할 카드를 올려주세요";
            // 
            // FormPrepaidCardCharging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 1920);
            this.ControlBox = false;
            this.Controls.Add(this.textProgressBar1);
            this.Controls.Add(this.colorLabel2);
            this.Controls.Add(this.colorLabel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrepaidCardCharging";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormPrepaidCardCharging_Load);
            this.Resize += new System.EventHandler(this.FormPrepaidCardCharging_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ColorLabel colorLabel1;
        private ColorLabel colorLabel2;
        private TextProgressBar textProgressBar1;
    }
}