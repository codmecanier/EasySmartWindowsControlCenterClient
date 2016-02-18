using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace 智能平台总控端.Models.Mapping
{
    public class RoomToUserMap : EntityTypeConfiguration<RoomToUser>
    {
        public RoomToUserMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("RoomToUser");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.RoomID).HasColumnName("RoomID");
            this.Property(t => t.IsAdmin).HasColumnName("IsAdmin");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
