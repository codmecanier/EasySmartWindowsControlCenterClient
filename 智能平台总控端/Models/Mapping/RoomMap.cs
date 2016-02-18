using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace 智能平台总控端.Models.Mapping
{
    public class RoomMap : EntityTypeConfiguration<Room>
    {
        public RoomMap()
        {
            // Primary Key
            this.HasKey(t => t.RoomID);

            // Properties
            this.Property(t => t.RoomName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Room");
            this.Property(t => t.RoomID).HasColumnName("RoomID");
            this.Property(t => t.RoomName).HasColumnName("RoomName");
            this.Property(t => t.RoomInfo).HasColumnName("RoomInfo");
        }
    }
}
