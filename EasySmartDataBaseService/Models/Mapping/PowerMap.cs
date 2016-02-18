using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EasySmartDataBaseService.Models.Mapping
{
    public class PowerMap : EntityTypeConfiguration<Power>
    {
        public PowerMap()
        {
            // Primary Key
            this.HasKey(t => t.PowerID);

            // Properties
            this.Property(t => t.PowerValue)
                .IsRequired();

            this.Property(t => t.PowerDisplay)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Power");
            this.Property(t => t.PowerID).HasColumnName("PowerID");
            this.Property(t => t.PowerValue).HasColumnName("PowerValue");
            this.Property(t => t.PowerDisplay).HasColumnName("PowerDisplay");
        }
    }
}
