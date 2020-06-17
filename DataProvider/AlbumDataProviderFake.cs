using MiPrimerApi.Models;
using System.Collections.Generic;
using System.Linq;
using System;
namespace MiPrimerApi.DataProvider
{
    public class AlbumDataProviderFake : IAlbumDataProvider
    {
        public AlbumDataProviderFake()
        {
            Ticks = DateTime.Now.Ticks;
        }
        private List<Album> albums = new List<Album>(){
            // new Album(){
            //     Artista ="Arjona",
            //     Nombre="2to Piso",
            //     AnioPublicacion = 2016,
            //     Id = 1
            // },
            // new Album(){
            //     Artista ="Andres Calamaro",
            //     Nombre="El Salmon",
            //     AnioPublicacion = 2006,
            //     Id = 2
            // }
        };

        public long Ticks { get ; set ;}

        public List<Album> GetAll(){
            return albums;
        }
        public Album GetById(int id){
            return albums.FirstOrDefault(x=>x.Id == id);
        }
        public List<Album> AddItem(Album album){
            albums.Add(album);
            return albums;
        }
        public List<Album> Update(int id, Album album){
            Album a = albums.Where(x=>x.Id == id).FirstOrDefault();
            a.AnioPublicacion = album.AnioPublicacion;
            a.Artista = album.Artista;
            a.Nombre = album.Nombre;
            return albums;
        }

        public List<Album> GetByArtista(string nombre){
            return albums;
        }

        // public List<Album> GetAlbumByArtista(string artista)
        // {
        //     return albums.Where(x=>x.Artista == artista).ToList();
        // }
    }
}