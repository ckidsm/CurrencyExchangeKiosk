using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyExchangeKiosk
{
    
    public partial class FormServiceCompleted : Form
    {
        private System.Windows.Forms.Timer timer1;
        private int counter = 5;
        public FormServiceCompleted()
        {
            InitializeComponent();
            fromCountDown();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                timer1.Stop();
               
                this.Close();
                Main from = new Main();

                from.Show();
            }

            lblCountDown.Text = counter.ToString();

        }

        private void fromCountDown()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            lblCountDown.Text = counter.ToString();
        }

        private void label2_Resize(object sender, EventArgs e)
        {

        }

        private void FormServiceCompleted_Resize(object sender, EventArgs e)
        {
            var bgfile = this.BackgroundImage;
            this.SuspendLayout();
            this.BackgroundImage = null;
            this.BackgroundImage = bgfile;
            this.ResumeLayout();
        }
    }
}
