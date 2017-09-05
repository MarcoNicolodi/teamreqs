using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace teamREQUIREMENTS.Persistencia.Models {
    public class RequisitosFuncionaisRegrasDeNegocio
    {
        public int RequisitoFuncionalId { get; set; }
        public RequisitoFuncional RequisitoFuncional { get; set; }
        public int RegraDeNegocioId { get; set ; }
        public RegraDeNegocio RegraDeNegocio { get; set; }

    }
}