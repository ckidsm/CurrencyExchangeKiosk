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
    public partial class FormDepositProgress : Form
    {
        Comom ComomClass = new Comom();
        private System.Windows.Forms.Timer timer1;
        private int counter = 0;
        public FormDepositProgress()
        {
            InitializeComponent();
            fromCountDown();
        }

        private void imageButton1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            ComomClass.PlaySound();

            this.Close();
           // FormInformationAmountExchange from = new FormInformationAmountExchange();
            FormServiceInfo from = new FormServiceInfo();
            from.Show();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void fromCountDown()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            libCurrencyExchangeAmount.Text = counter + " USD";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 100)
            {
                timer1.Stop();

               
            }

            libCurrencyExchangeAmount.Text = counter.ToString() +" USD";

        }
    }
}
