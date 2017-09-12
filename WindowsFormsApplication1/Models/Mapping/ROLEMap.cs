using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WindowsFormsApplication1.Models.Mapping
{
    public class ROLEMap : EntityTypeConfiguration<ROLE>
    {
        public ROLEMap()
        {
            // Primary Key
            this.HasKey(t => t.ROLES_ID);

            // Properties
            this.Property(t => t.ROLES_ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ROLES_NAME)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ROLES_POWER)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ROLES_OTHERS)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("ROLES");
            this.Property(t => t.ROLES_ID).HasColumnName("ROLES_ID");
            this.Property(t => t.ROLES_NAME).HasColumnName("ROLES_NAME");
            this.Property(t => t.ROLES_POWER).HasColumnName("ROLES_POWER");
            this.Property(t => t.ROLES_OTHERS).HasColumnName("ROLES_OTHERS");
        }
    }
}
