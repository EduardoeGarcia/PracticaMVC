using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class carreras
    {
        [Key]

        [Display(Name = "ID")]
        public int carrera_id { get; set; }

        [Display(Name = "Nombre de la carrera")]
        public string? nombre_carrera { get; set; }

        [Display(Name = "ID de la facultad")]
        public int? facultad_id { get; set; }

        [Display(Name = "Estado")]
        public char? estado { get; set; }

    }
}
