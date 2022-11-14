using System.Collections.Generic;
using WorldGenerationDevelop.Models.WorldCreation;

namespace WorldGenerationDevelop.Interfaces.WorldCreation
{
    public interface ISuccessorsCollection
    {
        ICollection<Asteroid> Asteroids { get; set; }
        ICollection<Station> Stations { get; set; }
        ICollection<Fleet> Fleets { get; set; }
    }
}