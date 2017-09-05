using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace teamREQUIREMENTS.Persistencia.Models {
    public class RequisitoFuncional 
    {
        [Key]
        public int Id {get ; set; }
        [Required, MaxLength(255)]
        public string Nome {get ; set; }
        [MaxLength(255)]
        public string Codigo {get ; set; }
        
        
        public int ModuloId {get ; set; }
        [ForeignKey("ModuloId")]
        public Modulo Modulo { get; set; }
        public int ApiVersion { get; set; }

        public ICollection<RequisitosFuncionaisRegrasDeNegocio> RequisitosFuncionaisRegrasDeNegocio;
        
    }

}