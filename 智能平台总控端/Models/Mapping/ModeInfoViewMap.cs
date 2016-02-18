using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace 智能平台总控端.Models.Mapping
{
    public class ModeInfoViewMap : EntityTypeConfiguration<ModeInfoView>
    {
        public ModeInfoViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.UserID, t.ModeID, t.Expr1, t.ModeName, t.ModeInfo, t.UserName, t.PerformID });

            // Properties
            this.Property(t => t.UserID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ModeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Expr1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ModeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ModeInfo)
                .IsRequired();

            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PerformID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ModeInfoView");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.ModeID).HasColumnName("ModeID");
            this.Property(t => t.Expr1).HasColumnName("Expr1");
            this.Property(t => t.ModeName).HasColumnName("ModeName");
            this.Property(t => t.ModeInfo).HasColumnName("ModeInfo");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.PerformID).HasColumnName("PerformID");
        }
    }
}
