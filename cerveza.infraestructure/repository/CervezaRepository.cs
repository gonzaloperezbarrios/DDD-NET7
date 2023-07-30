namespace cerveza.infraestructure.repository;

using System.Collections.Generic;
using Newtonsoft.Json;
using cerveza.domain.entities;
using cerveza.domain.contracts;

public class CervezaRepository : ICervezaRepository
{
    public List<CervezaEntity> obtenerCervesas()
    {
        string json = System.IO.File.ReadAllText("../cerveza.infraestructure/repository/json/cervesas.json");
        var data = JsonConvert.DeserializeObject<List<CervezaEntity>>(json);
        return data == null ? new List<CervezaEntity>() : data;
    }
}
