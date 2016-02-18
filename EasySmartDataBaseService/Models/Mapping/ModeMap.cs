using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EasySmartDataBaseService.Models.Mapping
{
    public class ModeMap : EntityTypeConfiguration<Mode>
    {
        public ModeMap()
        {
            // Primary Key
            this.HasKey(t => t.ModeID);

            // Properties
            this.Property(t => t.ModeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ModeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ModeInfo)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Mode");
            this.Property(t => t.ModeID).HasColumnName("ModeID");
            this.Property(t => t.ModeName).HasColumnName("ModeName");
            this.Property(t => t.ModeInfo).HasColumnName("ModeInfo");
        }
    }
}
