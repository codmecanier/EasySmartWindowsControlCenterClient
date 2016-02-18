using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace 智能平台总控端.Models.Mapping
{
    public class PerformMap : EntityTypeConfiguration<Perform>
    {
        public PerformMap()
        {
            // Primary Key
            this.HasKey(t => t.PerformID);

            // Properties
            this.Property(t => t.PerformName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PerformUnit)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Perform");
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
            this.Property(t => t.Display).HasColumnName("Display");
        }
    }
}
