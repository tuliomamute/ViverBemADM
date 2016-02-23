using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Diagnostics;

namespace ViverBemADM.Models
{
    public class ViverBemADMContext : DbContext
    {
        public ViverBemADMContext()
        {
            Debug.Write(Database.Connection.ConnectionString);
        }

        public DbSet<Client> Client { get; set; }
        public DbSet<NewsPaperSizes> NewsPaperSizes { get; set; }
        public DbSet<PaymentForm> PaymentForm { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Sellers> Sellers { get; set; }
        public DbSet<SalesSituation> SalesSituation { get; set; }
    }
}