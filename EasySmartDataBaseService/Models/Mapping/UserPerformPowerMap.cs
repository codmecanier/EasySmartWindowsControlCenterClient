using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EasySmartDataBaseService.Models.Mapping
{
    public class UserPerformPowerMap : EntityTypeConfiguration<UserPerformPower>
    {
        public UserPerformPowerMap()
        {
            // Primary Key
            this.HasKey(t => t.UserID);

            // Properties
            this.Property(t => t.UserID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("UserPerformPower");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.PerformID).HasColumnName("PerformID");
            this.Property(t => t.Visible).HasColumnName("Visible");
            this.Property(t => t.ArrowRead).HasColumnName("ArrowRead");
            this.Property(t => t.ArrowUpdate).HasColumnName("ArrowUpdate");
            this.Property(t => t.IsAdmin).HasColumnName("IsAdmin");
        }
    }
}
