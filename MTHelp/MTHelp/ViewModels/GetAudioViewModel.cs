using Caliburn.Micro;
using MTHelp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTHelp.ViewModels
{
   public class GetAudioViewModel:PropertyChangedBase, ICModel
	{
        public GetAudioViewModel()
        {
			this._CommitBtnText = "上傳";

		}




		//提交按钮显示内容
		private string _CommitBtnText;

		public string CommitBtnText
		{
			get { return _CommitBtnText; }
			set
			{
				if (_CommitBtnText == value) return;
				_CommitBtnText = value;
				NotifyOfPropertyChange(() => CommitBtnText);
			}
		}



		public void CommitBtn()
		{
			CommitBtnText = "测试更改";
		}

	}
}
