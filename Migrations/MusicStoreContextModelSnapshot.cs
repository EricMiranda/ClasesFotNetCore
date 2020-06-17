﻿// <auto-generated />
using MiPrimerApi.DataProvider;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MiPrimerApi.Migrations
{
    [DbContext(typeof(MusicStoreContext))]
    partial class MusicStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MiPrimerApi.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AlbunesEnStockId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnioPublicacion")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("NombreAlbum")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("artistaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("artistaId");

                    b.ToTable("AlbunesEnStock");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AnioPublicacion = 1990,
                            Nombre = "El Salmon",
                            artistaId = 1
                        });
                });

            modelBuilder.Entity("MiPrimerApi.Models.Artista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnioNacimiento")
                        .HasColumnType("int");

                    b.Property<string>("Nacionalidad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artistas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AnioNacimiento = 1950,
                            Nacionalidad = "Argentina"
                        });
                });

            modelBuilder.Entity("MiPrimerApi.Models.Album", b =>
                {
                    b.HasOne("MiPrimerApi.Models.Artista", "Artista")
                        .WithMany()
                        .HasForeignKey("artistaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
