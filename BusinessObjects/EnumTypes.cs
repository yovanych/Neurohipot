namespace BusinessObjects
{
    public enum ResultType { AM, ASS, ASC, ET, MF, PVA, PVA2, RL, TRS, TRC }
    public enum TypeAS { Simple, Compleja }
    public enum PVA_Type { PVA_1, PVA_2 }
    /// <summary>
    /// H: Homogeneas, C: En colores
    /// </summary>
    public enum TypeOf_AS_Test { H_Imagenes = 0, H_Figuras_Abstractas = 1, H_Letras = 2, C_Imagenes = 3, C_Letras = 4 }
    public enum ChartReportClass
    {
        PERCENTILES,
        ERRORES,
        TIEMPOS
    }
    public enum Criterios_Busqueda { codigo, nombre, apellido1, apellido2, sexo };
    public enum Sexo { Masculino, Femenino }

    public enum AS_TestParameter { IA, Aciertos, Omisiones, Comisiones, TR, DS_TR }
}
