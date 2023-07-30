namespace cerveza.application;

using cerveza.api.Requests;
using cerveza.domain.entities;

public interface IApplicationServices
{
     List<CervezaEntity> buscarPorIngrediente(CerbezaFilterDTO cerbezaFilter);
}
