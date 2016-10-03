using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public class Tipo
    {
        [Key]
        public long? TipoId { get; set; }
        [DisplayName("Tipo da Mercadoria")]
        public string NomeTipo { get; set; }

        //Foreng Key
        public virtual ICollection<Mercadoria> Mercadoria { get; set; }
    }
}