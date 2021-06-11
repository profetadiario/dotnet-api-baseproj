using AutoMapper;
using Boilerplate.Application.ViewModel.Entities;
using Boilerplate.Core.Models;

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
