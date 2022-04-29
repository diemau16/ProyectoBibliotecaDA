namespace ProyectoBibliotecaDA.Datos.Modelo
{
    public class Prestamo
    {
        public int CodigoLibro { get; set; }
        public int CodigoEstudiante { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFinal { get; set; }
        public bool Devuelto { get; set; }
    }
}