namespace CGSICAMM.Models
{
    public class PruebaCargaViewModel
    {
        public int Id { get; set; }
        public string Curp { get; set; }
        public string? Rfc { get; set; }
        public string Nombre { get; set; }
        public string? apellidoPaterno { get; set; }
        public string? apellidoMaterno { get; set; }
        public double puntajeGlobal { get; set; }
        public int posicionOrdenamiento { get; set; }
        public double cursoHabDocentes { get; set; }
        public int movAcademica { get; set; }
        public double expDocente { get; set; }
        public double Cenni { get; set; }
        public int cursoNem { get; set; }
        public double ivConocimientosAp { get; set; }
    }
}
