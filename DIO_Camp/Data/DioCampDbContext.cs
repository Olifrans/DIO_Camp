using DIO_Camp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_Camp.Data
{
    public class DioCampDbContext : DbContext
    {
        public DbSet<Categoria> Categoria { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString:
                @"Server=DESKTOP-OEF3FS8;Database=DIOCampData;Trusted_Connection=True;MultipleActiveResultSets=True");
        }
    }
}