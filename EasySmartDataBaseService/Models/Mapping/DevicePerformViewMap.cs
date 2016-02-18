using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EasySmartDataBaseService.Models.Mapping
{
    public class DevicePerformViewMap : EntityTypeConfiguration<DevicePerformView>
    {
        public DevicePerformViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PerformID, t.PerformName, t.PerformAddress, t.Performvalue, t.PerformBase, t.PerformCopmcition, t.PerformInPut, t.PerformUnit, t.PerformMaxim, t.PerformMinum, t.DeviceID, t.Visible, t.ArrowRead, t.ArrowUpdate, t.IsAdmin, t.UserID, t.DeviceName, t.DeviceAddress });

            // Properties
            this.Property(t => t.PerformID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PerformName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PerformAddress)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Performvalue)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PerformBase)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PerformCopmcition)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PerformInPut)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PerformUnit)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PerformMaxim)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PerformMinum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DeviceID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DeviceName)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.DeviceAddress)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DevicePerformView");
            this.Property(t => t.PerformID).HasColumnName("PerformID");
            this.Property(t => t.PerformName).HasColumnName("PerformName");
            this.Property(t => t.PerformAddress).HasColumnName("PerformAddress");
            this.Property(t => t.PerformInfo).HasColumnName("PerformInfo");
            this.Property(t => t.Performvalue).HasColumnName("Performvalue");
            this.Property(t => t.PerformBase).HasColumnName("PerformBase");
            this.Property(t => t.PerformCopmcition).HasColumnName("PerformCopmcition");
            this.Property(t => t.PerformInPut).HasColumnName("PerformInPut");
            this.Property(t => t.PerformUnit).HasColumnName("PerformUnit");
            this.Property(t => t.PerformMaxim).HasColumnName("PerformMaxim");
            this.Property(t => t.PerformMinum).HasColumnName("PerformMinum");
            this.Property(t => t.DeviceID).HasColumnName("DeviceID");
            this.Property(t => t.Visible).HasColumnName("Visible");
            this.Property(t => t.ArrowRead).HasColumnName("ArrowRead");
            this.Property(t => t.ArrowUpdate).HasColumnName("ArrowUpdate");
            this.Property(t => t.IsAdmin).HasColumnName("IsAdmin");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.DeviceName).HasColumnName("DeviceName");
            this.Property(t => t.DeviceAddress).HasColumnName("DeviceAddress");
        }
    }
}
