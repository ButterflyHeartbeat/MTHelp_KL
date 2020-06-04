using MTHelp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTHelp.ViewModels
{
   public class LRMainViewModel:Caliburn.Micro.Conductor<ICModel>.Collection.OneActive
    {
        public LRMainViewModel()
        {
            ActivateItem(new InfoViewModel());
            //ActiveItem
        }
    }
}
