using System.ComponentModel.DataAnnotations;

namespace MVC.ViewModels.Category
{
    public class CreateOrUpdateCategoryViewModel
    {
        [Required]
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; }

        public string? Description { get; set; }

        public IFormFile Picture { get; set; }

    }
}
