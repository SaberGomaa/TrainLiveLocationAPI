﻿using Entites;
using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
            modelBuilder.ApplyConfiguration(new TrainConfigration());
            modelBuilder.ApplyConfiguration(new StationConfigration());
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

    }
}
