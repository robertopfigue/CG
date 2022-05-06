using CG.Application.Services;
using CG.Infra.DTO;
using Microsoft.AspNetCore.Mvc;

namespace CG.Api.Controllers
{
    [ApiController]
        [Route("[controller]")]
        public class DadosPessoaController : ControllerBase
        {
            private readonly DadosPessoaService _service;

            public DadosPessoaController(DadosPessoaService service)
            {
                _service = service;
            }

            [HttpPost]
            public async Task Post(DadosPessoaPostDto dto, CancellationToken ct)
            {
                await _service.CriarDadosPessoa(dto, ct);
            }
        }
}
