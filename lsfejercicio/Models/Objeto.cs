using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lsfejercicio.Models
{
    public class Objeto
    {
        private Int32 id;
        private String nombre;
        private Int32 size;
        private Boolean readOnly;

        public Objeto()
        {

        }

        public Objeto(int id, string nombre, bool readOnly, int size)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.ReadOnly = readOnly;
            this.Size = size;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public bool ReadOnly { get => readOnly; set => readOnly = value; }
        public int Size { get => size; set => size = value; }
    }
}
