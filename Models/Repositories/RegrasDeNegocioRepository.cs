using System.Collections.Generic;
using System.Linq;
using teamREQUIREMENTS.Persistencia.Models;

namespace teamREQUIREMENTS.Persistencia.Repositorios{
    public class RegrasDeNegocioRepository : Repository<RegraDeNegocio>, IRegrasDeNegocioRepository{
        public RegrasDeNegocioRepository(AppContext context) : base(context)
        {

        }

        public AppContext AppContext {
            get { return Context as AppContext; }
        }

        public IEnumerable<RegraDeNegocio> GetRegrasPorTags()
        {
            
            return AppContext.RegraDeNegocio.OrderBy(i => i.Id).ToList();
        }


    }
}