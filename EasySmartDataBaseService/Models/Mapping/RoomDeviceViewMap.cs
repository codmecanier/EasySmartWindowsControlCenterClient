using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EasySmartDataBaseService.Models.Mapping
{
    public class RoomDeviceViewMap : EntityTypeConfiguration<RoomDeviceView>
    {
        public RoomDeviceViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Expr4, t.Expr1, t.Expr2, t.DeviceName, t.Expr5, t.Expr3, t.Expr6, t.RoomID, t.RoomName });

            // Properties
            this.Property(t => t.Expr4)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Expr1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Expr2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DeviceName)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.Expr5)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Expr3)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RoomID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RoomName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RoomDeviceView");
            this.Property(t => t.Expr4).HasColumnName("Expr4");
            this.Property(t => t.Expr1).HasColumnName("Expr1");
            this.Property(t => t.Expr2).HasColumnName("Expr2");
            this.Property(t => t.DeviceName).HasColumnName("DeviceName");
            this.Property(t => t.Expr5).HasColumnName("Expr5");
            this.Property(t => t.Expr3).HasColumnName("Expr3");
            this.Property(t => t.Expr6).HasColumnName("Expr6");
            this.Property(t => t.RoomID).HasColumnName("RoomID");
            this.Property(t => t.RoomName).HasColumnName("RoomName");
            this.Property(t => t.RoomInfo).HasColumnName("RoomInfo");
        }
    }
}
