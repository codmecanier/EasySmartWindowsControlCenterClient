using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EasySmartDataBaseService.Models.Mapping
{
    public class RoleToPowerMap : EntityTypeConfiguration<RoleToPower>
    {
        public RoleToPowerMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("RoleToPower");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RoleID).HasColumnName("RoleID");
            this.Property(t => t.PowerID).HasColumnName("PowerID");
        }
    }
}
