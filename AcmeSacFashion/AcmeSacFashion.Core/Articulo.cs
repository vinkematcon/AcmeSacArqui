using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeSacFashion.Core
{
     public class Articulo
    {
        public int Id { get; set; }
        public string Nom_articulo { get; set; }
        public string Descripcion  { get; set; }
        public decimal Precio { get; set; }

        public virtual ICollection<Categoria> Categorias { get; set; }
    }
}
