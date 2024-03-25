using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TreinamentoCQRS.Domain.Entities;
using TreinamentoCQRS.Domain.Interface;

namespace Treinamento.CQRS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public FornecedorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost("Cadastrar")]
        public async Task<IActionResult> Cadastrar([FromBody] Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }

        [HttpPost("Alterar")]
        public async Task<IActionResult> Alterar([FromBody] Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }

        [HttpPost("Editar")]
        public async Task<IActionResult> Editar([FromBody] Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }
    }
}
