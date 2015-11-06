using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Model;

namespace Repositorio.ViewModel
{
    class Producto_ViewModel:IViewModel<Producto>
    {
        //En cada VIewModel hay que indicar los atributos de la entidad(tabla) a la que se refiere
        //Son de cada uno de los ficheros que hay en XXXXXModel.tt
        //Solo hay que copiar los que no son "public virtual"
        public int idProducto { get; set; }
        public string Nombre { get; set; }
        public string Fabricante { get; set; }
        public int PCoste { get; set; }
        public int PVenta { get; set; }
        public int idCategoria { get; set; }



        public Producto ToBaseDatos()
        {
            var nuevoProducto = new Producto()
            {
                //idProducto = idProducto,
                Nombre = Nombre,
                Fabricante = Fabricante,
                PCoste = PCoste,
                PVenta = PVenta,
                idCategoria = idCategoria,
            };

            return nuevoProducto;
        }

        public void FromBaseDatos(Producto modelo)
        {
            throw new NotImplementedException();
        }

        public void UpdateBaseDatos(Producto modelo)
        {
            throw new NotImplementedException();
        }

        public object[] Getkeys()
        {
            throw new NotImplementedException();
        }
    }
}
