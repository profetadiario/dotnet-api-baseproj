﻿using Boilerplate.Core.Bases;
using Boilerplate.Core.Enumerators;
using Boilerplate.Core.Validators;
using System;
using System.ComponentModel.DataAnnotations;

namespace Boilerplate.Core.Models
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public EVertical Vertical { get; set; }
        public string Link { get; set; }
        public bool MantemHistorico { get; set; }
        public string Logo { get; set; }

        public Fornecedor()
        {
            ValidateModel(this, new FornecedorModelValidation());
        }

        public Fornecedor(Guid id, string link, string logo, bool mantemHistorico, string nome, EVertical vertical)
        {
            Id = id;
            Link = link;
            Logo = logo;
            MantemHistorico = mantemHistorico;
            Nome = nome;
        }
    }
}
