using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace 智能平台总控端.Models.Mapping
{
    public class AlarmMap : EntityTypeConfiguration<Alarm>
    {
        public AlarmMap()
        {
            // Primary Key
            this.HasKey(t => t.AlarmID);

            // Properties
            this.Property(t => t.AlarmName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AlarmText)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Alarm");
            this.Property(t => t.AlarmID).HasColumnName("AlarmID");
            this.Property(t => t.AlarmName).HasColumnName("AlarmName");
            this.Property(t => t.AlarmText).HasColumnName("AlarmText");
            this.Property(t => t.AlarmHighValue).HasColumnName("AlarmHighValue");
            this.Property(t => t.AlarmLowValue).HasColumnName("AlarmLowValue");
            this.Property(t => t.AlarmTickTime).HasColumnName("AlarmTickTime");
            this.Property(t => t.AlarmKeepingTime).HasColumnName("AlarmKeepingTime");
            this.Property(t => t.AlarmMachValue).HasColumnName("AlarmMachValue");
        }
    }
}
