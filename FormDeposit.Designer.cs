namespace CurrencyExchangeKiosk
{
    partial class FormDeposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeposit));
            this.imageButton1 = new System.Windows.Forms.ImageButton();
            this.imageButton2 = new System.Windows.Forms.ImageButton();
            this.imageButton3 = new System.Windows.Forms.ImageButton();
            this.imageButton4 = new System.Windows.Forms.ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton4)).BeginInit();
            this.SuspendLayout();
            // 
            // imageButton1
            // 
            this.imageButton1.BackColor = System.Drawing.Color.Transparent;
            this.imageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imageButton1.DownImage = ((System.Drawing.Image)(resources.GetObject("imageButton1.DownImage")));
            this.imageButton1.Font = new System.Drawing.Font("나눔스퀘어 Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.imageButton1.HoverImage = null;
            this.imageButton1.Location = new System.Drawing.Point(79, 609);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.NormalImage = null;
            this.imageButton1.Size = new System.Drawing.Size(913, 267);
            this.imageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageButton1.TabIndex = 1;
            this.imageButton1.TabStop = false;
            this.imageButton1.Text = "   현금";
            this.imageButton1.Click += new System.EventHandler(this.imageButton1_Click);
            // 
            // imageButton2
            // 
            this.imageButton2.BackColor = System.Drawing.Color.Transparent;
            this.imageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imageButton2.DownImage = ((System.Drawing.Image)(resources.GetObject("imageButton2.DownImage")));
            this.imageButton2.Font = new System.Drawing.Font("나눔스퀘어 Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.imageButton2.HoverImage = null;
            this.imageButton2.Location = new System.Drawing.Point(79, 913);
            this.imageButton2.Name = "imageButton2";
            this.imageButton2.NormalImage = null;
            this.imageButton2.Size = new System.Drawing.Size(913, 267);
            this.imageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageButton2.TabIndex = 1;
            this.imageButton2.TabStop = false;
            this.imageButton2.Click += new System.EventHandler(this.imageButton2_Click);
            // 
            // imageButton3
            // 
            this.imageButton3.BackColor = System.Drawing.Color.Transparent;
            this.imageButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imageButton3.DownImage = ((System.Drawing.Image)(resources.GetObject("imageButton3.DownImage")));
            this.imageButton3.Font = new System.Drawing.Font("나눔스퀘어 Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.imageButton3.HoverImage = null;
            this.imageButton3.Location = new System.Drawing.Point(79, 1219);
            this.imageButton3.Name = "imageButton3";
            this.imageButton3.NormalImage = null;
            this.imageButton3.Size = new System.Drawing.Size(913, 267);
            this.imageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageButton3.TabIndex = 1;
            this.imageButton3.TabStop = false;
            // 
            // imageButton4
            // 
            this.imageButton4.BackColor = System.Drawing.Color.Transparent;
            this.imageButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imageButton4.DownImage = ((System.Drawing.Image)(resources.GetObject("imageButton4.DownImage")));
            this.imageButton4.Font = new System.Drawing.Font("나눔스퀘어 Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.imageButton4.HoverImage = null;
            this.imageButton4.Location = new System.Drawing.Point(79, 1518);
            this.imageButton4.Name = "imageButton4";
            this.imageButton4.NormalImage = null;
            this.imageButton4.Size = new System.Drawing.Size(913, 267);
            this.imageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageButton4.TabIndex = 1;
            this.imageButton4.TabStop = false;
            // 
            // FormDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CurrencyExchangeKiosk.Properties.Resources.입금수단_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 1920);
            this.Controls.Add(this.imageButton4);
            this.Controls.Add(this.imageButton3);
            this.Controls.Add(this.imageButton2);
            this.Controls.Add(this.imageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDeposit";
            ((System.ComponentModel.ISupportInitialize)(this.imageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageButton imageButton1;
        private System.Windows.Forms.ImageButton imageButton2;
        private System.Windows.Forms.ImageButton imageButton3;
        private System.Windows.Forms.ImageButton imageButton4;
    }
}