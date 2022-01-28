using HomeApp.Models.Domain.Management.Home.Content;
using Microsoft.EntityFrameworkCore;

namespace HomeApp.Data.Home
{
    public class HomeContentDbContext : DbContext
    {
        public HomeContentDbContext(DbContextOptions<HomeContentDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies(false);
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<InventoryItem>(b =>
            {
                b.HasKey(e => e.Id);
                b.Property(e => e.Id).UseIdentityColumn();
                b.HasOne(c => c.Category).WithMany();
                b.Property(e => e.Value).HasPrecision(10, 2);
                b.HasMany(e => e.Attachments);
                
               // b.HasOne(e => e.PurchaseDetail).WithOne(e => e.InventoryItem);

            });

            modelBuilder.Entity<Category>(b =>
            {
                b.HasKey(e => e.Id);
                b.Property(e => e.Id).UseIdentityColumn();
            });

            modelBuilder.Entity<InventoryItemAttachment>(b =>
            {
                b.HasKey(e => e.Id);
                b.Property(e => e.Id).UseIdentityColumn();
                b.HasOne(e => e.InventoryItem).WithMany(e => e.Attachments);
            });

            modelBuilder.Entity<InventoryItemPurchaseDetail>(b =>
            {
                b.HasKey(e => e.Id);
                b.Property(e => e.Id).UseIdentityColumn();
                b.HasOne(e => e.InventoryItem).WithOne(e => e.PurchaseDetail);
                b.Property(e => e.PurchasedOn).HasColumnType("date");
            });
        }



        public DbSet<InventoryItem> InventoryItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<InventoryItemAttachment> InventoryItemAttachments { get; set; }
        public DbSet<InventoryItemPurchaseDetail> InventoryItemPurchaseDetails { get; set; }




        
    }
}
