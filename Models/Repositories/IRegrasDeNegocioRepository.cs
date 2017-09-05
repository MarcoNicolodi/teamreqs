using System.Collections.Generic;
using teamREQUIREMENTS.Persistencia.Models;

namespace teamREQUIREMENTS.Persistencia.Repositorios {
    public interface IRegrasDeNegocioRepository : IRepository<RegraDeNegocio>{
        IEnumerable<RegraDeNegocio> GetRegrasPorTags();
        
    }
}
