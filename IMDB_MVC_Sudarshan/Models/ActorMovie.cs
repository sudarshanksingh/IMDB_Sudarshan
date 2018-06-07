using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IMDB_MVC_Sudarshan.Models
{
    //[Table("ActorMovie")]
    public class ActorMovie
    {
        [Column("intActorId", Order = 0)]
        [Key]
        public int ActorId { get; set; }

        [Column("intMovieId", Order = 1)]
        [Key]
        public int MovieId { get; set; }
    }
}