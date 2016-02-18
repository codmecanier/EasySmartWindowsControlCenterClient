using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace 智能平台总控端.Models.Mapping
{
    public class UserToModeMap : EntityTypeConfiguration<UserToMode>
    {
        public UserToModeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("UserToMode");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.ModeID).HasColumnName("ModeID");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
