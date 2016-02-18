using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EasySmartDataBaseService.Models.Mapping
{
    public class DeviceInformationViewMap : EntityTypeConfiguration<DeviceInformationView>
    {
        public DeviceInformationViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.DeviceName, t.DeviceAddress, t.DeviceInfo, t.RoomName, t.FloorName, t.FloorInfo, t.FloorID, t.RoomID, t.DeviceID, t.UserID, t.IsAdmin });

            // Properties
            this.Property(t => t.DeviceName)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.DeviceAddress)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DeviceImage)
                .HasMaxLength(250);

            this.Property(t => t.DeviceInfo)
                .IsRequired();

            this.Property(t => t.RoomName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FloorName)
                .IsRequired();

            this.Property(t => t.FloorInfo)
                .IsRequired();

            this.Property(t => t.FloorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RoomID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DeviceID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DeviceInformationView");
            this.Property(t => t.DeviceName).HasColumnName("DeviceName");
            this.Property(t => t.DeviceAddress).HasColumnName("DeviceAddress");
            this.Property(t => t.DeviceImage).HasColumnName("DeviceImage");
            this.Property(t => t.DeviceInfo).HasColumnName("DeviceInfo");
            this.Property(t => t.RoomName).HasColumnName("RoomName");
            this.Property(t => t.RoomInfo).HasColumnName("RoomInfo");
            this.Property(t => t.FloorName).HasColumnName("FloorName");
            this.Property(t => t.FloorInfo).HasColumnName("FloorInfo");
            this.Property(t => t.FloorID).HasColumnName("FloorID");
            this.Property(t => t.RoomID).HasColumnName("RoomID");
            this.Property(t => t.DeviceID).HasColumnName("DeviceID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.IsAdmin).HasColumnName("IsAdmin");
        }
    }
}
