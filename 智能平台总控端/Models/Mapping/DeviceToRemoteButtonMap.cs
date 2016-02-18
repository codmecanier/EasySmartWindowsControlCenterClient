using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace 智能平台总控端.Models.Mapping
{
    public class DeviceToRemoteButtonMap : EntityTypeConfiguration<DeviceToRemoteButton>
    {
        public DeviceToRemoteButtonMap()
        {
            // Primary Key
            this.HasKey(t => t.Device);

            // Properties
            this.Property(t => t.Device)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DeviceToRemoteButton");
            this.Property(t => t.Device).HasColumnName("Device");
            this.Property(t => t.RemoteButtonID).HasColumnName("RemoteButtonID");
        }
    }
}
