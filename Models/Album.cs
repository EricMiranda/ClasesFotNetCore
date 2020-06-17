using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MiPrimerApi.Models
{
    //customizar el nombre del mapeo
    [Table("AlbunesEnStock")]
    public class Album
    {
        //Customizo el nombre de la columna en la DB
        [Column("AlbunesEnStockId")]
        public int Id { get; set; }
        [MaxLength(10,ErrorMessage="Longitud maxima es 10 caracteres")]
        [Required(ErrorMessage="Es requerido")]
        [Column("NombreAlbum")]
        public string Nombre { get; set; }
        public int artistaId { get; set; }
        [ForeignKey("artistaId")]
        public Artista Artista { get; set; }
        [Range(1850,2000)]
        public int AnioPublicacion { get; set; }    
    }
}