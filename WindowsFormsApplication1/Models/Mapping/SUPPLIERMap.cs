using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WindowsFormsApplication1.Models.Mapping
{
    public class SUPPLIERMap : EntityTypeConfiguration<SUPPLIER>
    {
        public SUPPLIERMap()
        {
            // Primary Key
            this.HasKey(t => t.SUPPLIER_ID);

            // Properties
            this.Property(t => t.SUPPLIER_ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.SUPPLIER_NAME)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.SUPPLIER_ADRESS)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.SUPPLIER_CONTACTER)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.SUPPLIER_TEL)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.SUPPLIER_REMARKS)
                .HasMaxLength(30);

            this.Property(t => t.SUPPLIER_OTHERS)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("SUPPLIER");
            this.Property(t => t.SUPPLIER_ID).HasColumnName("SUPPLIER_ID");
            this.Property(t => t.SUPPLIER_NAME).HasColumnName("SUPPLIER_NAME");
            this.Property(t => t.SUPPLIER_ADRESS).HasColumnName("SUPPLIER_ADRESS");
            this.Property(t => t.SUPPLIER_CONTACTER).HasColumnName("SUPPLIER_CONTACTER");
            this.Property(t => t.SUPPLIER_TEL).HasColumnName("SUPPLIER_TEL");
            this.Property(t => t.SUPPLIER_REMARKS).HasColumnName("SUPPLIER_REMARKS");
            this.Property(t => t.SUPPLIER_OTHERS).HasColumnName("SUPPLIER_OTHERS");
        }
    }
}
