﻿namespace API_Tareadef.Models
{
    public class Procedimiento_Medico//Atributos de la clase Procedimiento médico
    {
        public string Nombre_Procedimiento_Medico { get; set; } = string.Empty;
        public int Dias_Recuperacion { get; set;} = 0;
        public int ID_Reservacion { get; set; } = 0;

    }
}
