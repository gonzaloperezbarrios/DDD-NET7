using System.ComponentModel.DataAnnotations;

namespace cerveza.api.Requests;

public class CerbezaFilterDTO
{
    public string Ingredientes { get; set; }
    public int NivelAlcohol { get; set; }
    public int ColorPorcentaje { get; set; }

    public List<string> getIngredientes(){
        return Ingredientes.Split(",").ToList();
    }
}
