using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace teamREQUIREMENTS.Persistencia.Models {
    public class Modulo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        public ICollection<RequisitoFuncional> RequisitosFuncionais { get; set; }
        
    }

}