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

        public double Height { get; set; }

        [DisplayName("Largura")]
        public double Width { get; set; }

        [DisplayName("Preço Normal")]
        public double NormalPrice { get; set; }

        [DisplayName("Preço Promocional")]
        public double PromotionalPrice { get; set; }

        [DisplayName("Nome")]
        [MaxLength(20, ErrorMessage = "Tamanho máximo excedido!")]
        public string SizeName { get; set; }

        public virtual ICollection<Sales> Sales { get; set; }
    }
}