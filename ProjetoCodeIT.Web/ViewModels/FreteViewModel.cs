using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoCodeIT.Web.ViewModels
{
    public class FreteViewModel
    {
        public FreteViewModel()
        {

        }

        public int idFrete { get; set; }

        public decimal valor { get; set; }

        public int tempo { get; set; }
    }
}