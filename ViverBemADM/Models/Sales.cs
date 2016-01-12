using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViverBemADM.Models
{
    public class Sales
    {
        [Key]
        public int SalesID { get; set; }
        public double SaleValue { get; set; }
        public int PaymentTime { get; set; }
        public int SaleSituation { get; set; }
        public int SellerPercentage { get; set; }
        public int NumberOfEdition { get; set; }
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