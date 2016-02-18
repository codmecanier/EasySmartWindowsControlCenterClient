using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EasySmartDataBaseService.Models.Mapping
{
    public class UserToTimerMap : EntityTypeConfiguration<UserToTimer>
    {
        public UserToTimerMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("UserToTimer");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.TimerID).HasColumnName("TimerID");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
