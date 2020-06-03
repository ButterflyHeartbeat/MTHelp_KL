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
            this._secBtnText = "�D��";
            this._firBtnText = "¼��תд";
        }



        // ��һ����ť
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


        //�ڶ�����ť
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
            //SecBtnText = "������";
        }

        public void FirBtn()
        {
            ICModel getAudioView = new GetAudioViewModel();
            //getAudioView.Show();
        }

    }
}