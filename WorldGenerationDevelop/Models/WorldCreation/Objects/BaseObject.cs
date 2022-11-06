#nullable enable
using System.ComponentModel.DataAnnotations;

namespace WorldGenerationDevelop.Models.WorldCreation
{
    public class BaseObject
    {
        [Key]
        public int Id { get; set; }

        #pragma warning disable CS8618
        public string Name { get; set; }
        #pragma warning restore CS8618

        public string? Description { get; set; }
    }
}