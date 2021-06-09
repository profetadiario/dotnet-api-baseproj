using Boilerplate.Application.Interfaces;
using Boilerplate.Core.Interfaces;
using Boilerplate.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Boilerplate.Application.Services
{
    public class FornecedorService : IFornecedorService
    {
        private readonly IFornecedorRepository _repository;

        public FornecedorService(IFornecedorRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Fornecedor>> GetFornecedoresAsync()
        {
            return await _repository.FilterAsync();
        }

        public async Task<IEnumerable<Fornecedor>> GetFornecedorByIdAsync(Guid id)
        {
            return await _repository.FilterAsync(x=>x.Id == id);
        }

        public async Task<Fornecedor> CreateFornecedorAsync(Fornecedor view)
        {
            try
            {
                if (ValidarView(view))
                    return view;


                if (view.IsValid)
                    await CreateViewModel(view);

                return view;
            }
            catch(System.Exception)
            {
                return view;
            }
        }

        public async Task<Fornecedor> UpdateFornecedorAsync(Fornecedor view)
        {
            try
            {
                if (ValidarView(view))
                    return view;


                if (view.IsValid)
                    await UpdateViewModel(view);

                return view;
            }
            catch (System.Exception)
            {
                return view;
            }
        }

        public async Task<Fornecedor> DeleteFornecedorAsync(Fornecedor view)
        {
            try
            {
                if (ValidarView(view))
                    return view;


                if (view.IsValid)
                    await DeleteViewModel(view);

                return view;
            }
            catch (System.Exception)
            {
                return view;
            }
        }

        private Task CreateViewModel(Fornecedor view)
        {
            return _repository.CreateAsync(view);
        }

        private Task UpdateViewModel(Fornecedor view)
        {
            return _repository.UpdateAsync(view);
        }
        private Task DeleteViewModel(Fornecedor view)
        {
            return _repository.DeleteAsync(view);
        }

        private bool ValidarView(Fornecedor view)
        {
            if (view == null)
                return false;

            return true;
        }
    }
}
