using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EasySmartDataBaseService.Models.Mapping
{
    public class UserToRoleMap : EntityTypeConfiguration<UserToRole>
    {
        public UserToRoleMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("UserToRole");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RoleID).HasColumnName("RoleID");
            this.Property(t => t.UserID).HasColumnName("UserID");
        }
    }
}
