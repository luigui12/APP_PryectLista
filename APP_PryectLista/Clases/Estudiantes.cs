using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_PryectLista.Clases
{
    class Estudiantes
    {
        public String nombrecompleto { get; set; }
        public String genero { get; set; }
        public String estado_civil { get; set; }
        public int edad { get; set; }
    }
    class Productos
    {
        public String codigo { get; set; }
        public String nombre { get; set; }
        public Double precio { get; set; }
        public DateTime fecha { get; set; }
        public int unidad { get; set; }
    }
}
