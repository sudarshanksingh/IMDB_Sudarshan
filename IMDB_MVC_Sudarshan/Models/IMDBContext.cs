using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IMDB_MVC_Sudarshan.Models
{
    public class IMDBContext : DbContext
    {
        public IMDBContext() : base("IMDBContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            //Configured the many to many relatioship between Actor and Movie 
            //The link Table for this is ActorMovie which i have created by SQL SCript
            modelBuilder.Entity<Actor>()
                 .HasMany<Movie>(a => a.Movies)
                 .WithMany(m => m.Actors)
                 .Map(am =>
                 {
                     am.MapLeftKey("intActorId");
                     am.MapRightKey("intMovieId");
                     am.ToTable("ActorMovie");
                 });

            //Configured One to many relatioship between Producer and Movie
            modelBuilder.Entity<Movie>()
                .HasRequired<Producer>(m => m.Producer)
                .WithMany(x => x.Movies)
                .HasForeignKey<int>(m => m.ProducerId);

        }
        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Producer> Producers { get; set; }
    }
}