using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace 智能平台总控端.Models.Mapping
{
    public class RoomToRemoteMap : EntityTypeConfiguration<RoomToRemote>
    {
        public RoomToRemoteMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RoomID, t.RemoteID });

            // Properties
            this.Property(t => t.RoomID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RemoteID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("RoomToRemote");
            this.Property(t => t.RoomID).HasColumnName("RoomID");
            this.Property(t => t.RemoteID).HasColumnName("RemoteID");
        }
    }
}
