using HEALTH.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HEALTH.Data
{
    public class HEALTHDbContext : DbContext
    {

        public DbSet<AffectationCaisse> AffectationCaisses { get; set; }
        public DbSet<Caisse> Caisses { get; set; }
        public DbSet<CaisseOperation> CaisseOperations { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Paiement> Paiements { get; set; }
        public DbSet<Prestation> Prestations { get; set; }
        public DbSet<PrestationProduit> PrestationProduits { get; set; }
        public DbSet<PrestationSoin> PrestationSoins { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Profil> Profils { get; set; }
        public DbSet<Soin> Soins { get; set; }
        public DbSet<TypeSoin> TypeSoins { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=CERGITECH48-PC\MSSQLSERVER2014;Initial Catalog=HEALTH;Integrated Security=True;");
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json").Build();
            string config = configuration.GetConnectionString("DefaultConnection");//  remoteHirac
            optionsBuilder.UseSqlServer(@config);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Utilisateur>()
        //                .HasRequired(a => a.BillingAddress)
        //                .WithMany()
        //                .HasForeignKey(u => u.BillingAddressId);

        //    modelBuilder.Entity<User>()
        //                .HasRequired(a => a.DeliveryAddress)
        //                .WithMany()
        //                .HasForeignKey(u => u.DeliveryAddressId);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AffectationCaisse>().ToTable("AFFECTATIONCAISSE");
            modelBuilder.Entity<Caisse>().ToTable("CAISSE");
            modelBuilder.Entity<CaisseOperation>().ToTable("CAISSEOPERATION");
            modelBuilder.Entity<Categorie>().ToTable("CATEGORIE");
            modelBuilder.Entity<Paiement>().ToTable("PAIEMENT");
            modelBuilder.Entity<Prestation>().ToTable("PRESTATION");
            modelBuilder.Entity<PrestationProduit>().ToTable("PRESTATIONPRODUIT");
            modelBuilder.Entity<PrestationSoin>().ToTable("PRESTATIONSOIN");
            modelBuilder.Entity<Produit>().ToTable("PRODUIT");
            modelBuilder.Entity<Profil>().ToTable("PROFIL");
            modelBuilder.Entity<Soin>().ToTable("SOIN");
            modelBuilder.Entity<TypeSoin>().ToTable("TYPESOIN");
            modelBuilder.Entity<User>().ToTable("USER");

            modelBuilder.Entity<AffectationCaisse>()
                .HasKey(afc => new { afc.CaisseOperation_ID, afc.User_ID });
            modelBuilder.Entity<PrestationProduit>()
                .HasKey(pp => new { pp.Prestation_ID, pp.Produit_ID });
            modelBuilder.Entity<PrestationSoin>()
                .HasKey(ps => new { ps.Prestation_ID, ps.Soin_ID });

        }

    }
}
