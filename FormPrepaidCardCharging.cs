using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CurrencyExchangeKiosk
{
    public partial class FormPrepaidCardCharging : Form
    {
        private System.Windows.Forms.Timer timer1;
        private int counter = 5;
        public FormPrepaidCardCharging()
        {

            //this.Location = Screen.AllScreens[1].WorkingArea.Location;
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();

           
        }

        private void NewMethod()

        {
            //textProgressBar textProgressBar = new textProgressBar();
            //TextProgressBar textProgressBar  = new TextProgressBar();

            textProgressBar1.Minimum = 0;
            textProgressBar1.Value = 0;
            textProgressBar1.Maximum = 1000;
            textProgressBar1.Text = "";

            for (int j = 0; j < this.textProgressBar1.Maximum; j++)
            {
               // Thread.Sleep(50);
              //  textProgressBar1.PerformStep();
                textProgressBar1.Value = j;
                textProgressBar1.Text = "충전중" + j.ToString() + " of " + textProgressBar1.Maximum.ToString() + " ...";
            
            }

            //this.Close();

            //FormPrepaidCardBalance from = new FormPrepaidCardBalance();
            //from.Show();

            //for (int iIdx = 0; iIdx <= textProgressBar.Maximum; iIdx++)
            //{
            //    textProgressBar.Text = "Item " + iIdx.ToString() + " of " + textProgressBar.Maximum.ToString() + " ...";
            //    textProgressBar.Value = iIdx;
            //}

            fromCountDown();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                timer1.Stop();
                this.Close();

                FormPrepaidCardBalance from = new FormPrepaidCardBalance();
                from.Show();
            }

         

        }

        private void fromCountDown()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
           
        }

        private void FormPrepaidCardCharging_Load(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            var bgfile = this.BackgroundImage;
            this.SuspendLayout();
            this.BackgroundImage = null;
            this.BackgroundImage = bgfile;
            this.ResumeLayout();
        }

        private void FormPrepaidCardCharging_Resize(object sender, EventArgs e)
        {
            NewMethod();
        }
    }
}
