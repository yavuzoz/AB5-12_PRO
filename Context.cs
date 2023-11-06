using Microsoft.EntityFrameworkCore;

namespace AB5_12_PRO
{
	class Context : DbContext
	{
		public DbSet<Kunde> Kunden { get; set; }
		public DbSet<Lieferkosten> Lieferkosten { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-VQGH9P1;Database=Aufgabe12Pro;Trusted_Connection=True;");
			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Kunde>().HasKey(k => k.ID);
			modelBuilder.Entity<Lieferkosten>().HasKey(l => l.ID);

			modelBuilder.Entity<Kunde>().HasOne(k => k.Lieferkosten)
				.WithMany(l => l.Kunden)
				.HasForeignKey(k => k.LieferkostenID)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
