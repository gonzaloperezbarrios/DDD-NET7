namespace cerveza.domain.valuesObjects;

public record NivelAlcoholVO(int alcohol, string nivelAlcohol)
{
    public bool validarNivel() => estaEnRango(double.Parse(alcohol.ToString()) / 100, convertirPorcentajeArray(nivelAlcohol));

    private bool estaEnRango(double numero, double[] rango)
    {
        if (rango.Length != 2) // El rango debe tener exactamente dos elementos
            throw new ArgumentException("El rango debe tener exactamente dos elementos.");

        double min = Math.Min(rango[0], rango[1]);
        double max = Math.Max(rango[0], rango[1]);

        return numero >= min && numero <= max;
    }

    private double[] convertirPorcentajeArray(string porcentajeString)
    {
        string[] valoresString = porcentajeString.Split('-');
        double[] valoresPorcentaje = new double[2];

        for (int i = 0; i < 2; i++)
        {
            string valorString = valoresString[i].Trim('%', ' ');
            valoresPorcentaje[i] = double.Parse(valorString) / 100.0;
        }

        return valoresPorcentaje;
    }
}
