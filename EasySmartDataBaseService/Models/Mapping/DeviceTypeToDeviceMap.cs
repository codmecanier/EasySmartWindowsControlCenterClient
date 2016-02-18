using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EasySmartDataBaseService.Models.Mapping
{
    public class DeviceTypeToDeviceMap : EntityTypeConfiguration<DeviceTypeToDevice>
    {
        public DeviceTypeToDeviceMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("DeviceTypeToDevice");
            this.Property(t => t.DeviceTypeID).HasColumnName("DeviceTypeID");
            this.Property(t => t.DeviceID).HasColumnName("DeviceID");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
