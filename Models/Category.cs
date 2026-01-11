using System.ComponentModel.DataAnnotations;

namespace MVC_Task.Models
{
    public class Category
    {

        public int Id { get; set; }

        [Required(ErrorMessage ="Name is required.")]
        [MaxLength(15 , ErrorMessage = "Name must be maximum 15 characters.") , MinLength(3 , ErrorMessage = "Name must be at least 3 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }

    }
}
