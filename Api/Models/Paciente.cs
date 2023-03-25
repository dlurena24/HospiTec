﻿namespace API_Tareadef.Models
{
    public class Paciente
    {
        public string Nombre { get; set; } = string.Empty;
        public string Apellido1 { get; set; } = string.Empty;
        public string Apellido2 { get; set; } = string.Empty;
        public int Cedula { get; set; } = 0;
        public string Fecha_Nacimiento { get; set; } = string.Empty;
        public string Contrasena { get; set; } = string.Empty;
        public int Telefono { get; set; } = 0;
        public string Direccion { get; set; } = string.Empty;
        public string Patologia { get; set; } = string.Empty;
        public string Tratamiento { get; set; } = string.Empty;
        //public int Cama_asignada { get; set; } = 0; 
        //public int id_reservacion { get; set; } = 0; //Preguntar a Myke
        //public List<Historial_Clinico> Historial { get; set; } = new List<Historial_Clinico>();

    }
}
