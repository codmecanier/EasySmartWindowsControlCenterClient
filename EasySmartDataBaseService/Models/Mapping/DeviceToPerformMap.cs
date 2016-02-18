using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EasySmartDataBaseService.Models.Mapping
{
    public class DeviceToPerformMap : EntityTypeConfiguration<DeviceToPerform>
    {
        public DeviceToPerformMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("DeviceToPerform");
            this.Property(t => t.DeviceID).HasColumnName("DeviceID");
            this.Property(t => t.PerformID).HasColumnName("PerformID");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
