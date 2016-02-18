using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace 智能平台总控端.Models.Mapping
{
    public class AlarmViewMap : EntityTypeConfiguration<AlarmView>
    {
        public AlarmViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AlarmID, t.SensorID, t.AlarmName, t.AlarmText, t.AlarmHighValue, t.AlarmLowValue, t.AlarmTickTime, t.AlarmKeepingTime, t.UserID, t.IsAdmin });

            // Properties
            this.Property(t => t.AlarmID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SensorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AlarmName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AlarmText)
                .IsRequired();

            this.Property(t => t.AlarmHighValue)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AlarmLowValue)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AlarmTickTime)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AlarmKeepingTime)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AlarmView");
            this.Property(t => t.AlarmID).HasColumnName("AlarmID");
            this.Property(t => t.SensorID).HasColumnName("SensorID");
            this.Property(t => t.AlarmName).HasColumnName("AlarmName");
            this.Property(t => t.AlarmText).HasColumnName("AlarmText");
            this.Property(t => t.AlarmHighValue).HasColumnName("AlarmHighValue");
            this.Property(t => t.AlarmLowValue).HasColumnName("AlarmLowValue");
            this.Property(t => t.AlarmTickTime).HasColumnName("AlarmTickTime");
            this.Property(t => t.AlarmKeepingTime).HasColumnName("AlarmKeepingTime");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.IsAdmin).HasColumnName("IsAdmin");
        }
    }
}
