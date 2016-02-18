using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EasySmartDataBaseService.Models.Mapping
{
    public class SensorMap : EntityTypeConfiguration<Sensor>
    {
        public SensorMap()
        {
            // Primary Key
            this.HasKey(t => t.SenseID);

            // Properties
            this.Property(t => t.SenseName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SensorInfo)
                .IsRequired();

            this.Property(t => t.SensorUnit)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Sensor");
            this.Property(t => t.SenseID).HasColumnName("SenseID");
            this.Property(t => t.SenseName).HasColumnName("SenseName");
            this.Property(t => t.SenserAddress).HasColumnName("SenserAddress");
            this.Property(t => t.SensorInfo).HasColumnName("SensorInfo");
            this.Property(t => t.Sensorvalue).HasColumnName("Sensorvalue");
            this.Property(t => t.SensorBase).HasColumnName("SensorBase");
            this.Property(t => t.SensorCompiction).HasColumnName("SensorCompiction");
            this.Property(t => t.SensorOutPut).HasColumnName("SensorOutPut");
            this.Property(t => t.SensorUnit).HasColumnName("SensorUnit");
            this.Property(t => t.Display).HasColumnName("Display");
            this.Property(t => t.AlarmHigh).HasColumnName("AlarmHigh");
            this.Property(t => t.AlarmLow).HasColumnName("AlarmLow");
            this.Property(t => t.SensorMaxim).HasColumnName("SensorMaxim");
            this.Property(t => t.SensorMinim).HasColumnName("SensorMinim");
        }
    }
}
