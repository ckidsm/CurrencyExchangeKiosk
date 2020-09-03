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
    public partial class FormPrepaidCardAmount : Form
    {
        Comom ComomClass = new Comom();
        Double Result_Value = 0;
        String Operator_Performed = " ";
        bool PerformedOp = false;

        public FormPrepaidCardAmount()
        {
            //this.Location = Screen.AllScreens[1].WorkingArea.Location;
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ComomClass.PlaySound();
            // this.Close();
            FormPrepaidCardCharging from = new FormPrepaidCardCharging();
            from.Show();
        }

        private void button_Click(object sender, EventArgs e)
        {
            // numbers button and point
            if (textBox_Result.Text == "0" || PerformedOp)
                textBox_Result.Clear();

            PerformedOp = false;
            ImageButton button = (ImageButton) sender;
            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text += button.Text;
            }

            else
                textBox_Result.Text += button.Text;
        }

        private void FormPrepaidCardAmount_Resize(object sender, EventArgs e)
        {
            var bgfile = this.BackgroundImage;
            this.SuspendLayout();
            this.BackgroundImage = null;
            this.BackgroundImage = bgfile;
            this.ResumeLayout();
        }
    }
}
