using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace 智能平台总控端.Models.Mapping
{
    public class SensorToControlMap : EntityTypeConfiguration<SensorToControl>
    {
        public SensorToControlMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SensorToControl");
            this.Property(t => t.SenseID).HasColumnName("SenseID");
            this.Property(t => t.ControlID).HasColumnName("ControlID");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
