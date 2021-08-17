using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeGym.Application.ViewModels
{
    public class ErrosViewModel
    {
        public ErrosViewModel(List<string> erros)
        {
            Erros = erros;
        }

        public List<string> Erros { get; set; }
    }
}
