using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.ViewModel
{
    public class EmployeeViewModel

        
    {
        [Required(ErrorMessage = "Campo é obrigatorio")]
        public int  Id { get; set; }

        [Required(ErrorMessage = "O campo 'Name' é obrigatório.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo 'Age' é obrigatório.")]
        [Range(1, 120, ErrorMessage = "A idade deve estar entre 1 e 120.")]
        public int Age { get; set; }
    }
}
