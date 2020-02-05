using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        public int GenreId { get; set; }
        public GenreDto Genre { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Range(1, 20)]
        public byte NumberInStock { get; set; }
    }
}