using Logistica.Interfaces;
using Logistica.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Logistica.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ResponsavelController : ControllerBase
    {

        public readonly IResponsavelRepository _responsavelRepository;

        public ResponsavelController(IResponsavelRepository responsavelRepository)
        {
            _responsavelRepository = responsavelRepository;
        }

        [HttpPost]
        [Route("/Responsavel")]
        public ActionResult<int> CriaResponsavel(ResponsavelResquest request)
        {
            var responsavel = _responsavelRepository.Include(request);
            return Ok(responsavel.Id);
        }
    }
}
