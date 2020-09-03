using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace CurrencyExchangeKiosk
{
    public class WaitWndFun
    {
        WaitForm loadingForm;
        Thread loadthread;
        /// <summary>
        /// 대기 상자 표시
        /// </summary>
        public void Show()
        {
            loadthread = new Thread(new ThreadStart(LoadingProcessEx));
            loadthread.Start();
        }
        /// <summary>
        /// 대기 상자 표시
        /// </summary>
        /// <param name="parent">
       /// 부모 양식</param>
        public void Show(Form parent)
        {
            loadthread = new Thread(new ParameterizedThreadStart(LoadingProcessEx));
            loadthread.Start(parent);
        }
        public void Close()
        {
            if (loadingForm != null)
            {
                loadingForm.BeginInvoke(new System.Threading.ThreadStart(loadingForm.CloseLoadingForm));
                loadingForm = null;
                loadthread = null;
            }
        }
        private void LoadingProcessEx()
        {
            loadingForm = new WaitForm();
            loadingForm.ShowDialog();
        }
        private void LoadingProcessEx(object parent)
        {
            Form Cparent = parent as Form;
            loadingForm = new WaitForm(Cparent);
            loadingForm.ShowDialog();
        }
    }
}
