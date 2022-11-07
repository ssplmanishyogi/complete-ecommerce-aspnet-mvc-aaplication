using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinemas
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "https://www.shutterstock.com/shutterstock/photos/1906706707/display_1500/stock-vector-movie-theater-flyer-with-film-strip-and-popcorn-in-striped-paper-boxes-vector-realistic-1906706707.jpg",
                            Description = "This is the Description of First Cinema"
                        }
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the bio of First Actor",
                            ProfilePictureUrl = "https://www.mrdustbin.com/en/wp-content/uploads/2021/05/Rajinikanth-768x814.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the bio of First Producer",
                            ProfilePictureUrl = "https://media.istockphoto.com/photos/prominent-successful-senior-director-is-sitting-at-his-chair-and-to-picture-id1265157465?b=1&k=20&m=1265157465&s=170667a&w=0&h=QmIdcKuT3WRzPpD-LYqUOOYbNohImtEHlul3CgcR3v4="
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Movie 1",
                            Description = "This is the First movie",
                            Price = 110,
                            ImageUrl = "https://panandslam.files.wordpress.com/2020/04/161ff51f50d7424a8273fa84e464fbf1.jpg?w=639&h=479",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Horror
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        }
                    });
                    context.SaveChanges();
                }
                //Cinemas & Movies 
                if (!context.Cinemas_Movies.Any())
                {
                    context.Cinemas_Movies.AddRange(new List<Cinema_Movie>()
                    {
                        new Cinema_Movie()
                        {
                            CinemaId = 1,
                            MovieId = 1
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
