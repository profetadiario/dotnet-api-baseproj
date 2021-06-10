using AutoMapper;
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
        private readonly IMapper _mapper;


        public FornecedorService(IFornecedorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<FornecedorViewModel>> GetFornecedoresAsync()
        {
            return _mapper.Map<IEnumerable<FornecedorViewModel>>(await _repository.FilterAsync());
        }

        public async Task<IEnumerable<FornecedorViewModel>> GetFornecedorByIdAsync(Guid id)
        {
            return _mapper.Map<IEnumerable<FornecedorViewModel>>(await _repository.FilterAsync(x=>x.Id == id));
        }

        public async Task<FornecedorViewModel> CreateFornecedorAsync(FornecedorViewModel view)
        {
            try
            {
                var fornecedor = _mapper.Map<Fornecedor>(view);
                if (ValidarView(view))
                    return view;


                if (fornecedor.IsValid)
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
            var fornecedor = _mapper.Map<Fornecedor>(view);
            try
            {
                if (ValidarView(view))
                    return view;


                if (fornecedor.IsValid)
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
            var fornecedor = _mapper.Map<Fornecedor>(view);
            try
            {
                if (ValidarView(view))
                    return view;


                if (fornecedor.IsValid)
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
            var fornecedor = _mapper.Map<Fornecedor>(view);

            return _repository.CreateAsync(fornecedor);
        }

        public Task UpdateViewModel(FornecedorViewModel view)
        {
            var fornecedor = _mapper.Map<Fornecedor>(view);

            return _repository.UpdateAsync(fornecedor);
        }
        public Task DeleteViewModel(FornecedorViewModel view)
        {
            var fornecedor = _mapper.Map<Fornecedor>(view);

            return _repository.DeleteAsync(fornecedor);
        }

        public bool ValidarView(FornecedorViewModel view)
        {
            if (view == null)
                return false;

            return true;
        }
    }
}
