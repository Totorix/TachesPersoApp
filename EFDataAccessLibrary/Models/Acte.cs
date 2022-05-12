using System.ComponentModel.DataAnnotations;

namespace EFDataAccessLibrary.Models
{
    public class Acte
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string Libelle { get; set; }

    }
}