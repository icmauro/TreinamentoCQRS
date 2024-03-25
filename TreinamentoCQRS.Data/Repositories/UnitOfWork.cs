using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoCQRS.Data.Context;
using TreinamentoCQRS.Domain.Interface;

namespace TreinamentoCQRS.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DataContext _dataContext;
        private IProdutoRepositorie _produtoRepositorie;
        private IFornecedorRepositorie _fornecedorRepositorie;
        private IEnderecoRepositorie _enderecoRepositorie;

        public UnitOfWork(DataContext dataContext, 
                         IProdutoRepositorie produtorepositorie, 
                         IFornecedorRepositorie fornecedorRepositorie, 
                         IEnderecoRepositorie enderecoRepositorie)
        {
            _dataContext = dataContext;
            _produtoRepositorie = produtorepositorie;
            _fornecedorRepositorie = fornecedorRepositorie;
            _enderecoRepositorie = enderecoRepositorie;
        }

        public IFornecedorRepositorie fornecedorRepositorie
        {
            get {
                return _fornecedorRepositorie = _fornecedorRepositorie ?? new FornecedorRepositorie(_dataContext);
            }
        }

        public IProdutoRepositorie produtoRepositorie
        {
            get
            {
                return _produtoRepositorie = _produtoRepositorie ?? new ProdutoRepositorie(_dataContext);
            }
        }

        public IEnderecoRepositorie enderecoRepositorie
        {
            get
            {
                return _enderecoRepositorie = _enderecoRepositorie ?? new EnderecoRepositorie(_dataContext);
            }
        }

        public async Task CommitAsync()
        {
            await _dataContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}
