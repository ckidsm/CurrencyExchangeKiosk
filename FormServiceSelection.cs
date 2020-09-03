using System;
using System.Drawing;
using System.Windows.Forms;

namespace CurrencyExchangeKiosk
{
    public partial class FormServiceSelection : Form
    {
        Comom ComomClass = new Comom();
        public FormServiceSelection()
        {
            InitializeComponent();


        }


        private void FormServiceSelection_Load(object sender, EventArgs e)
        {
            //this.Location = Screen.AllScreens[1].WorkingArea.Location;
            this.StartPosition = FormStartPosition.CenterScreen;

          //  lecolor.Text = lblinfo.Text;
        }

        private void imageButton1_Click(object sender, EventArgs e)
        {
          
            NextFrom(out var @from);
        }

        private void NextFrom(out FormDeposit @from)
        {
            ComomClass.PlaySound();
            this.Close();
            @from = new FormDeposit();
          //  ComomClass.MoveForm(@from, null);
            @from.Show();
          
        }

        private void imageButton2_Click(object sender, EventArgs e)
        {
            ComomClass.PlaySound();
            this.Close();

            FormPrepaidCardCharging from = new FormPrepaidCardCharging();

            from.Show();

        }

        private void imageButton4_Click(object sender, EventArgs e)
        {
          
        }

        private void imageButton3_Click(object sender, EventArgs e)
        {
            ComomClass.PlaySound();
            this.Close();

            FormPrepaidCardAmount from = new FormPrepaidCardAmount();

            from.Show();
        }

        private void FormServiceSelection_Resize(object sender, EventArgs e)
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

        private void imageButton1_Resize(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void imageButton2_Resize(object sender, EventArgs e)
        {
            NewMethod();
        }

        protected override void OnActivated(EventArgs e)
        {
            Console.WriteLine("Form Activated");
        }
    }

 }
