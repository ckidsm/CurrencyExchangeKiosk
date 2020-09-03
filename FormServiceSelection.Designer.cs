namespace CurrencyExchangeKiosk
{
    partial class FormServiceSelection
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServiceSelection));
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageButton1 = new System.Windows.Forms.ImageButton();
            this.imageButton2 = new System.Windows.Forms.ImageButton();
            this.imageButton3 = new System.Windows.Forms.ImageButton();
            this.imageButton4 = new System.Windows.Forms.ImageButton();
            this.lblinfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton4)).BeginInit();
            this.SuspendLayout();
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.Name = "excelDataSource1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageButton1
            // 
            this.imageButton1.BackColor = System.Drawing.Color.Transparent;
            this.imageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imageButton1.DownImage = ((System.Drawing.Image)(resources.GetObject("imageButton1.DownImage")));
            this.imageButton1.Font = new System.Drawing.Font("나눔스퀘어 Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.imageButton1.HoverImage = null;
            this.imageButton1.Location = new System.Drawing.Point(86, 600);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.NormalImage = null;
            this.imageButton1.Size = new System.Drawing.Size(913, 267);
            this.imageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageButton1.TabIndex = 0;
            this.imageButton1.TabStop = false;
            this.imageButton1.Text = "   환전";
            this.imageButton1.Click += new System.EventHandler(this.imageButton1_Click);
            this.imageButton1.Resize += new System.EventHandler(this.imageButton1_Resize);
            // 
            // imageButton2
            // 
            this.imageButton2.BackColor = System.Drawing.Color.Transparent;
            this.imageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imageButton2.DownImage = ((System.Drawing.Image)(resources.GetObject("imageButton2.DownImage")));
            this.imageButton2.Font = new System.Drawing.Font("나눔스퀘어 Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.imageButton2.HoverImage = null;
            this.imageButton2.Location = new System.Drawing.Point(86, 910);
            this.imageButton2.Name = "imageButton2";
            this.imageButton2.NormalImage = null;
            this.imageButton2.Size = new System.Drawing.Size(913, 267);
            this.imageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageButton2.TabIndex = 0;
            this.imageButton2.TabStop = false;
            this.imageButton2.Text = "        선불카드 구매";
            this.imageButton2.Click += new System.EventHandler(this.imageButton2_Click);
            this.imageButton2.Resize += new System.EventHandler(this.imageButton2_Resize);
            // 
            // imageButton3
            // 
            this.imageButton3.BackColor = System.Drawing.Color.Transparent;
            this.imageButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imageButton3.DownImage = ((System.Drawing.Image)(resources.GetObject("imageButton3.DownImage")));
            this.imageButton3.Font = new System.Drawing.Font("나눔스퀘어 Bold", 27.75F, System.Drawing.FontStyle.Bold);
            this.imageButton3.HoverImage = null;
            this.imageButton3.Location = new System.Drawing.Point(86, 1209);
            this.imageButton3.Name = "imageButton3";
            this.imageButton3.NormalImage = null;
            this.imageButton3.Size = new System.Drawing.Size(913, 285);
            this.imageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageButton3.TabIndex = 0;
            this.imageButton3.TabStop = false;
            this.imageButton3.Text = "      선불카드 충전";
            this.imageButton3.Click += new System.EventHandler(this.imageButton3_Click);
            // 
            // imageButton4
            // 
            this.imageButton4.BackColor = System.Drawing.Color.Transparent;
            this.imageButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imageButton4.DownImage = ((System.Drawing.Image)(resources.GetObject("imageButton4.DownImage")));
            this.imageButton4.Font = new System.Drawing.Font("나눔스퀘어 Bold", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.imageButton4.HoverImage = null;
            this.imageButton4.Location = new System.Drawing.Point(86, 1520);
            this.imageButton4.Name = "imageButton4";
            this.imageButton4.NormalImage = null;
            this.imageButton4.Size = new System.Drawing.Size(913, 277);
            this.imageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageButton4.TabIndex = 0;
            this.imageButton4.TabStop = false;
            this.imageButton4.Text = "   잔액 조회";
            this.imageButton4.Click += new System.EventHandler(this.imageButton4_Click);
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.BackColor = System.Drawing.Color.Transparent;
            this.lblinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblinfo.Font = new System.Drawing.Font("나눔스퀘어", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblinfo.Location = new System.Drawing.Point(303, 410);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(497, 56);
            this.lblinfo.TabIndex = 1;
            this.lblinfo.Text = "서비스를 선택해주세요";
            // 
            // FormServiceSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CurrencyExchangeKiosk.Properties.Resources.서비스선택_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 1920);
            this.ControlBox = false;
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.imageButton4);
            this.Controls.Add(this.imageButton3);
            this.Controls.Add(this.imageButton2);
            this.Controls.Add(this.imageButton1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormServiceSelection";
            this.Text = "FormServiceSelection";
            this.Load += new System.EventHandler(this.FormServiceSelection_Load);
            this.Resize += new System.EventHandler(this.FormServiceSelection_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.imageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageButton imageButton1;
        private System.Windows.Forms.ImageButton imageButton2;
        private System.Windows.Forms.ImageButton imageButton3;
        private System.Windows.Forms.ImageButton imageButton4;
        private System.Windows.Forms.Label lblinfo;
    }
}