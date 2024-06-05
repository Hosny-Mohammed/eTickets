using eTickets.Models;

namespace eTickets.Data
{
    public class DataInitializer
    {
        public static void seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                // Ensure Actors are seeded first
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            Name = "Actor 1",
                            Biography = "This is the Bio of the first actor",
                            ProfilePicURL = "http://dotnethow.net/images/actors/actor-1.jpeg"
                        },
                        new Actor()
                        {
                            Name = "Actor 2",
                            Biography = "This is the Bio of the second actor",
                            ProfilePicURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            Name = "Actor 3",
                            Biography = "This is the Bio of the second actor",
                            ProfilePicURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            Name = "Actor 4",
                            Biography = "This is the Bio of the second actor",
                            ProfilePicURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            Name = "Actor 5",
                            Biography = "This is the Bio of the second actor",
                            ProfilePicURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges(); // Save actors to the database
                }

                // Ensure Producers are seeded second
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            Name = "Producer 1",
                            Biography = "This is the Bio of the first actor",
                            ProfilePicURL = "http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                        new Producer()
                        {
                            Name = "Producer 2",
                            Biography = "This is the Bio of the second actor",
                            ProfilePicURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            Name = "Producer 3",
                            Biography = "This is the Bio of the second actor",
                            ProfilePicURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            Name = "Producer 4",
                            Biography = "This is the Bio of the second actor",
                            ProfilePicURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            Name = "Producer 5",
                            Biography = "This is the Bio of the second actor",
                            ProfilePicURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges(); // Save producers to the database
                }

                // Ensure Cinemas are seeded third
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            LogoImgURL = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            LogoImgURL = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            LogoImgURL = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            LogoImgURL = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            LogoImgURL = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the first cinema"
                        }
                    });
                    context.SaveChanges(); // Save cinemas to the database
                }

                // Ensure Movies are seeded fourth
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Title = "Life",
                            Description = "This is the Life movie description",
                            Price = 39.50,
                            MovieImgURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3, // Ensure this CinemaId exists
                            ProducerId = 3, // Ensure this ProducerId exists
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Title = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            MovieImgURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1, // Ensure this CinemaId exists
                            ProducerId = 1, // Ensure this ProducerId exists
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Title = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            MovieImgURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4, // Ensure this CinemaId exists
                            ProducerId = 4, // Ensure this ProducerId exists
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Title = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            MovieImgURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1, // Ensure this CinemaId exists
                            ProducerId = 2, // Ensure this ProducerId exists
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Title = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            MovieImgURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1, // Ensure this CinemaId exists
                            ProducerId = 3, // Ensure this ProducerId exists
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Title = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            MovieImgURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1, // Ensure this CinemaId exists
                            ProducerId = 5, // Ensure this ProducerId exists
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges(); // Save movies to the database
                }

                // Seed Actor_Movie relationships last
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie() { ActorId = 1, MovieId = 1 }, // Ensure ActorId and MovieId exist
                        new Actor_Movie() { ActorId = 3, MovieId = 1 }, // Ensure ActorId and MovieId exist
                        new Actor_Movie() { ActorId = 1, MovieId = 2 }, // Ensure ActorId and MovieId exist
                        new Actor_Movie() { ActorId = 4, MovieId = 2 }, // Ensure ActorId and MovieId exist
                        new Actor_Movie() { ActorId = 1, MovieId = 3 }, // Ensure ActorId and MovieId exist
                        new Actor_Movie() { ActorId = 2, MovieId = 3 }, // Ensure ActorId and MovieId exist
                        new Actor_Movie() { ActorId = 5, MovieId = 3 }, // Ensure ActorId and MovieId exist
                        new Actor_Movie() { ActorId = 2, MovieId = 4 }, // Ensure ActorId and MovieId exist
                        new Actor_Movie() { ActorId = 3, MovieId = 4 }, // Ensure ActorId and MovieId exist
                        new Actor_Movie() { ActorId = 4, MovieId = 4 }, // Ensure ActorId and MovieId exist
                        new Actor_Movie() { ActorId = 2, MovieId = 5 }, // Ensure ActorId and MovieId exist
                        new Actor_Movie() { ActorId = 3, MovieId = 5 }, // Ensure ActorId and MovieId exist
                        new Actor_Movie() { ActorId = 4, MovieId = 5 }, // Ensure ActorId and MovieId exist
                        new Actor_Movie() { ActorId = 5, MovieId = 5 }, // Ensure ActorId and MovieId exist
                        new Actor_Movie() { ActorId = 3, MovieId = 6 }, // Ensure ActorId and MovieId exist
                        new Actor_Movie() { ActorId = 4, MovieId = 6 }, // Ensure ActorId and MovieId exist
                        new Actor_Movie() { ActorId = 5, MovieId = 6 }  // Ensure ActorId and MovieId exist
                    });
                    context.SaveChanges(); // Save actor-movie relationships to the database
                }
            }
        }
    }
}
