using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace 智能平台总控端.Models.Mapping
{
    public class ModeToPerformMap : EntityTypeConfiguration<ModeToPerform>
    {
        public ModeToPerformMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.PerformID, t.ModeID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PerformID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ModeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ModeToPerform");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PerformID).HasColumnName("PerformID");
            this.Property(t => t.ModeID).HasColumnName("ModeID");
        }
    }
}
