using System.ComponentModel.DataAnnotations;

namespace VillaMagic_API.Dto
{
    public class VillaDto
    {
        public int Id { get; set; }


        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }

    }
}
