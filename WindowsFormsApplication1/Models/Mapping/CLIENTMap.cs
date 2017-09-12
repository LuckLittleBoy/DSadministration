using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WindowsFormsApplication1.Models.Mapping
{
    public class CLIENTMap : EntityTypeConfiguration<CLIENT>
    {
        public CLIENTMap()
        {
            // Primary Key
            this.HasKey(t => t.CLIENT_ID);

            // Properties
            this.Property(t => t.CLIENT_ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CLIENT_NAME)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CLIENT_ADRESS)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CLIENT_CONTACTER)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CLIENT_TEL)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CLIENT_REMARKS)
                .HasMaxLength(30);

            this.Property(t => t.CLIENT_OTHERS)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("CLIENT");
            this.Property(t => t.CLIENT_ID).HasColumnName("CLIENT_ID");
            this.Property(t => t.CLIENT_NAME).HasColumnName("CLIENT_NAME");
            this.Property(t => t.CLIENT_ADRESS).HasColumnName("CLIENT_ADRESS");
            this.Property(t => t.CLIENT_CONTACTER).HasColumnName("CLIENT_CONTACTER");
            this.Property(t => t.CLIENT_TEL).HasColumnName("CLIENT_TEL");
            this.Property(t => t.CLIENT_REMARKS).HasColumnName("CLIENT_REMARKS");
            this.Property(t => t.CLIENT_OTHERS).HasColumnName("CLIENT_OTHERS");
        }
    }
}
