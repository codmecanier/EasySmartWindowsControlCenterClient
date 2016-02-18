using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace 智能平台总控端.Models.Mapping
{
    public class FloorToRoomMap : EntityTypeConfiguration<FloorToRoom>
    {
        public FloorToRoomMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FloorID, t.RoomID });

            // Properties
            this.Property(t => t.FloorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RoomID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("FloorToRoom");
            this.Property(t => t.FloorID).HasColumnName("FloorID");
            this.Property(t => t.RoomID).HasColumnName("RoomID");
        }
    }
}
