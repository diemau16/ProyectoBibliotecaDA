
using Microsoft.AspNetCore.Mvc;

namespace ProyectoBibliotecaDA.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BibliotecaController: ControllerBase
    {
        //Propiedad pública
        public string PropiedadBiblioteca { get; set; }
        
        public BibliotecaController()
        {
            //Constructor
        }
        [HttpGet]
        public string ObtenerLibro()
        {
            return "No sea pendejo";
        }
        [HttpPost]
        public string AgregarLibro()
        {
            return "No sea pendejo al agrear";
        }
        [HttpPut]
        public string ActualizarLibro()
        {
            return "No sea pendejo al actualizar";
        }
        [HttpDelete]
        public string BorrarLibro()
        {
            return "No sea pendeho al borrar";
        }
    }
}
