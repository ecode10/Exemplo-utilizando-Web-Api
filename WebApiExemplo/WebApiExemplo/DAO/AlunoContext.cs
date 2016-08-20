using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WebApiExemplo.Models;

namespace WebApiExemplo.DAO
{
    public class AlunoContext : DbContext
    {
        public DbSet<Disciplina> Disciplina { get; set; }

        public AlunoContext() : base("name=AlunoContext")
        {
            Database.SetInitializer<AlunoContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }
    }
}