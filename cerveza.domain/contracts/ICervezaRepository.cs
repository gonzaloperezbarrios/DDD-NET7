using cerveza.domain.entities;

namespace cerveza.domain.contracts;

public interface ICervezaRepository
{
    List<CervezaEntity> obtenerCervesas();
}
