using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IMDB_MVC_Sudarshan.Models
{
    [Table("Movie")]
    public class Movie
    {

        [Column("intId")]
        public int MovieId { get; set; }

        [Column("strName")]
        public String Name { get; set; }

        [Column("sintYor")]
        [Display(Name="Year Of Release")]
        public Int16 Yor  { get; set; }

        [Column("strPoster")]
        public String Poster { get; set; }


        //public string[] SelectedItemIds { get; set; } //new
        //public IEnumerable<SelectListItem> Items { get; set; } //new

        public virtual ICollection<Actor> Actors { get; set; }

        public int ProducerId { get; set; }
        public Producer Producer { get; set; }

    }
}