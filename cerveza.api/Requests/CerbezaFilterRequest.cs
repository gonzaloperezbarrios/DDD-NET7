using System.ComponentModel.DataAnnotations;

namespace cerveza.api.Requests;

public class CerbezaFilterRequest
{
    [Required(ErrorMessage = "El campo 'ingredientes' es obligatorio")]
    public string Ingredientes { get; set; }

    [Range(1, 100, ErrorMessage = "El valor de 'alcohol' debe estar entre 1 y 100")]
    public int NivelAlcohol { get; set; }

    [Range(1, 100, ErrorMessage = "El valor de 'colorPorcentaje' debe estar entre 1 y 100")]
    public int ColorPorcentaje { get; set; }

}
