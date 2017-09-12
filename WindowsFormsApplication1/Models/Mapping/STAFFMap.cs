using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WindowsFormsApplication1.Models.Mapping
{
    public class STAFFMap : EntityTypeConfiguration<STAFF>
    {
        public STAFFMap()
        {
            // Primary Key
            this.HasKey(t => t.STAFF_ID);

            // Properties
            this.Property(t => t.STAFF_ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.STAFF_NAME)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.STAFF_USERNAME)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.STAFF_PASSWORD)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.STAFF_IDCARDNUM)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.STAFF_ADRESS)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.STAFF_CONTACTER)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.STAFF_POSITION)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.STAFF_POWER)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.STAFF_REMARKS)
                .HasMaxLength(30);

            this.Property(t => t.STAFF_OTHERS)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("STAFF");
            this.Property(t => t.STAFF_ID).HasColumnName("STAFF_ID");
            this.Property(t => t.STAFF_NAME).HasColumnName("STAFF_NAME");
            this.Property(t => t.STAFF_USERNAME).HasColumnName("STAFF_USERNAME");
            this.Property(t => t.STAFF_PASSWORD).HasColumnName("STAFF_PASSWORD");
            this.Property(t => t.STAFF_IDCARDNUM).HasColumnName("STAFF_IDCARDNUM");
            this.Property(t => t.STAFF_ADRESS).HasColumnName("STAFF_ADRESS");
            this.Property(t => t.STAFF_CONTACTER).HasColumnName("STAFF_CONTACTER");
            this.Property(t => t.STAFF_POSITION).HasColumnName("STAFF_POSITION");
            this.Property(t => t.STAFF_POWER).HasColumnName("STAFF_POWER");
            this.Property(t => t.STAFF_REMARKS).HasColumnName("STAFF_REMARKS");
            this.Property(t => t.STAFF_OTHERS).HasColumnName("STAFF_OTHERS");
        }
    }
}
