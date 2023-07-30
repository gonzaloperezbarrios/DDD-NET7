using cerveza.api.Requests;
using cerveza.application.Constans;
using cerveza.domain.entities;
using cerveza.domain.services;
using Microsoft.Extensions.Options;

namespace cerveza.application;

public class ApplicationServices : IApplicationServices
{
    private readonly ICervezaServices services;
    private readonly CerbezaSetting cerbezaSetting;


    public ApplicationServices(ICervezaServices services, IOptions<CerbezaSetting> cerbezaSetting)
    {
        this.services = services;
        this.cerbezaSetting = cerbezaSetting.Value;
    }

    public List<CervezaEntity> buscarPorIngrediente(CerbezaFilterDTO cerbezaFilter)
    {
        var cervesasRepository = services.obtenerCervesas();
        int toleranciaColor = cerbezaSetting.ToleranciaColor;

        List<CervezaEntity> cervezas = services
        .buscarPorIngredientes(cervesasRepository, cerbezaFilter.getIngredientes(), cerbezaFilter.getIngredientes().Count)
        .OrderBy(n => n.ColorPorcentaje)
        .Where(cerveza =>
                    services.validarNivelAlcohol(cerbezaFilter.NivelAlcohol, cerveza.Alcohol) &&
                    cerveza.validarTolerancia(toleranciaColor))
        .ToList();

        if (cervezas.Count.Equals(0))
        {
            throw new CerbezaException("Felicitaciones has encontrado un perfil nuevo de cerveza");
        }

        return cervezas.ToList();
    }


}
