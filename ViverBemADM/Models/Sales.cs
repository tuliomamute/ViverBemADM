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

        [Required(ErrorMessage = "Obrigatório informar o Valor da Venda")]
        [DisplayName("Valor da Venda")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public double SaleValue { get; set; }

        [DisplayName("Prazo de Pagamento")]
        [Required(ErrorMessage = "Obrigatório informar o Prazo de Pagamento")]
        [Column(TypeName = "Date")]
        public DateTime? PaymentTime { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o % de Comissão")]
        [DisplayName("% de Comissão")]
        public int SellerPercentage { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Número da Edição")]
        [DisplayName("Número da Edição")]
        public int NumberOfEdition { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Ano da Edição")]
        [DisplayName("Ano da Edição")]
        public int YearOfEdition { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Cliente")]
        public int ClientID { get; set; }

        [ForeignKey("ClientID")]
        public virtual Client Client { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Forma de Pagamento")]
        public int PaymentFormID { get; set; }

        [ForeignKey("PaymentFormID")]
        public virtual PaymentForm PaymentForm { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Vendedor")]
        public int SellersID { get; set; }

        [ForeignKey("SellersID")]
        public virtual Sellers Sellers { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Tamanho do Anúncio")]
        public int NewsPaperSizesID { get; set; }

        [ForeignKey("NewsPaperSizesID")]
        public virtual NewsPaperSizes NewsPaperSizes { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Situação da Venda")]
        [DisplayName("Situação da Venda")]
        public int SalesSituationID { get; set; }

        [ForeignKey("SalesSituationID")]
        public virtual SalesSituation SalesSituation { get; set; }


    }
}