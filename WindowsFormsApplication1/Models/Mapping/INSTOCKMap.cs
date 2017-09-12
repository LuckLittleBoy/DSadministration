using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WindowsFormsApplication1.Models.Mapping
{
    public class INSTOCKMap : EntityTypeConfiguration<INSTOCK>
    {
        public INSTOCKMap()
        {
            // Primary Key
            this.HasKey(t => t.INSTOCK_ID);

            // Properties
            this.Property(t => t.INSTOCK_ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.FK_DRUG_ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.INSTOCK_DATE)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.INSTOCK_PROOF_ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.FK_SUPPLIER_ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.INSTOCK_LOTBUY_PRICE)
                .HasMaxLength(20);

            this.Property(t => t.FK_STAFF_ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.INSTOCK_REMARKS)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.INSTOCK_OTHERS)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.FK_DRUG_NAME)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.INSTOCK_SELL_PRICE)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("INSTOCK");
            this.Property(t => t.INSTOCK_ID).HasColumnName("INSTOCK_ID");
            this.Property(t => t.FK_DRUG_ID).HasColumnName("FK_DRUG_ID");
            this.Property(t => t.INSTOCK_DATE).HasColumnName("INSTOCK_DATE");
            this.Property(t => t.INSTOCK_PROOF_ID).HasColumnName("INSTOCK_PROOF_ID");
            this.Property(t => t.INSTOCK_NUM).HasColumnName("INSTOCK_NUM");
            this.Property(t => t.FK_SUPPLIER_ID).HasColumnName("FK_SUPPLIER_ID");
            this.Property(t => t.INSTOCK_LOTBUY_PRICE).HasColumnName("INSTOCK_LOTBUY_PRICE");
            this.Property(t => t.FK_STAFF_ID).HasColumnName("FK_STAFF_ID");
            this.Property(t => t.INSTOCK_REMARKS).HasColumnName("INSTOCK_REMARKS");
            this.Property(t => t.INSTOCK_OTHERS).HasColumnName("INSTOCK_OTHERS");
            this.Property(t => t.FK_DRUG_NAME).HasColumnName("FK_DRUG_NAME");
            this.Property(t => t.INSTOCK_SELL_PRICE).HasColumnName("INSTOCK_SELL_PRICE");

            // Relationships
            this.HasRequired(t => t.STAFF)
                .WithMany(t => t.INSTOCKs)
                .HasForeignKey(d => d.FK_STAFF_ID);
            this.HasRequired(t => t.SUPPLIER)
                .WithMany(t => t.INSTOCKs)
                .HasForeignKey(d => d.FK_SUPPLIER_ID);

        }
    }
}
