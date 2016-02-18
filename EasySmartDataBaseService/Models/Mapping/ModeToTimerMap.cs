using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EasySmartDataBaseService.Models.Mapping
{
    public class ModeToTimerMap : EntityTypeConfiguration<ModeToTimer>
    {
        public ModeToTimerMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ModeToTimer");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TimerID).HasColumnName("TimerID");
            this.Property(t => t.ModeID).HasColumnName("ModeID");
        }
    }
}
