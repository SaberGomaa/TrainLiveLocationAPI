using Entites;
using Entites.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
        : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrainInStationTime>()
            .HasKey(ts => new { ts.TrainId, ts.StationId });
        }
        public DbSet<Admin> admins { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<Payment> payments { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<Report> reports { get; set; }
        public DbSet<Station> stations { get; set; }
        public DbSet<Ticket> tickets { get; set; }
        public DbSet<Train> trains { get; set; }
        public DbSet<LiveLocation> liveLocations { get; set; }
        public DbSet<News> news { get; set; }
        public DbSet<Railway> railway { get; set; }
        public DbSet<TrainInStationTime> trainInStationTime { get; set; }

    }
}
