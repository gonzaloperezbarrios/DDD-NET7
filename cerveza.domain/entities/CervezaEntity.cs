namespace cerveza.domain.entities;

using Newtonsoft.Json;
public class CervezaEntity
{
    public string Tipo { get; set; }
    public string Color { get; set; }

    [JsonProperty("color_porcentaje")]
    public int ColorPorcentaje { get; set; }
    public string Sabor { get; set; }
    public string Descripcion { get; set; }
    public string Alcohol { get; set; }
    public List<String> Ingredientes { get; set; }
    public bool validarTolerancia(int toleranciaColor) =>
                    this.ColorPorcentaje >= 0 &&
                    this.ColorPorcentaje <= this.ColorPorcentaje + toleranciaColor;
}
