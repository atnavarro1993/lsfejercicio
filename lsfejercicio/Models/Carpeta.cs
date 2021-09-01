using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lsfejercicio.Models
{
    public class Carpeta : Objeto
    {
        private List<Objeto> objetos;
        private List<Carpeta> carpetas;

        public Carpeta()
        {

        }

        public Carpeta(List<Objeto> objetos, List<Carpeta> carpetas)
        {
            this.Objetos = objetos;
            this.Carpetas = carpetas;
        }

        public List<Objeto> Objetos { get => objetos; set => objetos = value; }
        public List<Carpeta> Carpetas { get => carpetas; set => carpetas = value; }
    }
}
