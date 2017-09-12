using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WindowsFormsApplication1.Models.Mapping
{
    public class OUTSTOCKMap : EntityTypeConfiguration<OUTSTOCK>
    {
        public OUTSTOCKMap()
        {
            // Primary Key
            this.HasKey(t => t.OUTSTOCK_ID);

            // Properties
            this.Property(t => t.OUTSTOCK_ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.FK_DRUG_ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.OUTSTOCK_DATE)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.FK_CLIENT_ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.FK_STAFF_ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.OUTSTOCK_REMARKS)
                .HasMaxLength(30);

            this.Property(t => t.OUTSTOCK_OTHERS)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("OUTSTOCK");
            this.Property(t => t.OUTSTOCK_ID).HasColumnName("OUTSTOCK_ID");
            this.Property(t => t.FK_DRUG_ID).HasColumnName("FK_DRUG_ID");
            this.Property(t => t.OUTSTOCK_DATE).HasColumnName("OUTSTOCK_DATE");
            this.Property(t => t.OUTSTOCK_SELLPRICE).HasColumnName("OUTSTOCK_SELLPRICE");
            this.Property(t => t.FK_CLIENT_ID).HasColumnName("FK_CLIENT_ID");
            this.Property(t => t.FK_STAFF_ID).HasColumnName("FK_STAFF_ID");
            this.Property(t => t.OUTSTOCK_REMARKS).HasColumnName("OUTSTOCK_REMARKS");
            this.Property(t => t.OUTSTOCK_OTHERS).HasColumnName("OUTSTOCK_OTHERS");

            // Relationships
            this.HasRequired(t => t.CLIENT)
                .WithMany(t => t.OUTSTOCKs)
                .HasForeignKey(d => d.FK_CLIENT_ID);
            this.HasRequired(t => t.STAFF)
                .WithMany(t => t.OUTSTOCKs)
                .HasForeignKey(d => d.FK_STAFF_ID);

        }
    }
}
