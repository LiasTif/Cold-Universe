using System.ComponentModel.DataAnnotations;

namespace WorldGenerationDevelop.Interfaces.WorldCreation
{
    public interface IBase
    {
        [Key]
        [Required]
        int Id { get; set; }

        string?Name { get; set; }

        string Description { get; set; }
    }
}