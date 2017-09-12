using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WindowsFormsApplication1.Models.Mapping
{
    public class SELLMap : EntityTypeConfiguration<SELL>
    {
        public SELLMap()
        {
            // Primary Key
            this.HasKey(t => t.SELL_ID);

            // Properties
            this.Property(t => t.SELL_ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.SELL_PROOF_ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.DRUG_ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.DRUG_MOLECULES)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.SELL_REMARKS)
                .HasMaxLength(30);

            this.Property(t => t.SELL_OTHERS)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("SELL");
            this.Property(t => t.SELL_ID).HasColumnName("SELL_ID");
            this.Property(t => t.SELL_PROOF_ID).HasColumnName("SELL_PROOF_ID");
            this.Property(t => t.DRUG_ID).HasColumnName("DRUG_ID");
            this.Property(t => t.DRUG_MOLECULES).HasColumnName("DRUG_MOLECULES");
            this.Property(t => t.SELL_NUM).HasColumnName("SELL_NUM");
            this.Property(t => t.SELL_SINGLE_PRICE).HasColumnName("SELL_SINGLE_PRICE");
            this.Property(t => t.SELL_SUM_PRICE).HasColumnName("SELL_SUM_PRICE");
            this.Property(t => t.SELL_REMARKS).HasColumnName("SELL_REMARKS");
            this.Property(t => t.SELL_OTHERS).HasColumnName("SELL_OTHERS");
        }
    }
}
