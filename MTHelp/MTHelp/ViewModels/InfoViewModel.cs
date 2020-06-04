using Caliburn.Micro;
using MTHelp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTHelp.ViewModels
{
   public class InfoViewModel:Screen,ICModel
    {
        public InfoViewModel()
        {
            DisplayName = "录音转写";
        }
    }
}
