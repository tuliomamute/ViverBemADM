using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ViverBemADM.Models
{
    public class Sellers
    {
        [Key]
        public int SellersID { get; set; }
        [DisplayName("Nome do Vendedor")]
        public string SellerName { get; set; }
        [RegularExpression(@"^(\([0-9]{2}\))\s([9]{1})?([0-9]{4})-([0-9]{4})$", ErrorMessage = "O Telefone está em um formato inválido!")]
        [DisplayName("Telefone")]
        public string SellerPhone { get; set; }
        [DisplayName("E-mail")]
        [DataType(DataType.EmailAddress, ErrorMessage = "O Email está em um formato inválido!")]
        public string SellerEmail { get; set; }

        public virtual ICollection<Sales> Sales { get; set; }
    }
}