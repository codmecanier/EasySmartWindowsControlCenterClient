using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EasySmartDataBaseService.Models.Mapping
{
    public class UserToFloorMap : EntityTypeConfiguration<UserToFloor>
    {
        public UserToFloorMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("UserToFloor");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FloorID).HasColumnName("FloorID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.IsAdmin).HasColumnName("IsAdmin");
        }
    }
}
