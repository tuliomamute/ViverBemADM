using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ViverBemADM.Models
{
    public class Sellers
    {
        [Key]
        public int SellersID { get; set; }
        public string SellerName { get; set; }
        public virtual ICollection<Sales> Sales { get; set; }
    }
}