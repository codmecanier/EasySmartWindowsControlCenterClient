using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EasySmartDataBaseService.Models.Mapping
{
    public class AlarmToSensorMap : EntityTypeConfiguration<AlarmToSensor>
    {
        public AlarmToSensorMap()
        {
            // Primary Key
            this.HasKey(t => t.AlarmID);

            // Properties
            this.Property(t => t.AlarmID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("AlarmToSensor");
            this.Property(t => t.AlarmID).HasColumnName("AlarmID");
            this.Property(t => t.SensorID).HasColumnName("SensorID");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
