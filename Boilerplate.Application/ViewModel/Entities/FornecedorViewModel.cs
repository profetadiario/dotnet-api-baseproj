using Boilerplate.Core.Enumerators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boilerplate.Application.ViewModel.Entities
{
    public class FornecedorViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public EVertical Vertical { get; set; }
        public string Link { get; set; }
        public bool MantemHistorico { get; set; }
        public string Logo { get; set; }
    }
}
