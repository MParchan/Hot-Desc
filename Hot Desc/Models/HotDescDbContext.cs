using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Hot_Desc.Models
{
    public class HotDescDbContext : DbContext
    {
        public HotDescDbContext(DbContextOptions<HotDescDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentForWorkplace> EquipmentsForWorkplaces { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Workplace> Workplaces { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Workplace>().HasMany(w => w.EquipmentForWorkplaces).WithOne(w => w.Workplace);
        }
    }
}
