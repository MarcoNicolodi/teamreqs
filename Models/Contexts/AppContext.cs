using Microsoft.EntityFrameworkCore;
using teamREQUIREMENTS.Persistencia.Models;

namespace teamREQUIREMENTS 
{
    public class AppContext : DbContext
    {
        public DbSet<RequisitoFuncional> RequisitosFuncionais { get; set; }
        public DbSet<RegraDeNegocio> RegraDeNegocio { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<RequisitosFuncionaisRegrasDeNegocio> RequisitosFuncionaisRegrasDeNegocio { get; set; }

        public AppContext(DbContextOptions<AppContext> options) : base (options){}

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {            
            
        //     //optionsBuilder.UseMySql(@"Server=localhost;database=teamREQUIREMENTS;uid=root;pwd=passwd;");
        //     //optionsBuilder.UseSqlServer(Configuration.GetConnectionString());
        //     optionsBuilder.UseSqlServer(@"Server=localhost;Database=teamreqs;User Id=sa;Password=LLaagg__157;");
        // }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RequisitoFuncional>()
                .ToTable("requisitosfuncionais");
                
            modelBuilder.Entity<RegraDeNegocio>()
                .ToTable("regrasdenegocio");
          
            modelBuilder.Entity<Modulo>()
                .ToTable("modulos");

            modelBuilder.Entity<RequisitosFuncionaisRegrasDeNegocio>()
                .ToTable("requisitosfuncionais_regrasdenegocio")
                .HasKey(e => new  { e.RegraDeNegocioId, e.RequisitoFuncionalId} );
        }
    }



}