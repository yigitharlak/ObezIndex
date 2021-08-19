using Microsoft.EntityFrameworkCore;
using ObezIndex1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObezIndex1.Data
{
    public class ObezIndexDbContext : DbContext
    {
        public ObezIndexDbContext(DbContextOptions<ObezIndexDbContext> options) : base(options)
        {

        }

        public DbSet<Doktor> Doktor { get; set; }

        public DbSet<Hasta> Hasta { get; set; }

        public DbSet<Hastalik> Hastalik { get; set; }

        public DbSet<Tani> Tani { get; set; }

        public DbSet<Tedavi> Tedavi { get; set; }

        public DbSet<Uzmanlik> Uzmanlik { get; set; }

        public DbSet<HastaHas> HastaHas { get; set; }

        public DbSet<Consults> Consults { get; set; }

        public DbSet<UzmanlikHas> UzmanlikHas { get; set; }

        public DbSet<TaniKoyma> TaniKoyma { get; set; }

        public DbSet<TedaviUyg> TedaviUyg { get; set; }
    }
}
