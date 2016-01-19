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

        [RegularExpression(@"^\d*\.?\d*", ErrorMessage = "O campo Altura deve ser numérico!")]
        [DisplayName("Altura")]
        [Required(ErrorMessage = "Obrigatório informar a Altura")]
        public double Height { get; set; }

        [DisplayName("Largura")]
        [Required(ErrorMessage = "Obrigatório informar a Largura")]
        [RegularExpression(@"^\d*\.?\d*", ErrorMessage = "O campo Altura deve ser numérico!")]
        public double Width { get; set; }

        [DisplayName("Preço Normal")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Required(ErrorMessage = "Obrigatório informar o Preço Normal")]
        [RegularExpression(@"^\d*\.?\d*", ErrorMessage = "O campo Altura deve ser numérico!")]

        public double NormalPrice { get; set; }

        [DisplayName("Preço Promocional")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [RegularExpression(@"^\d*\.?\d*", ErrorMessage = "O campo Altura deve ser numérico!")]

        public double? PromotionalPrice { get; set; }

        [DisplayName("Nome")]
        [MaxLength(30, ErrorMessage = "Tamanho máximo excedido!")]
        [Required(ErrorMessage = "Obrigatório informar o Nome")]

        public string SizeName { get; set; }

        public virtual ICollection<Sales> Sales { get; set; }
    }
}