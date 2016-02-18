using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace 智能平台总控端.Models.Mapping
{
    public class DeviceMap : EntityTypeConfiguration<Device>
    {
        public DeviceMap()
        {
            // Primary Key
            this.HasKey(t => t.DeviceID);

            // Properties
            this.Property(t => t.DeviceName)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.DeviceInfo)
                .IsRequired();

            this.Property(t => t.DeviceImage)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Device");
            this.Property(t => t.DeviceID).HasColumnName("DeviceID");
            this.Property(t => t.DeviceName).HasColumnName("DeviceName");
            this.Property(t => t.DeviceAddress).HasColumnName("DeviceAddress");
            this.Property(t => t.DeviceInfo).HasColumnName("DeviceInfo");
            this.Property(t => t.DeviceImage).HasColumnName("DeviceImage");
        }
    }
}
