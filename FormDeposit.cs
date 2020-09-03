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
    
    public partial class FormDeposit : Form
    {
        Comom ComomClass = new Comom();
        public FormDeposit()
        {
            InitializeComponent();

            //this.Location = Screen.AllScreens[1].WorkingArea.Location;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void imageButton1_Click(object sender, EventArgs e)
        {
          
           

            NextFrom(out var @from);

        }
        private void NextFrom(out FormDepositProgress @from)
        {
            ComomClass.PlaySound();
            this.Close();
            @from = new FormDepositProgress();
          
            @from.Show();

        }

        private void imageButton2_Click(object sender, EventArgs e)
        {
            ComomClass.PlaySound();
        }
    }
}
