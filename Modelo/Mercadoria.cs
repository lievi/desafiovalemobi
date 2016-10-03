﻿using System;
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
        [RegularExpression(@"[0-9]{0,10}[,]{0,1}[0-9]{0,4}",ErrorMessage = "Digite um valor com vírgula")]
        public float ValorMercadoria { get; set; }

        //Foreng Key
        public long? TipoId { get; set; }
        public Tipo Tipo { get; set; }
    }
}
