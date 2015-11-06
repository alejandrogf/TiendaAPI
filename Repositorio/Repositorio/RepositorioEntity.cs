using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Repositorio.ViewModel;


namespace Repositorio.Repositorio
{
    public class RepositorioEntity<TModelo, TViewModel>: IRepositorio<TModelo, TViewModel>
        where TModelo:class
        where TViewModel:IViewModel<TModelo>,new ()
    {
        public TViewModel Add(TViewModel model)
        {
            throw new NotImplementedException();

        }

        public int Borrar(TViewModel model)
        {
            throw new NotImplementedException();
        }

        public int Borrar(Expression<Func<TModelo, bool>> consultaExpression)
        {
            throw new NotImplementedException();
        }

        public int Actualizar(TViewModel model)
        {
            throw new NotImplementedException();
        }

        public ICollection<TViewModel> Get()
        {
            throw new NotImplementedException();
        }

        public TViewModel Get(params object[] claves)
        {
            throw new NotImplementedException();
        }

        public ICollection<TViewModel> Get(Expression<Func<TModelo, bool>> consultaExpression)
        {
            throw new NotImplementedException();
        }
    }
}