using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using WindowsFormsApplication1.Models.Mapping;

namespace WindowsFormsApplication1.Models
{
    public partial class drugsroreContext : DbContext
    {
        static drugsroreContext()
        {
            Database.SetInitializer<drugsroreContext>(null);
        }

        public drugsroreContext()
            : base("Name=drugsroreContext")
        {
        }

        public DbSet<CLIENT> CLIENTs { get; set; }
        public DbSet<INSTOCK> INSTOCKs { get; set; }
        public DbSet<INSTOCK_MONEY> INSTOCK_MONEY { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<OUTSTOCK> OUTSTOCKs { get; set; }
        public DbSet<ROLE> ROLES { get; set; }
        public DbSet<SELL> SELLs { get; set; }
        public DbSet<STAFF> STAFFs { get; set; }
        public DbSet<STOCK> STOCKs { get; set; }
        public DbSet<SUPPLIER> SUPPLIERs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CLIENTMap());
            modelBuilder.Configurations.Add(new INSTOCKMap());
            modelBuilder.Configurations.Add(new INSTOCK_MONEYMap());
            modelBuilder.Configurations.Add(new MedicineMap());
            modelBuilder.Configurations.Add(new OUTSTOCKMap());
            modelBuilder.Configurations.Add(new ROLEMap());
            modelBuilder.Configurations.Add(new SELLMap());
            modelBuilder.Configurations.Add(new STAFFMap());
            modelBuilder.Configurations.Add(new STOCKMap());
            modelBuilder.Configurations.Add(new SUPPLIERMap());
        }
    }
}
