using cerveza.domain.entities;

namespace cerveza.domain.services;

public interface ICervezaServices
{
    List<CervezaEntity> obtenerCervesas();
    List<CervezaEntity> buscarPorIngredientes(List<CervezaEntity> cervezas, List<string> _ingredientes, int peso);
    bool validarNivelAlcohol(int alcohol, string nivelAlcohol);
}
