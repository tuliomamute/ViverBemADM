using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViverBemADM.Models
{
    public class NewsPaperSizes
    {
        [Key]
        public int NewsPaperSizesID { get; set; }

        [DisplayName("Altura")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Required(ErrorMessage = "Obrigatório informar a Altura")]
        public decimal Height { get; set; }

        [DisplayName("Largura")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Required(ErrorMessage = "Obrigatório informar a Largura")]
        public decimal Width { get; set; }

        [DisplayName("Preço Normal")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Required(ErrorMessage = "Obrigatório informar o Preço Normal")]

        public decimal NormalPrice { get; set; }

        [DisplayName("Preço Promocional")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}")]

        public decimal? PromotionalPrice { get; set; }

        [DisplayName("Nome")]
        [MaxLength(30, ErrorMessage = "Tamanho máximo excedido!")]
        [Required(ErrorMessage = "Obrigatório informar o Nome")]

        public string SizeName { get; set; }

        public virtual ICollection<Sales> Sales { get; set; }
    }
}