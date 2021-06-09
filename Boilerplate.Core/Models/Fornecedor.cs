using Boilerplate.Core.Enumerators;
using System;
using System.ComponentModel.DataAnnotations;

namespace Boilerplate.Core.Models
{
    public class Fornecedor
    {
        public Guid Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public EVertical Vertical { get; set; }
        [Required]
        public string Link { get; set; }
        [Required]
        public bool MantemHistorico { get; set; }
        public string Logo { get; set; }

        public Fornecedor()
        {
            Id = Guid.NewGuid();
        }
    }
}
