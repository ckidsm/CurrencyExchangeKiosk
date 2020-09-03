using System;
using System.Drawing;
using System.Windows.Forms;

namespace CurrencyExchangeKiosk
{
    public class ColorLabel : Label
    {
        public ColorLabel()
        {
            if (this.Text == "서비스")
            {
                this.ForeColor = Color.Green;
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (this.Text == "서비스")
            {
                this.ForeColor = Color.Green;
            }
        }
    }
}
