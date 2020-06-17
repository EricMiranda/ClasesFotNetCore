using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MiPrimerApi.Models;

namespace MiPrimerApi.DataProvider
{
    ///Instalar Paquetes de EF
    ///dotnet add package Microsoft.EntityFrameworkCore
    ///dotnet add package Microsoft.EntityFrameworkCore.Design
    ///dotnet add package Microsoft.EntityFrameworkCore.SqlServer
    
    /// Info de la conexion a la DB por EF
    ///dotnet-ef dbcontext info

    //crear migracion
    //dotnet-ef migrations add inicial
    //Aplicas a la DB
    //dotnet-ef database update
    // te genera un script de todo
    //dotnet-ef migrations script
    public class MusicStoreContext : DbContext
    {
        public MusicStoreContext(DbContextOptions<MusicStoreContext> options):base(options){}
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder ){
        //     optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS; User Id=emiranda; Password=emiranda; Initial Catalog=MusicStore");
        //     //usuario de windows= Integrated Security = True
        // }

        //Para mapear aca y no en el modelo
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                // modelBuilder.Entity<Album>().HasKey(x=>x.Id);
                // //Para ignorar
                // modelBuilder.Entity<Album>().Ignore(x=>x.AnioPublicacion);
                modelBuilder.Entity<Artista>().HasData(new List<Artista>(){
                    new Artista(){Id=1
                    ,AnioNacimiento=1950,Nacionalidad="Argentina"}
                });
                modelBuilder.Entity<Album>().HasData(new List<Album>(){
                    new Album(){
                        Id=1,
                        AnioPublicacion = 1990,
                        Nombre="El Salmon",
                        artistaId = 1}
                });
        }
        public DbSet<Album> Albunes {get; set;}
        public DbSet<Artista> Artistas {get; set;}
    }
}