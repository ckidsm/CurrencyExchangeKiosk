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
    public partial class FormPrepaidCardBalance : Form
    {
        public FormPrepaidCardBalance()
        {
            InitializeComponent();
            //this.Location = Screen.AllScreens[1].WorkingArea.Location;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

            this.Close();
            Main from = new Main();

            from.Show();
        }

        private void FormPrepaidCardBalance_RegionChanged(object sender, EventArgs e)
        {

        }

        private void FormPrepaidCardBalance_Resize(object sender, EventArgs e)
        {
            var bgfile = this.BackgroundImage;
            this.SuspendLayout();
            this.BackgroundImage = null;
            this.BackgroundImage = bgfile;
            this.ResumeLayout();
        }
    }
}
