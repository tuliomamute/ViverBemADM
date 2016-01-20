using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ViverBemADM.Models
{
    public class PaymentForm    
    {
        [Key]
        public int PaymentFormID { get; set; }
        [DisplayName("Forma de Pagamento")]
        public string PaymentFormName { get; set; }
        public virtual ICollection<Sales> Sales { get; set; }
    }
}