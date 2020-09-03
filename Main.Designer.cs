namespace CurrencyExchangeKiosk
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.ButtonEnglish = new System.Windows.Forms.ImageButton();
            this.ButtonRussia = new System.Windows.Forms.ImageButton();
            this.ButtonKorean = new System.Windows.Forms.ImageButton();
            this.ButtonChinese = new System.Windows.Forms.ImageButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblDate = new System.Windows.Forms.Label();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonEnglish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRussia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonKorean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonChinese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            resources.ApplyResources(this.webBrowser1, "webBrowser1");
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            // 
            // TimerLabel
            // 
            resources.ApplyResources(this.TimerLabel, "TimerLabel");
            this.TimerLabel.Name = "TimerLabel";
            // 
            // ButtonEnglish
            // 
            this.ButtonEnglish.BackColor = System.Drawing.Color.Transparent;
            this.ButtonEnglish.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonEnglish.DownImage = global::CurrencyExchangeKiosk.Properties.Resources.english_button;
            resources.ApplyResources(this.ButtonEnglish, "ButtonEnglish");
            this.ButtonEnglish.HoverImage = null;
            this.ButtonEnglish.Name = "ButtonEnglish";
            this.ButtonEnglish.NormalImage = null;
            this.ButtonEnglish.TabStop = false;
            this.ButtonEnglish.Click += new System.EventHandler(this.ButtonEnglish_Click);
            // 
            // ButtonRussia
            // 
            this.ButtonRussia.BackColor = System.Drawing.Color.Transparent;
            this.ButtonRussia.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonRussia.DownImage = global::CurrencyExchangeKiosk.Properties.Resources.russia_button;
            resources.ApplyResources(this.ButtonRussia, "ButtonRussia");
            this.ButtonRussia.HoverImage = null;
            this.ButtonRussia.Name = "ButtonRussia";
            this.ButtonRussia.NormalImage = null;
            this.ButtonRussia.TabStop = false;
            // 
            // ButtonKorean
            // 
            this.ButtonKorean.BackColor = System.Drawing.Color.Transparent;
            this.ButtonKorean.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonKorean.DownImage = global::CurrencyExchangeKiosk.Properties.Resources.korea_button;
            resources.ApplyResources(this.ButtonKorean, "ButtonKorean");
            this.ButtonKorean.HoverImage = null;
            this.ButtonKorean.Name = "ButtonKorean";
            this.ButtonKorean.NormalImage = null;
            this.ButtonKorean.TabStop = false;
            this.ButtonKorean.Click += new System.EventHandler(this.ButtonKorean_Click);
            // 
            // ButtonChinese
            // 
            this.ButtonChinese.BackColor = System.Drawing.Color.Transparent;
            this.ButtonChinese.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonChinese.DownImage = global::CurrencyExchangeKiosk.Properties.Resources.china_button;
            resources.ApplyResources(this.ButtonChinese, "ButtonChinese");
            this.ButtonChinese.HoverImage = null;
            this.ButtonChinese.Name = "ButtonChinese";
            this.ButtonChinese.NormalImage = null;
            this.ButtonChinese.TabStop = false;
            // 
            // gridControl1
            // 
            resources.ApplyResources(this.gridControl1, "gridControl1");
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Resize += new System.EventHandler(this.gridControl1_Resize);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.FixedLine.BackColor2 = ((System.Drawing.Color)(resources.GetObject("gridView1.Appearance.FixedLine.BackColor2")));
            this.gridView1.Appearance.FixedLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.FixedLine.Font = ((System.Drawing.Font)(resources.GetObject("gridView1.Appearance.FixedLine.Font")));
            this.gridView1.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView1.Appearance.FixedLine.Options.UseBorderColor = true;
            this.gridView1.Appearance.FixedLine.Options.UseFont = true;
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.FocusedCell.BackColor2 = ((System.Drawing.Color)(resources.GetObject("gridView1.Appearance.FocusedCell.BackColor2")));
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.FocusedRow.BackColor2 = ((System.Drawing.Color)(resources.GetObject("gridView1.Appearance.FocusedRow.BackColor2")));
            this.gridView1.Appearance.FocusedRow.Font = ((System.Drawing.Font)(resources.GetObject("gridView1.Appearance.FocusedRow.Font")));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.GroupPanel.BackColor2 = ((System.Drawing.Color)(resources.GetObject("gridView1.Appearance.GroupPanel.BackColor2")));
            this.gridView1.Appearance.GroupPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.GroupRow.BackColor2 = ((System.Drawing.Color)(resources.GetObject("gridView1.Appearance.GroupRow.BackColor2")));
            this.gridView1.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.HeaderPanel.BackColor2 = ((System.Drawing.Color)(resources.GetObject("gridView1.Appearance.HeaderPanel.BackColor2")));
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.HeaderPanel.Font = ((System.Drawing.Font)(resources.GetObject("gridView1.Appearance.HeaderPanel.Font")));
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("gridView1.Appearance.HeaderPanel.GradientMode")));
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.Row.BackColor2 = ((System.Drawing.Color)(resources.GetObject("gridView1.Appearance.Row.BackColor2")));
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.Row.Font = ((System.Drawing.Font)(resources.GetObject("gridView1.Appearance.Row.Font")));
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.TopNewRow.BackColor2 = ((System.Drawing.Color)(resources.GetObject("gridView1.Appearance.TopNewRow.BackColor2")));
            this.gridView1.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView1.Appearance.ViewCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.ViewCaption.BackColor2 = ((System.Drawing.Color)(resources.GetObject("gridView1.Appearance.ViewCaption.BackColor2")));
            this.gridView1.Appearance.ViewCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.ViewCaption.Options.UseBackColor = true;
            this.gridView1.Appearance.ViewCaption.Options.UseBorderColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            resources.ApplyResources(this.gridColumn1, "gridColumn1");
            this.gridColumn1.FieldName = "USA";
            this.gridColumn1.ImageOptions.Image = global::CurrencyExchangeKiosk.Properties.Resources.dollar_icon2;
            this.gridColumn1.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            resources.ApplyResources(this.gridColumn2, "gridColumn2");
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            resources.ApplyResources(this.gridColumn3, "gridColumn3");
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            resources.ApplyResources(this.gridColumn4, "gridColumn4");
            this.gridColumn4.Name = "gridColumn4";
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.Name = "lblDate";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.Name = "sqlDataSource2";
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CurrencyExchangeKiosk.Properties.Resources.시안_수정_1_03;
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ButtonChinese);
            this.Controls.Add(this.ButtonKorean);
            this.Controls.Add(this.ButtonRussia);
            this.Controls.Add(this.ButtonEnglish);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.webBrowser1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonEnglish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRussia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonKorean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonChinese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.ImageButton ButtonEnglish;
        private System.Windows.Forms.ImageButton ButtonRussia;
        private System.Windows.Forms.ImageButton ButtonKorean;
        private System.Windows.Forms.ImageButton ButtonChinese;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.Label lblDate;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
    }
}