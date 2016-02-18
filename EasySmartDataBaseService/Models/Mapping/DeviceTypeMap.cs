using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EasySmartDataBaseService.Models.Mapping
{
    public class DeviceTypeMap : EntityTypeConfiguration<DeviceType>
    {
        public DeviceTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.DeviceTypeID);

            // Properties
            this.Property(t => t.DeviceTypeName)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("DeviceType");
            this.Property(t => t.DeviceTypeID).HasColumnName("DeviceTypeID");
            this.Property(t => t.DeviceTypeName).HasColumnName("DeviceTypeName");
            this.Property(t => t.IconPath).HasColumnName("IconPath");
        }
    }
}
