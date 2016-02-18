using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace 智能平台总控端.Models.Mapping
{
    public class DeviceToSensorMap : EntityTypeConfiguration<DeviceToSensor>
    {
        public DeviceToSensorMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("DeviceToSensor");
            this.Property(t => t.DeviceID).HasColumnName("DeviceID");
            this.Property(t => t.SensorID).HasColumnName("SensorID");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
