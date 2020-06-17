using System.Collections.Generic;
using MiPrimerApi.Models;

namespace MiPrimerApi.DataProvider
{
    public class AlbumDataProviderSQL : IAlbumDataProvider
    {
        public long Ticks { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public List<Album> AddItem(Album album)
        {
            throw new System.NotImplementedException();
        }

        public List<Album> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Album GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Album> Update(int id, Album album)
        {
            throw new System.NotImplementedException();
        }
    }
}