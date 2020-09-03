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
    public partial class FormInformationAmountExchange : Form
    {
        Comom ComomClass = new Comom();
        public FormInformationAmountExchange()
        {
            //this.Location = Screen.AllScreens[1].WorkingArea.Location;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            ComomClass.PlaySound();
            this.Close();
            FormServiceCompleted from = new FormServiceCompleted();

            from.Show();
        }

        private void FormInformationAmountExchange_Resize(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {
            var bgfile = this.BackgroundImage;
            this.SuspendLayout();
            this.BackgroundImage = null;
            this.BackgroundImage = bgfile;
            this.ResumeLayout();
        }

        private void label17_Resize(object sender, EventArgs e)
        {
            NewMethod();
        }
    }
}
