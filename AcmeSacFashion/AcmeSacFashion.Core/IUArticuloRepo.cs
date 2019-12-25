using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeSacFashion.Core
{
    public interface IUArticuloRepo
    {
        void Agregar(Articulo articulo);
        void Actualizar(Articulo articulo);

        void Cancelar(Articulo articulo);
        ICollection<Articulo> ListarArticulo();
        Articulo Buscar (int Id); 

    }
}
