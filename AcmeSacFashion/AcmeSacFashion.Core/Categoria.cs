using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeSacFashion.Core
{
   public  class Categoria
    {
        public int Id { get; set; }
        public string Nom_categoria { get; set; }

        public int ArticuloId { get; set; }
        public virtual Articulo ArticuloCategorias { get; set; }
    }
}
