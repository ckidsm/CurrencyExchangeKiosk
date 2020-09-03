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
    public partial class FormServiceInfo : Form
    {
        Comom ComomClass = new Comom();
        public FormServiceInfo()
        {
            InitializeComponent();
            //this.Location = Screen.AllScreens[1].WorkingArea.Location;
           // this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void imageButton1_Click(object sender, EventArgs e)
        {
            ComomClass.PlaySound();
            this.Close();
            FormServiceSelection from = new FormServiceSelection();
            from.Show();
        }

        private void FormServiceInfo_Resize(object sender, EventArgs e)
        {
            var bgfile = this.BackgroundImage;
            this.SuspendLayout();
            this.BackgroundImage = null;
            this.BackgroundImage = bgfile;
            this.ResumeLayout();
        }
    }
}
