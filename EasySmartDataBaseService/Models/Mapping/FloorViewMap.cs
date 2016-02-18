using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EasySmartDataBaseService.Models.Mapping
{
    public class FloorViewMap : EntityTypeConfiguration<FloorView>
    {
        public FloorViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FloorID, t.FloorName, t.FloorInfo, t.IsAdmin, t.UserID });

            // Properties
            this.Property(t => t.FloorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FloorName)
                .IsRequired();

            this.Property(t => t.FloorInfo)
                .IsRequired();

            this.Property(t => t.UserID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("FloorView");
            this.Property(t => t.FloorID).HasColumnName("FloorID");
            this.Property(t => t.FloorName).HasColumnName("FloorName");
            this.Property(t => t.FloorInfo).HasColumnName("FloorInfo");
            this.Property(t => t.IsAdmin).HasColumnName("IsAdmin");
            this.Property(t => t.UserID).HasColumnName("UserID");
        }
    }
}
