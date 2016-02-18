using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EasySmartDataBaseService.Models.Mapping
{
    public class RoomViewMap : EntityTypeConfiguration<RoomView>
    {
        public RoomViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RoomName, t.RoomID, t.FloorID, t.FloorName, t.FloorInfo, t.UserID, t.IsAdmin, t.ID });

            // Properties
            this.Property(t => t.RoomName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RoomID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FloorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FloorName)
                .IsRequired();

            this.Property(t => t.FloorInfo)
                .IsRequired();

            this.Property(t => t.UserID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("RoomView");
            this.Property(t => t.RoomName).HasColumnName("RoomName");
            this.Property(t => t.RoomID).HasColumnName("RoomID");
            this.Property(t => t.FloorID).HasColumnName("FloorID");
            this.Property(t => t.FloorName).HasColumnName("FloorName");
            this.Property(t => t.FloorInfo).HasColumnName("FloorInfo");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.IsAdmin).HasColumnName("IsAdmin");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
