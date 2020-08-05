using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BioFortStat.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<ImagesBio> ImagesBioz { get; set; }
        public DbSet<LGA> LGAz { get; set; }
        public DbSet<State> Statez { get; set; }
        public DbSet<UserInformation> Userz { get; set; }
        public DbSet<Product> Productz { get; set; }
        public DbSet<ProductUnit> Unitz { get; set; }
        public DbSet<MarketDays> MarketDaysz { get; set; }
        public DbSet<Market> Marketz { get; set; }
        public DbSet<Category> Categoryz { get; set; }
        public DbSet<BuyerAndSeller> BuyerAndSellerz { get; set; }
        public DbSet<Title> Titlez { get; set; }
        public DbSet<Gender> Genderz { get; set; }
        public DbSet<Region> Regionz { get; set; }
        public DbSet<Price> Pricez { get; set; }
        public DbSet<ProductCategory> ProdCatez { get; set; }
        public DbSet<Crop> Cropz { get; set; }
        public DbSet<Indicator> Indicatorz { get; set; }
        public DbSet<DistributionRecords> DistributionRecordsz { get; set; }
        public DbSet<RoleViewModel> RoleUsersz { get; set; }
        public DbSet<VendorUser> VendorUserz { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

       // public System.Data.Entity.DbSet<BioFortStat.Models.RoleViewModel> RoleViewModels { get; set; }
    }
}