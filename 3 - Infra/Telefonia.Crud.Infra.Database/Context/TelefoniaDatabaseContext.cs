using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Telefonia.Crud.Infra.Database.Model;

namespace Telefonia.Crud.Infra.Database.Context
{
    public class TelefoniaDatabaseContext : DbContext
    {
        public TelefoniaDatabaseContext(DbContextOptions<TelefoniaDatabaseContext> options) : base(options)
        {
        }

        public DbSet<Ddd> Ddds { get; set; }
        public DbSet<Operadora> Operadoras { get; set; }
        public DbSet<Plano> Planos { get; set; }
        public DbSet<TipoPlano> TiposPlano { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
