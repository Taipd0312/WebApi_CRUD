using Microsoft.EntityFrameworkCore;
using MobileStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileStore.Domain.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            Database.
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<ItemType> Types { get; set; }
        public DbSet<Photo> Photos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.
        }
    }
}
