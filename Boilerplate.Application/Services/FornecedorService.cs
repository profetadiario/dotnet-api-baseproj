using Boilerplate.Application.Interfaces;
using Boilerplate.Application.ViewModel.Entities;
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

        public async Task<IEnumerable<FornecedorViewModel>> GetFornecedoresAsync()
        {
            return await _repository.FilterAsync();
        }

        public async Task<IEnumerable<FornecedorViewModel>> GetFornecedorByIdAsync(Guid id)
        {
            return await _repository.FilterAsync(x=>x.Id == id);
        }

        public async Task<FornecedorViewModel> CreateFornecedorAsync(FornecedorViewModel view)
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

        public async Task<FornecedorViewModel> UpdateFornecedorAsync(FornecedorViewModel view)
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

        public async Task<FornecedorViewModel> DeleteFornecedorAsync(FornecedorViewModel view)
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

        public Task CreateViewModel(FornecedorViewModel view)
        {
            return _repository.CreateAsync(view);
        }

        public Task UpdateViewModel(FornecedorViewModel view)
        {
            return _repository.UpdateAsync(view);
        }
        public Task DeleteViewModel(FornecedorViewModel view)
        {
            return _repository.DeleteAsync(view);
        }

        public bool ValidarView(FornecedorViewModel view)
        {
            if (view == null)
                return false;

            return true;
        }
    }
}
