using System.Collections.Generic;
using System.Linq;
using teamREQUIREMENTS.Persistencia.Models;

namespace teamREQUIREMENTS.Persistencia.Repositorios{
    public class ModulosRepository : Repository<Modulo>, IModulosRepository{
        public ModulosRepository(AppContext context) : base(context)
        {

        }

        public AppContext AppContext {
            get { return Context as AppContext; }
        }
    }
}