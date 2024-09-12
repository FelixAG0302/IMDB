using IMDB.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Infraestructure.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Actor> Actor { get; set; }
        public DbSet<Cast> Cast { get; set; }
        public DbSet<Director> Director { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<MediaActor> MediaActor { get; set; }
        public DbSet<MediaContent> MediaContent { get; set; }
        public DbSet<MediaDirector> MediaDirector { get; set; }
        public DbSet<MediaGender> MediaGender { get; set; }
        public DbSet<Producer> Producer { get; set; }
        public DbSet<Rating> Rating { get; set; }
        public DbSet<Rol> Rol {  get; set; }
        public DbSet<Domain.Entities.Type> Type {  get; set; }

        public ApplicationContext() { }

        public ApplicationContext (DbContextOptions<ApplicationContext> options ) : base (options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MSI; Database=IMDB; TrustServerCertificate=true", m => m.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           //Algo falta aqui
        }

    }
}
