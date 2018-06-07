using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IMDB_MVC_Sudarshan.Models
{
    public class MovieViewModel
    {

        
        public int MovieId { get; set; }

        public String Name { get; set; }

        [Display(Name = "Year Of Release")]
        public Int16 Yor { get; set; }
        public String Poster { get; set; }
        public string[] SelectedActorIds { get; set; } //new
        public IEnumerable<SelectListItem> Items { get; set; } //new

        //public virtual ICollection<Actor> Actors { get; set; }

        public int ProducerId { get; set; }
        public virtual ICollection<Producer> Producers { get; set; } //To list down all the producer in dropdownlist
    }
}