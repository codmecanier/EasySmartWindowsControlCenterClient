using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EasySmartDataBaseService.Models.Mapping
{
    public class RoomToDeviceMap : EntityTypeConfiguration<RoomToDevice>
    {
        public RoomToDeviceMap()
        {
            // Primary Key
            this.HasKey(t => t.RoomToDeviceID);

            // Properties
            // Table & Column Mappings
            this.ToTable("RoomToDevice");
            this.Property(t => t.RoomID).HasColumnName("RoomID");
            this.Property(t => t.DeviceID).HasColumnName("DeviceID");
            this.Property(t => t.RoomToDeviceID).HasColumnName("RoomToDeviceID");
        }
    }
}
