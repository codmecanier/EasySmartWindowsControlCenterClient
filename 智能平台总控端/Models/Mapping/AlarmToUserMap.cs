using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace 智能平台总控端.Models.Mapping
{
    public class AlarmToUserMap : EntityTypeConfiguration<AlarmToUser>
    {
        public AlarmToUserMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AlarmID, t.UserID, t.IsAdmin });

            // Properties
            this.Property(t => t.AlarmID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AlarmToUser");
            this.Property(t => t.AlarmID).HasColumnName("AlarmID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.IsAdmin).HasColumnName("IsAdmin");
        }
    }
}
