using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;

using System.IO;

namespace CurrencyExchangeKiosk
{
    public partial class Main : Form
    {
        Comom ComomClass = new Comom();
        WaitWndFun waitForm = new WaitWndFun();
       // internal SQLiteConnection dbConnection;
        public Main()
        {
            InitializeComponent();


           // Sqllite();

            timerStart();
        }

        //private void Sqllite()
        //{
        //    string dir2 = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        //    dbConnection = new SQLiteConnection(@"Data Source= " + dir2 + @"\DB\Transmission.db");

        //    dbConnection.Open();
        //}


        private void button1_Click(object sender, EventArgs e)
        {

        }

       

        private void Main_Load(object sender, EventArgs e)
        {
           // //this.Location = Screen.AllScreens[1].WorkingArea.Location;
           
            this.StartPosition = FormStartPosition.CenterScreen;
           
            var embed = ComomClass.Advertisinginkd(out var url);
            this.webBrowser1.DocumentText = string.Format(embed, url);
            var date = ComomClass.KorDate();

            lblDate.Text = date;
        }

      


        private void timer_Tick(object sender, EventArgs e)
        {
       
         TimerLabel.Text = System.DateTime.Now.ToString("tt hh:mm");
      

        }

        private void ButtonKorean_Click(object sender, EventArgs e)
        {
            waitForm.Show(this);
            ComomClass.PlaySound();

            this.Hide();
           // FormServiceInfo from = new FormServiceInfo();
            FormServiceSelection from = new FormServiceSelection();

            from.Show();
            waitForm.Close();

        }

        private void ButtonEnglish_Click(object sender, EventArgs e)
        {
            ComomClass.PlaySound();
        }

      

        private void gridControl1_Resize(object sender, EventArgs e)
        {
            
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            var bgfile = this.BackgroundImage;
            this.SuspendLayout();
            this.BackgroundImage = null;
            this.BackgroundImage = bgfile;
            this.ResumeLayout();
        }

        private void timerStart()
        {
            Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1초
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private bool CheckOpened(string name)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Text == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
