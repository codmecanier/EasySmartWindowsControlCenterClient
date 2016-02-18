using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace 智能平台总控端.Models.Mapping
{
    public class RemoteButtonMap : EntityTypeConfiguration<RemoteButton>
    {
        public RemoteButtonMap()
        {
            // Primary Key
            this.HasKey(t => t.ButtonID);

            // Properties
            this.Property(t => t.ButtonName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ButtonImage)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("RemoteButton");
            this.Property(t => t.ButtonID).HasColumnName("ButtonID");
            this.Property(t => t.ButtonName).HasColumnName("ButtonName");
            this.Property(t => t.ButtonInfo).HasColumnName("ButtonInfo");
            this.Property(t => t.ButtonImage).HasColumnName("ButtonImage");
        }
    }
}
