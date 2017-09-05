using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace teamREQUIREMENTS.Persistencia.Repositorios {
    /// age como collections. Não salva nem atualiza
    /// nao retorna iqueryable
    /// nao é pra fazer queries a partir desses metodos
    /// é para retornar uma coleção de objetos
    
    public interface IRepository<TEntity> where TEntity : class {
        TEntity  Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity,bool>> predicate);
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
        
        IEnumerable<TEntity> GetPaginado(int page, int resultsPerPage);
    }
}