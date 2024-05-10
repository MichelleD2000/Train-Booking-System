using Microsoft.EntityFrameworkCore;
using TrainBooking.Model;

namespace TrainBooking.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<Train> trains { get; set; }
        public DbSet<SeatBooking> seatbookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Train>().Property(p => p.Name).IsRequired();

            modelBuilder.Entity<SeatBooking>().Property(p => p.TrainName).IsRequired();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn = "Data Source=LAPTOP-IGRCM4GB\\SHENARI;Initial Catalog=Shenari57;User ID=sa;Password=sql345;Connect Timeout=30;Encrypt=False;TrustServerCertificate=Yes;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(conn);


        }
    }
}

