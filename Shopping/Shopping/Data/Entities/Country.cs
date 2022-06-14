using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Country
    {

        public int Id { get; set; }
        [Display(Name = "País")]
        [Required(ErrorMessage ="el campo {0} es requerido ")]
        [MaxLength(50,ErrorMessage ="el campo {0} debe tener máximo {1} caracteres")]
          public string Name { get; set; }


    }
}
