﻿using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace eTickets.Data
{
    public class AppDBContext: DbContext
    {

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
              
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId,
              

            });
            

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actor_Movies).HasForeignKey(m => m.MovieId);

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actor_Movies).HasForeignKey(m => m.ActorId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Producer).WithMany(am => am.Actor_Movies).HasForeignKey(m => m.ProducerId);
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Cinemas> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<User> Users { get; set; }
    }
}