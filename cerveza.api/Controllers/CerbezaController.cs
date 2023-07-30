using AutoMapper;
using cerveza.api.Requests;
using cerveza.application;
using Microsoft.AspNetCore.Mvc;

namespace cerveza.api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CerbezaController : ControllerBase
{

    private readonly IApplicationServices services;
    private readonly IMapper _mapper;

    public CerbezaController(IApplicationServices services, IMapper mapper)
    {
        this.services = services;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult ObtenerCervea([FromQuery] CerbezaFilterRequest request)
    {
        try
        {
            var toApplication = _mapper.Map<CerbezaFilterDTO>(request);
            var response = services.buscarPorIngrediente(toApplication);
            return Ok(response);
        }
        catch (CerbezaException e)
        {
            return Ok(e.Message);
        }
    }
}
