using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoCQRS.Domain.Entities;
using TreinamentoCQRS.Domain.Interface;

namespace TreinamentoCQRS.Data.Repositories
{
    public class ProdutoQuerieDapperRepositorie : IProdutoDapperRepositorie
    {
        private readonly IDbConnection _dbConnection;

        public ProdutoQuerieDapperRepositorie(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<Produto> BuscarProdutoPorId(int id)
        {
            string query = "Select * From Produtos Where Id =@id";

            return await _dbConnection.QueryFirstOrDefaultAsync<Produto>(query, new { Id = id });
        }

        public async Task<IEnumerable<Produto>> ListarProdutos()
        {
            string query = "Select * From Produtos ";

            return await _dbConnection.QueryAsync<Produto>(query);
        }
    }
}
