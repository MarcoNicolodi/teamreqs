using System.Collections.Generic;
using teamREQUIREMENTS.Persistencia.Models;

namespace teamREQUIREMENTS.Persistencia.Repositorios {
    public interface IRequisitosFuncionaisRepository : IRepository<RequisitoFuncional> {

        IEnumerable<RequisitoFuncional> GetByModulo(int modulo_id);

    }
}