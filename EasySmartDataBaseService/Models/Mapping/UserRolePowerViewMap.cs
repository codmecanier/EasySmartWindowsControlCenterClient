using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EasySmartDataBaseService.Models.Mapping
{
    public class UserRolePowerViewMap : EntityTypeConfiguration<UserRolePowerView>
    {
        public UserRolePowerViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.UserID, t.UserName, t.RoleName, t.RoleRemark, t.PowerValue, t.PowerDisplay });

            // Properties
            this.Property(t => t.UserID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RoleName)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.RoleRemark)
                .IsRequired();

            this.Property(t => t.PowerValue)
                .IsRequired();

            this.Property(t => t.PowerDisplay)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("UserRolePowerView");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.RoleName).HasColumnName("RoleName");
            this.Property(t => t.RoleRemark).HasColumnName("RoleRemark");
            this.Property(t => t.PowerValue).HasColumnName("PowerValue");
            this.Property(t => t.PowerDisplay).HasColumnName("PowerDisplay");
        }
    }
}
