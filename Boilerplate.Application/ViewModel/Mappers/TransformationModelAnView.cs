using AutoMapper;
using Boilerplate.Application.ViewModel.Entities;
using Boilerplate.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boilerplate.Application.ViewModel.Mappers
{
    public class TransformationModelAnView : Profile
    {
        public TransformationModelAnView()
        {
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
        }
    }
}
