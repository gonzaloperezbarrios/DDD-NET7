namespace cerveza.domain.services;

using cerveza.domain.contracts;
using cerveza.domain.entities;
using cerveza.domain.valuesObjects;

public class CervezaServices : ICervezaServices
{
    private readonly ICervezaRepository repository;
    public CervezaServices(ICervezaRepository repository)
    {
        this.repository = repository;
    }

    public List<CervezaEntity> buscarPorIngredientes(List<CervezaEntity> cervezas, List<string> _ingredientes, int peso)
    {
        return cervezas.FindAll(p => p.Ingredientes.Intersect(_ingredientes).Count() >= peso);
    }

    public List<CervezaEntity> obtenerCervesas()
    {
        return repository.obtenerCervesas();
    }

    public bool validarNivelAlcohol(int alcohol, string nivelAlcohol)
    {
        return new NivelAlcoholVO(alcohol, nivelAlcohol).validarNivel();
    }
}