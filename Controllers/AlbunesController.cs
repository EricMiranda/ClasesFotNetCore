using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MiPrimerApi.Models;
using System.Linq;
using MiPrimerApi.DataProvider;

namespace MiPrimerApi.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class AlbunesController:ControllerBase
    {
        private IAlbumDataProvider provider;
        private MusicStoreContext context ;//= new MusicStoreContext();

        public AlbunesController(IAlbumDataProvider provider,MusicStoreContext context)
        {
            this.provider = provider;
            this.context = context;
        }

        [HttpGet("ticks")]
        public ActionResult<long> Ticks(){
            return Ok(provider.Ticks);
        }

        [HttpGet]
        public ActionResult<List<Album>> GetAlbums(){
            return context.Albunes.ToList();
            //return Ok(provider.GetAll());
        }

        [HttpGet("GetAlbum/{id:int}")]
        public ActionResult<Album> GetAlbum(int id){
            if(id < 3)
                return Ok(provider.GetById(id));
            return NotFound();
        }

        [HttpPost]
        public ActionResult<List<Album>> AddItem(Album album){
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            return Ok(provider.AddItem(album));
        }

        [HttpPut("{id:int}")]
        public ActionResult<List<Album>> UpdateItem(int id,[FromBody]Album album){
            return Ok(provider.Update(id,album));
        }

        //
    }
}