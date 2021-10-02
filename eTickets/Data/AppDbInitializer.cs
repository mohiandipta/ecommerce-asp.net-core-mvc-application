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

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Tenet",
                            Logo = "https://ep1.pinkbike.org/p4pb18097104/p4pb18097104.jpg",
                            Description = "When a few objects that can be manipulated and used as weapons in the future fall into the wrong hands, a CIA operative, known as the Protagonist, must save the world..."
                        },
                        new Cinema()
                        {
                            Name = "Inception",
                            Logo = "https://cdn.dribbble.com/users/643255/screenshots/4198593/untitled-3_still_2x.gif?compress=1&resize=400x300",
                            Description = "Cobb steals information from his targets by entering their dreams. Saito offers to wipe clean Cobb's criminal history as payment for performing an inception on his sick competitor's son..."
                        },
                        new Cinema()
                        {
                            Name = "Interstellar",
                            Logo = "https://c4.wallpaperflare.com/wallpaper/183/625/194/space-the-film-art-poster-wallpaper-preview.jpg",
                            Description = "When Earth becomes uninhabitable in the future, a farmer and ex-NASA pilot, Joseph Cooper, is tasked to pilot a spacecraft, along with a team of researchers, to find a new planet for humans..."
                        },
                        new Cinema()
                        {
                            Name = "Memento",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/d/db/Memento_logo_640.png",
                            Description = "Leonard Shelby, an insurance investigator, suffers from anterograde amnesia and uses notes and tattoos to hunt for the man he thinks killed his wife, which is the last thing he remembers..."
                        }
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {

                }
                //Producers
                if (!context.Producers.Any())
                {

                }
                //Movies
                if (!context.Movies.Any())
                {

                }
                //Actor_Movies
                if (!context.Actor_Movies.Any())
                {

                }
            }
        }
    }
}
