using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EasySmartDataBaseService.Models.Mapping
{
    public class UserSensorPowerMap : EntityTypeConfiguration<UserSensorPower>
    {
        public UserSensorPowerMap()
        {
            // Primary Key
            this.HasKey(t => t.UserID);

            // Properties
            this.Property(t => t.UserID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("UserSensorPower");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.SenseID).HasColumnName("SenseID");
            this.Property(t => t.Visible).HasColumnName("Visible");
            this.Property(t => t.ArrowReadData).HasColumnName("ArrowReadData");
            this.Property(t => t.IsAdmin).HasColumnName("IsAdmin");
        }
    }
}
