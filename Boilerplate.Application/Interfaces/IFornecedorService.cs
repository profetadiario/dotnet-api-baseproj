using Boilerplate.Application.ViewModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Boilerplate.Application.Interfaces
{
    public interface IFornecedorService
    {
        Task<IEnumerable<FornecedorViewModel>> GetFornecedoresAsync();
        Task<FornecedorViewModel> GetFornecedorByIdAsync(FornecedorViewModel view);
        Task<FornecedorViewModel> CreateFornecedorAsync(FornecedorViewModel view);
        Task<FornecedorViewModel> UpdateFornecedorAsync(FornecedorViewModel view);
        Task<FornecedorViewModel> DeleteFornecedorAsync(FornecedorViewModel view);
        Task CreateViewModel(FornecedorViewModel view);
        Task UpdateViewModel(FornecedorViewModel view);
        Task DeleteViewModel(FornecedorViewModel view);
        bool ValidarView(FornecedorViewModel view);
    }
}
