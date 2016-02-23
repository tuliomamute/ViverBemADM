using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;


namespace ViverBemADM.Models
{
    public class SalesSituation
    {
        [Key]
        public int SalesSituationID { get; set; }

        [DisplayName("Situação da Venda")]
        [Required(ErrorMessage = "É obrigado a informar o Nome da Situação da Venda")]
        public string SituationName { get; set; }
    }
}