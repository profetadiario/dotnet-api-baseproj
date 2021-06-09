using AutoMapper;
using Boilerplate.Application.ViewModel.Entities;
using Boilerplate.Core.Models;

namespace Boilerplate.Application.ViewModel.Mappers
{
    public class TransformationViewAnModel : Profile
    {
        public TransformationViewAnModel()
        {
            CreateMap<FornecedorViewModel, Fornecedor>()
                .ConstructUsing(x => new Fornecedor(x.Id, x.Link, x.Logo, x.MantemHistorico, x.Nome, x.Vertical));
        }
    }
}
