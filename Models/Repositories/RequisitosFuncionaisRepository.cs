using System.Collections.Generic;
using System.Linq;
using teamREQUIREMENTS.Persistencia.Models;

namespace teamREQUIREMENTS.Persistencia.Repositorios{
    public class RequisitosFuncionaisRepository : Repository<RequisitoFuncional>, IRequisitosFuncionaisRepository {
        public RequisitosFuncionaisRepository(AppContext context) : base(context)
        {

        }

        public AppContext AppContext {
            get { return Context as AppContext; }
        }

        public IEnumerable<RequisitoFuncional> GetByModulo(int moduloId)
        {
            return AppContext.RequisitosFuncionais.Where(e => e.ModuloId == moduloId).ToList();
        }

        public RequisitoFuncional GetById(int id)
        {
            return AppContext.RequisitosFuncionais.Where(e => e.Id == id).FirstOrDefault();
        }
    }
}