using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFDataAccessLibrary.Models
{
    public class Tache
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Libelle { get; set; }
        
       [MaxLength(1000)]
        public string Description { get; set; }

        public List<Acte> Actions { get; set; } = new List<Acte>();


    }
}
