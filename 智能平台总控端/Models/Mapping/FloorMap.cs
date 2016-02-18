using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace 智能平台总控端.Models.Mapping
{
    public class FloorMap : EntityTypeConfiguration<Floor>
    {
        public FloorMap()
        {
            // Primary Key
            this.HasKey(t => t.FloorID);

            // Properties
            this.Property(t => t.FloorName)
                .IsRequired();

            this.Property(t => t.FloorInfo)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Floor");
            this.Property(t => t.FloorID).HasColumnName("FloorID");
            this.Property(t => t.FloorName).HasColumnName("FloorName");
            this.Property(t => t.FloorInfo).HasColumnName("FloorInfo");
        }
    }
}
