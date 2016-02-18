using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace 智能平台总控端.Models.Mapping
{
    public class DeviceToUserMap : EntityTypeConfiguration<DeviceToUser>
    {
        public DeviceToUserMap()
        {
            // Primary Key
            this.HasKey(t => new { t.UserID, t.DeviceID, t.IsAdmin });

            // Properties
            this.Property(t => t.UserID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DeviceID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DeviceToUser");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.DeviceID).HasColumnName("DeviceID");
            this.Property(t => t.IsAdmin).HasColumnName("IsAdmin");
        }
    }
}
