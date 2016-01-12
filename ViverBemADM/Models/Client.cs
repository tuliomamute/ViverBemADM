using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace ViverBemADM.Models
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }
        [DisplayName("Nome do Cliente")]
        public string Name { get; set; }

        [DisplayName("Endereço")]
        public string Address { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string CNPJ { get; set; }
        public string StateInscrition { get; set; }
        public string TownInscrition { get; set; }
        public virtual ICollection<Sales> Sales { get; set; }
    }
}