using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TreinamentoCQRS.Domain.Entities;
using TreinamentoCQRS.Domain.Interface;

namespace Treinamento.CQRS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoBussines _produtoBussines;
        public ProdutoController(IProdutoBussines produtoBussines)
        {
            _produtoBussines = produtoBussines;
        }

        [HttpPost("Cadastrar")]
        public async Task<IActionResult> Cadastrar([FromBody] Produto produto)
        {
            var Produto = await _produtoBussines.CadastrarProduto(produto);

            return Ok(Produto);

        }

        [HttpPost("{id}")]
        public async Task<IActionResult> Alterar([FromBody] Produto produto, int id)
        {
            produto.Id = id;
            var Produto = await _produtoBussines.AlterarProduto(produto);

            return Ok(Produto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Editar([FromBody] Produto produto, int id)
        {
            produto.Id = id;
            var Produto = await _produtoBussines.EditarProduto(produto);

            return Ok(Produto);
        }

    }
}
