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

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Obrigado a informar o Nome do Cliente")]
        public string Name { get; set; }

        [DisplayName("Endereço")]
        [Required(ErrorMessage = "Obrigado a informar o Endereço")]
        public string Address { get; set; }

        [DisplayName("Nome do Contato")]
        [Required(ErrorMessage = "Obrigado a informar o Nome do Contato")]
        [MaxLength(20, ErrorMessage = "Tamanho máximo é de 20 caracteres!")]
        public string ContactName { get; set; }

        [DisplayName("Telefone do Contato")]
        [RegularExpression(@"^(\([0-9]{2}\))\s([9]{1})?([0-9]{4})-([0-9]{4})$", ErrorMessage = "O Telefone do Contato está em um formato inválido!")]
        [Required(ErrorMessage = "Obrigado a informar o Telefone do Contato")]
        public string ContactPhone { get; set; }

        [DisplayName("Email do Contato")]
        [DataType(DataType.EmailAddress, ErrorMessage = "O Email do Contato está em um formato inválido!")]
        [Required(ErrorMessage = "Obrigado a informar o Email do contato")]
        public string ContactEmail { get; set; }

        [DisplayName("CNPJ")]
        [Required(ErrorMessage = "Obrigado a informar o CNPJ")]
        public string CNPJ { get; set; }

        [DisplayName("Inscrição Estadual")]
        public string StateInscrition { get; set; }

        [DisplayName("Inscrição Municipal")]
        public string TownInscrition { get; set; }

        public virtual ICollection<Sales> Sales { get; set; }
    }
}