using MTHelp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTHelp.ViewModels
{
   public class CrawlingResourcesViewModel:Caliburn.Micro.Screen,ICModel
    {
        public CrawlingResourcesViewModel()
        {
            DisplayName = "爬取視頻資源";
        }
    }
}
