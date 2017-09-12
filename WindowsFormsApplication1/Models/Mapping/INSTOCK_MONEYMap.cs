using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WindowsFormsApplication1.Models.Mapping
{
    public class INSTOCK_MONEYMap : EntityTypeConfiguration<INSTOCK_MONEY>
    {
        public INSTOCK_MONEYMap()
        {
            // Primary Key
            this.HasKey(t => t.IM_PROOF_ID);

            // Properties
            this.Property(t => t.IM_PROOF_ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.IM_TOTAL_PRICE)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.IM_SUPPLIER_NAME)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.IM_DATE)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.IM_REAL_PAYMENT)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.IM_DEBT_PAYMENT)
                .HasMaxLength(20);

            this.Property(t => t.IM_REMARKS)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("INSTOCK_MONEY");
            this.Property(t => t.IM_PROOF_ID).HasColumnName("IM_PROOF_ID");
            this.Property(t => t.IM_TOTAL_PRICE).HasColumnName("IM_TOTAL_PRICE");
            this.Property(t => t.IM_SUPPLIER_NAME).HasColumnName("IM_SUPPLIER_NAME");
            this.Property(t => t.IM_DATE).HasColumnName("IM_DATE");
            this.Property(t => t.IM_REAL_PAYMENT).HasColumnName("IM_REAL_PAYMENT");
            this.Property(t => t.IM_DEBT_PAYMENT).HasColumnName("IM_DEBT_PAYMENT");
            this.Property(t => t.IM_REMARKS).HasColumnName("IM_REMARKS");
        }
    }
}
