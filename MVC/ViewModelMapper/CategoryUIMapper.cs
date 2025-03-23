using MVC.Models;
using MVC.ViewModels.Category;
namespace MVC.ViewModelMapper
{
    public static class CategoryUIMapper
    {
        public static Category ToCategoryFromCreateOrUpdateCategoryViewModel(this CreateOrUpdateCategoryViewModel categoryVM)
        {
            byte[]? bytepic; 

            using (var memoryStream = new MemoryStream())
            {
                categoryVM.Picture.CopyTo(memoryStream);
                bytepic = memoryStream.ToArray();

            }
            return new Category
            {
                CategoryId = categoryVM.CategoryId,
                CategoryName = categoryVM.CategoryName,
                Description = categoryVM.Description,
                Picture = bytepic
            };
        }
    }
}
