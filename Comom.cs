using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CurrencyExchangeKiosk
{
    partial class Comom
    {

        public async void PlaySound()
        {
            try
            {

                using (var player =
                    new System.Media.SoundPlayer(CurrencyExchangeKiosk.Properties.Resources.button_click_007))
                {
                    await Task.Run(() =>
                    {
                        player.Load();
                        player.PlaySync();
                    });

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
            }
        }

        public void MoveForm(Form form, Screen screen = null)
        {
            if (screen == null)
            {
               
                if (Screen.AllScreens.Length > 1) return;

                screen = Screen.AllScreens[1];
            }
            var bounds = screen.Bounds;

            form.Left = ((bounds.Left + bounds.Right) / 2) - (form.Width / 2);
            form.Top = ((bounds.Top + bounds.Bottom) / 2) - (form.Height / 2);
        }

        public void ShowFormsOnScreenLeftToRight(Screen screen, params Form[] forms)
        {
            if (forms == null || forms.Length == 0)
                return;

            var formsCnt = forms.Length;
            var formSize = new Size(screen.WorkingArea.Size.Width / formsCnt, screen.WorkingArea.Size.Height);
            for (var i = 0; i < formsCnt; i++)
            {
                var form = forms[i];
                if (form == null)
                    continue;
                form.WindowState = FormWindowState.Normal;
                form.Location = new Point(screen.WorkingArea.Left + screen.WorkingArea.Size.Width / formsCnt * i, 0);
                form.Size = formSize;
                form.BringToFront();
            }
        }

        internal string Advertisinginkd(out string url)
        {
            var embed = "<html><head>" +
                        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                        "</head><body>" +
                        "<iframe width=\"997\"  height=\"744\" src=\"https://www.youtube.com/embed/Bo9XtmADMKk\"" +
                        "frameborder = \"1\" allow = \"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>" +
                        "</body></html>";
            url = "https://www.youtube.com/embed/Bo9XtmADMKk";
            return embed;
        }

        internal string KorDate()
        {
            CultureInfo cultures = CultureInfo.CreateSpecificCulture("ko-KR");

            string date = DateTime.Now.ToString(string.Format("yyyy. MM. dd. ddd요일", cultures));
            return date;
        }

    }

    partial class DateFromat
    {
        public static string[] DatetypeFormats = {"d", "D", "f", "F", "g", "G", "m", "o", "r",
            "s", "t", "T", "u", "U", "Y"};

        private static DateTime dateToDisplay = DateTime.Now;
        public string DateTypeEn = dateToDisplay.ToString(DatetypeFormats[7], datecultures[0]);
        public string DateTypeKR = dateToDisplay.ToString(DatetypeFormats[7], datecultures[1]);

        static CultureInfo[] datecultures = {CultureInfo.CreateSpecificCulture("en-US"),
            CultureInfo.CreateSpecificCulture("ko-kr"),
            CultureInfo.CreateSpecificCulture("ar-DZ"),
            CultureInfo.CreateSpecificCulture("fr-FR")};

    }

}

