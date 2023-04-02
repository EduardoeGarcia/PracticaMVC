using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class usuarios
    {
        [Key]
        [Display(Name = "ID")]
        public int usuario_id { get; set; }

        [Display(Name = "Nombre del usuario")]
        public string? nombre { get; set; }

        [Display(Name = "Documento del Usuario")]
        public string? documento{ get; set; }

        [Display(Name = "Tipo de documento")]
        public char? tipo { get; set; }

        [Display(Name = "Carnet")]
        public string? carnet { get; set; }

        [Display(Name = "Id Carrera")]
        public int? carrera_id { get; set; }

        [Display(Name = "Estado")]
        public char? estado { get; set; }
    }
}
