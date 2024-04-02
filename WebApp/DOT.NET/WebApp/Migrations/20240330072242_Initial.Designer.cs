using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Migrations;
using WebApp.Shared.Data;
using WebApp.Shared.Entities;

namespace WebApp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240330072242_Initial")]
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Migration logic for applying changes
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Migration logic for reverting changes
        }

        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            // Configure your entity types here
            modelBuilder.Entity<Product>(ConfigureProduct);
        }

        private void ConfigureProduct(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Description).IsRequired();
            builder.Property(p => p.Price).HasColumnType("decimal(18,2)");
        }
    }
}
