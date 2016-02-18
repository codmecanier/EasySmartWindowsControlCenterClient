using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace 智能平台总控端.Models.Mapping
{
    public class PerformToControlMap : EntityTypeConfiguration<PerformToControl>
    {
        public PerformToControlMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PerformID, t.ControlID, t.ID });

            // Properties
            this.Property(t => t.PerformID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ControlID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("PerformToControl");
            this.Property(t => t.PerformID).HasColumnName("PerformID");
            this.Property(t => t.ControlID).HasColumnName("ControlID");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
