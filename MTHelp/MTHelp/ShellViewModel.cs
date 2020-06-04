using HandyControl.Tools.Extension;
using MTHelp.Models;
using MTHelp.ViewModels;
using MTHelp.Views;
using System.CodeDom;

namespace MTHelp
{
    public class ShellViewModel :Caliburn.Micro.Conductor<ICModel>.Collection.OneActive, IShell
    {
        public ShellViewModel()
        {
            ActivateItem(new InfoViewModel());
            EnsureItem(new ListeningToWriteViewModel());
            EnsureItem(new CrawlingResourcesViewModel());
        }



      












    }
}