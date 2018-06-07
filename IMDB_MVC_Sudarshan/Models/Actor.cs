using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IMDB_MVC_Sudarshan.Models
{
    [Table("Actor")]
    public class Actor
    {
        [Column("intId")]
        public int ActorId { get; set; }

        [Column("strName")]
        public String Name { get; set; }

        [Column("strSex")]
        public  String Sex { get; set; }

        [Column("datDOB")]
        public DateTime DOB { get; set; }

        [Column("strBio")]
        public String Bio { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}