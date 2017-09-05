using teamREQUIREMENTS.Persistencia.Repositorios;

namespace teamREQUIREMENTS.Persistencia {
    public class UnitOfWork : IUnitOfWork {
        private readonly AppContext _context;
        public IRequisitosFuncionaisRepository RequisitosFuncionais { get; private set;}
        public IRegrasDeNegocioRepository      RegrasDeNegocio { get; private set;}
        public IModulosRepository              Modulos { get; private set; }
        public IRequisitosFuncionaisRegrasDeNegocioRepository RequisitosFuncionaisRegrasDeNegocio { get; private set; }
        public UnitOfWork(AppContext context)
        {
            _context = context;            
            RegrasDeNegocio      = new RegrasDeNegocioRepository(_context);
            RequisitosFuncionais = new RequisitosFuncionaisRepository(_context);
            Modulos              = new ModulosRepository(_context);
            RequisitosFuncionaisRegrasDeNegocio = new RequisitosFuncionaisRegrasDeNegocioRepository(_context);
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}