using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUD_MVC.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Carrera")]
        public string Name { get; set; }
        [DisplayName("Semestre")]
        [Range(1, 10, ErrorMessage = "fuera del rango")]
        public int Price { get; set; }
    }
}
