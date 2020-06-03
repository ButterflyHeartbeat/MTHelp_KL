using HandyControl.Tools.Extension;
using MTHelp.Models;
using MTHelp.ViewModels;
using MTHelp.Views;
using System.CodeDom;

namespace MTHelp
{
    public class ShellViewModel : Caliburn.Micro.PropertyChangedBase, IShell
    {
        public ShellViewModel()
        {
            this._secBtnText = "聼轉寫";
            this._firBtnText = "录音转写";
        }



        // 第一个按钮
        private string _firBtnText;

        public string FirBtnText
        {
            get { return _firBtnText; }
            set
            {
                if (_firBtnText == value) return;
                _firBtnText = value;
                NotifyOfPropertyChange(() => FirBtnText);
            }
        }


        //第二个按钮
        private string _secBtnText;

        public string SecBtnText
        {
            get { return _secBtnText; }
            set {
                if (_secBtnText == value) return;
                _secBtnText = value;
                NotifyOfPropertyChange(nameof(SecBtnText));
               // NotifyOfPropertyChange(() => SecBtnText);
            }
        }












        public void SecBtn()
        {
            //SecBtnText = "啦啦啦";
        }

        public void FirBtn()
        {
            ICModel getAudioView = new GetAudioViewModel();
            //getAudioView.Show();
        }

    }
}