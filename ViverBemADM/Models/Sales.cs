using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace ViverBemADM.Models
{
    public class Sales
    {
        [Key]      
        public int SalesID { get; set; }
        [DisplayName("Valor da Venda")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public double SaleValue { get; set; }
        [DisplayName("Prazo de Pagamento")]
        public int PaymentTime { get; set; }
        [DisplayName("Situação da Venda")]
        public int SaleSituation { get; set; }
        [DisplayName("% de Comissão")]
        public int SellerPercentage { get; set; }
        [DisplayName("Número da Edição")]
        public int NumberOfEdition { get; set; }
        [DisplayName("Ano da Edição")]
        public int YearOfEdition { get; set; }

        public int ClientID { get; set; }
        [ForeignKey("ClientID")]
        public virtual Client Client { get; set; }

        public int PaymentFormID { get; set; }
        [ForeignKey("PaymentFormID")]
        public virtual PaymentForm PaymentForm { get; set; }

        public int SellersID { get; set; }
        [ForeignKey("SellersID")]
        public virtual Sellers Sellers { get; set; }

        public int NewsPaperSizesID { get; set; }
        [ForeignKey("NewsPaperSizesID")]
        public virtual NewsPaperSizes NewsPaperSizes { get; set; }
    }
}