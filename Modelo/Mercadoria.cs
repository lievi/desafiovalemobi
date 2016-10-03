using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Modelo
{
    public class Mercadoria
    {
        Regex regex = new Regex(@"/^\d +,\d{2}$/");
        [Key]
        public long? MercadoriaId { get; set; }
        [DisplayName("Nome")]
        [Required(ErrorMessage = "Nome Obrigatório")]
        public string NomeMercadoria { get; set; }

        [DisplayName("Tipo do Negócio")]
        public string TipoNegocio { get; set; }

        [DisplayName("Quantidade")]
        [Required(ErrorMessage = "Quantidade Obrigatória")]
        public int QtdMercadoria { get; set; }

        [DisplayName("Valor")]
        public string ValorMercadoria { get; set; }

        //Foreng Key
        [DisplayName("Tipo de Mercadoria")]
        public long? TipoId { get; set; }
        public Tipo Tipo { get; set; }
    }
}
