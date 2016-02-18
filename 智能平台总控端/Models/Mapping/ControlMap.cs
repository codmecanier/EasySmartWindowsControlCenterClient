using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace 智能平台总控端.Models.Mapping
{
    public class ControlMap : EntityTypeConfiguration<Control>
    {
        public ControlMap()
        {
            // Primary Key
            this.HasKey(t => t.ControlID);

            // Properties
            this.Property(t => t.ControlID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Text1)
                .HasMaxLength(50);

            this.Property(t => t.Text2)
                .HasMaxLength(50);

            this.Property(t => t.Text3)
                .HasMaxLength(50);

            this.Property(t => t.Text4)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Controls");
            this.Property(t => t.ControlID).HasColumnName("ControlID");
            this.Property(t => t.ControlName).HasColumnName("ControlName");
            this.Property(t => t.Value1).HasColumnName("Value1");
            this.Property(t => t.Value2).HasColumnName("Value2");
            this.Property(t => t.Value3).HasColumnName("Value3");
            this.Property(t => t.Value4).HasColumnName("Value4");
            this.Property(t => t.Value5).HasColumnName("Value5");
            this.Property(t => t.Decimal1).HasColumnName("Decimal1");
            this.Property(t => t.Decimal2).HasColumnName("Decimal2");
            this.Property(t => t.Text1).HasColumnName("Text1");
            this.Property(t => t.Text2).HasColumnName("Text2");
            this.Property(t => t.Text3).HasColumnName("Text3");
            this.Property(t => t.Text4).HasColumnName("Text4");
        }
    }
}
