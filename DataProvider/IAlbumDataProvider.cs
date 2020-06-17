using System.Collections.Generic;
using MiPrimerApi.Models;
namespace MiPrimerApi.DataProvider
{
    public interface IAlbumDataProvider
    {
         List<Album> GetAll();
        Album GetById(int id);
        List<Album> AddItem(Album album);
        List<Album> Update(int id, Album album);
        long Ticks{get;set;}
    }
}