using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TreinamentoCQRS.Application.Members.Commands;
using TreinamentoCQRS.Domain.Entities;
using TreinamentoCQRS.Domain.Interface;
using TreinamentoCQRS.Domain.View;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Treinamento.CQRS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProdutoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar([FromBody] CriarProdutoCommand command)
        {
            var Produto = await _mediator.Send(command);

            return CreatedAtAction("", new { id = Produto.Id }, Produto);


        }

        [HttpPost("{id}")]
        public async Task<IActionResult> Alterar([FromBody] AtualizarProdutoCommand command, int id)
        {
            command.Id = id;

            var Produto = await _mediator.Send(command);

            if(Produto != null)
                return Ok(Produto);
            else
              return NotFound();

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Editar([FromBody] EditarProdutoCommand command, int id)
        {
            command.Id = id;

            var Produto = await _mediator.Send(command);

            if (Produto != null)
                return Ok(Produto);
            else
                return NotFound();
        }

    }
}
