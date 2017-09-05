using System;
using teamREQUIREMENTS.Persistencia.Repositorios;

namespace teamREQUIREMENTS.Persistencia{
    public interface IUnitOfWork : IDisposable{
        //tudo interface para testabilidade
        //moca a interface e esses propriedades nos unit tests
        IRequisitosFuncionaisRepository RequisitosFuncionais { get; }
        IRegrasDeNegocioRepository      RegrasDeNegocio      { get; }
        IModulosRepository              Modulos              { get; }
        IRequisitosFuncionaisRegrasDeNegocioRepository RequisitosFuncionaisRegrasDeNegocio { get; }
        int Save();

    }
}