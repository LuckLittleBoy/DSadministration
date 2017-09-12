using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WindowsFormsApplication1.Models.Mapping
{
    public class MedicineMap : EntityTypeConfiguration<Medicine>
    {
        public MedicineMap()
        {
            // Primary Key
            this.HasKey(t => t.NAME);

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.NAME)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.DOSAGE)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.MOLECULES)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.PROADRESS)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LOTSELL_PRICE)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.SELL_PRICE)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.REMARKS)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Medicines");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.NAME).HasColumnName("NAME");
            this.Property(t => t.DOSAGE).HasColumnName("DOSAGE");
            this.Property(t => t.MOLECULES).HasColumnName("MOLECULES");
            this.Property(t => t.STOCK_NUM).HasColumnName("STOCK_NUM");
            this.Property(t => t.PROADRESS).HasColumnName("PROADRESS");
            this.Property(t => t.LOTSELL_PRICE).HasColumnName("LOTSELL_PRICE");
            this.Property(t => t.SELL_PRICE).HasColumnName("SELL_PRICE");
            this.Property(t => t.REMARKS).HasColumnName("REMARKS");
            this.Property(t => t.NUMBER).HasColumnName("NUMBER");
        }
    }
}
