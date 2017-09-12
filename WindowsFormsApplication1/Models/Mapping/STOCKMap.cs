using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WindowsFormsApplication1.Models.Mapping
{
    public class STOCKMap : EntityTypeConfiguration<STOCK>
    {
        public STOCKMap()
        {
            // Primary Key
            this.HasKey(t => t.DRUG_NAME);

            // Properties
            this.Property(t => t.DRUG_ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.DRUG_NAME)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.DRUG_PROADRESS)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.DRUG_MOLECULES)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.DRUG_EFFECTIVE_DATE)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.DRUG_LOT_NUM)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.DRUG_CATEGORY)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.DRUG_SELL_PRICE)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.DRUG_LOTSELL_PRICE)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.DRUG_REMARKS)
                .HasMaxLength(30);

            this.Property(t => t.DRUG_OTHERS)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("STOCK");
            this.Property(t => t.DRUG_ID).HasColumnName("DRUG_ID");
            this.Property(t => t.DRUG_NAME).HasColumnName("DRUG_NAME");
            this.Property(t => t.DRUG_DOSAGE).HasColumnName("DRUG_DOSAGE");
            this.Property(t => t.DRUG_PROADRESS).HasColumnName("DRUG_PROADRESS");
            this.Property(t => t.DRUG_PACK_NUM).HasColumnName("DRUG_PACK_NUM");
            this.Property(t => t.DRUG_STOCK_NUM).HasColumnName("DRUG_STOCK_NUM");
            this.Property(t => t.DRUG_MOLECULES).HasColumnName("DRUG_MOLECULES");
            this.Property(t => t.DRUG_EFFECTIVE_DATE).HasColumnName("DRUG_EFFECTIVE_DATE");
            this.Property(t => t.DRUG_LOT_NUM).HasColumnName("DRUG_LOT_NUM");
            this.Property(t => t.DRUG_CATEGORY).HasColumnName("DRUG_CATEGORY");
            this.Property(t => t.DRUG_SELL_PRICE).HasColumnName("DRUG_SELL_PRICE");
            this.Property(t => t.DRUG_LOTSELL_PRICE).HasColumnName("DRUG_LOTSELL_PRICE");
            this.Property(t => t.DRUG_REMARKS).HasColumnName("DRUG_REMARKS");
            this.Property(t => t.DRUG_OTHERS).HasColumnName("DRUG_OTHERS");
        }
    }
}
