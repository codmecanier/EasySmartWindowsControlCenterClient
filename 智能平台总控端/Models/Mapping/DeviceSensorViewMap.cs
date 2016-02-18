using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace 智能平台总控端.Models.Mapping
{
    public class DeviceSensorViewMap : EntityTypeConfiguration<DeviceSensorView>
    {
        public DeviceSensorViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SenseID, t.SenseName, t.SenserAddress, t.SensorInfo, t.Sensorvalue, t.SensorBase, t.SensorCompiction, t.SensorUnit, t.DeviceID, t.AlarmHigh, t.AlarmLow, t.SensorMaxim, t.SensorMinim, t.UserID, t.Expr1, t.Visible, t.ArrowReadData, t.IsAdmin });

            // Properties
            this.Property(t => t.SenseID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SenseName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SenserAddress)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SensorInfo)
                .IsRequired();

            this.Property(t => t.Sensorvalue)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SensorBase)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SensorCompiction)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SensorUnit)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DeviceID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AlarmHigh)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AlarmLow)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SensorMaxim)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SensorMinim)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Expr1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DeviceSensorView");
            this.Property(t => t.SenseID).HasColumnName("SenseID");
            this.Property(t => t.SenseName).HasColumnName("SenseName");
            this.Property(t => t.SenserAddress).HasColumnName("SenserAddress");
            this.Property(t => t.SensorInfo).HasColumnName("SensorInfo");
            this.Property(t => t.Sensorvalue).HasColumnName("Sensorvalue");
            this.Property(t => t.SensorBase).HasColumnName("SensorBase");
            this.Property(t => t.SensorCompiction).HasColumnName("SensorCompiction");
            this.Property(t => t.SensorUnit).HasColumnName("SensorUnit");
            this.Property(t => t.DeviceID).HasColumnName("DeviceID");
            this.Property(t => t.AlarmHigh).HasColumnName("AlarmHigh");
            this.Property(t => t.AlarmLow).HasColumnName("AlarmLow");
            this.Property(t => t.SensorMaxim).HasColumnName("SensorMaxim");
            this.Property(t => t.SensorMinim).HasColumnName("SensorMinim");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.Expr1).HasColumnName("Expr1");
            this.Property(t => t.Visible).HasColumnName("Visible");
            this.Property(t => t.ArrowReadData).HasColumnName("ArrowReadData");
            this.Property(t => t.IsAdmin).HasColumnName("IsAdmin");
        }
    }
}
