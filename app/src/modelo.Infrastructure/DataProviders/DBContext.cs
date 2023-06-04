﻿using Microsoft.EntityFrameworkCore;
using modelo.Domain.Entities;
using modelo.Infrastructure.DataProviders.EntityConfigurations;
using modelo.Infrastructure.Seeds;

namespace modelo.Infrastructure.DataProviders
{
    public class DBContext : DbContext
    {
        public DbSet<WeatherForecast> WeatherForecast { get; set; }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Produto> Produto { get; set; }

        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new WeatherForecastEntityConfiguration());

            modelBuilder.ApplyConfiguration(new ClienteEntityConfiguration());

            modelBuilder.ApplyConfiguration(new CategoriaEntityConfiguration());

            modelBuilder.ApplyConfiguration(new ProdutoEntityConfiguration());

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DbContext).Assembly);

            ClienteSeed.Seed(modelBuilder);
            CategoriaSeed.Seed(modelBuilder);
            ProdutoSeed.Seed(modelBuilder);
        }
    }


}
