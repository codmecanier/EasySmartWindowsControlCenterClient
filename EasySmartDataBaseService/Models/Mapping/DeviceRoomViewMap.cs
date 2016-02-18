using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EasySmartDataBaseService.Models.Mapping
{
    public class DeviceRoomViewMap : EntityTypeConfiguration<DeviceRoomView>
    {
        public DeviceRoomViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.DeviceID, t.Expr1, t.Expr2, t.DeviceName, t.RoomName, t.RoomID, t.UserID, t.Expr3, t.IsAdmin, t.FloorID, t.FloorName, t.FloorInfo });

            // Properties
            this.Property(t => t.DeviceID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Expr1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Expr2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DeviceName)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.RoomName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RoomID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Expr3)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FloorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FloorName)
                .IsRequired();

            this.Property(t => t.FloorInfo)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("DeviceRoomView");
            this.Property(t => t.DeviceID).HasColumnName("DeviceID");
            this.Property(t => t.Expr1).HasColumnName("Expr1");
            this.Property(t => t.Expr2).HasColumnName("Expr2");
            this.Property(t => t.DeviceName).HasColumnName("DeviceName");
            this.Property(t => t.RoomName).HasColumnName("RoomName");
            this.Property(t => t.RoomID).HasColumnName("RoomID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.Expr3).HasColumnName("Expr3");
            this.Property(t => t.IsAdmin).HasColumnName("IsAdmin");
            this.Property(t => t.FloorID).HasColumnName("FloorID");
            this.Property(t => t.FloorName).HasColumnName("FloorName");
            this.Property(t => t.FloorInfo).HasColumnName("FloorInfo");
        }
    }
}
