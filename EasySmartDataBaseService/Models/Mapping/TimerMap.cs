using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EasySmartDataBaseService.Models.Mapping
{
    public class TimerMap : EntityTypeConfiguration<Timer>
    {
        public TimerMap()
        {
            // Primary Key
            this.HasKey(t => new { t.TimerID, t.Timertime, t.TimerName });

            // Properties
            this.Property(t => t.TimerID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TimerName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Timer");
            this.Property(t => t.TimerID).HasColumnName("TimerID");
            this.Property(t => t.Timertime).HasColumnName("Timertime");
            this.Property(t => t.TimerName).HasColumnName("TimerName");
        }
    }
}
