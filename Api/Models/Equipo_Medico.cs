namespace API_Tareadef.Models
{
    public class Equipo_Medico//Atributos de la clase Equipo Médico
    {
        public int ID_Equipo_Medico { get; set; } = 0;
        public string Nombre_Equipo_Medico { get; set; } = string.Empty;
        public int Cantidad_Disponible { get; set; } = 0;
        public string Proveedor { get; set; } = string.Empty;
        public int Numero_Cama { get; set; } = 0;
    }
}
