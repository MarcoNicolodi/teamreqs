using System.Collections.Generic;
using teamREQUIREMENTS.Persistencia.Models;

namespace teamREQUIREMENTS.Persistencia.Repositorios {
    public class RequisitosFuncionaisRegrasDeNegocioRepository : Repository<RequisitosFuncionaisRegrasDeNegocio>, IRequisitosFuncionaisRegrasDeNegocioRepository 
    {
        public RequisitosFuncionaisRegrasDeNegocioRepository(AppContext context) : base (context){
            
        }
        public AppContext AppContext {
            get { return Context as AppContext; }
        }
    }
}
    


