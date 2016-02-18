using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace 智能平台总控端.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.UserID);

            // Properties
            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PassWord)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Emial)
                .HasMaxLength(100);

            this.Property(t => t.Mobile)
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("User");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.PassWord).HasColumnName("PassWord");
            this.Property(t => t.Emial).HasColumnName("Emial");
            this.Property(t => t.SignDate).HasColumnName("SignDate");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.HeadIcon).HasColumnName("HeadIcon");
        }
    }
}
