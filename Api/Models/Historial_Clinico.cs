﻿namespace API_Tareadef.Models
{
    public class Historial_Clinico
    {
        //public Procedimiento_Medico Procedimiento { get; set; } = new Procedimiento_Medico();
        public string Tratamiento { get; set; } = string.Empty;
        public int Cedula_Pac { get; set; } = 0;
        public string Procedimiento_Realizado { get; set; } = string.Empty;
        public string Fecha_Procedimiento { get; set;} = string.Empty;
    }
}
