using Humanizer;
using MVC.DTOs.Category;
using MVC.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Buffers.Text;

namespace MVC.DtoMapper
{
    public static class CategoryDataMapper
    {
        public static CategoryDto ToCategoryDtoFromCategory (this Category category)
        {
            string base64Image = "";
            string imageSrc = ""; 
            if (category.Picture != null && category.Picture.Length > 78)
            {
                var actualImage = category.Picture.ToArray(); //ToArray is used to ensure copy value rather than copy reference

                if (category.Picture[0] == 0x15 && category.Picture[1] == 0x1C)
                {
                    actualImage = new byte[category.Picture.Length - 78];
                    //Northwind was created using MS Access and it stored image data as OLE fields. Now OLE fields may heve varying header lengths based 
                    //on the context. In the context of Northwind, the header length is 78. So we skip 78 bytes. Also, in case of Northwind, the way to
                    //detect OLE headers is that OLE headers start with 0x15 and 0x1C
                    Array.Copy(category.Picture, 78, actualImage, 0, actualImage.Length);
                }


                base64Image = Convert.ToBase64String(actualImage);
                imageSrc = $"data:image/png;base64,{base64Image}";
            }
            return new CategoryDto
            {
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName,
                Description = category.Description,
                Picture = base64Image,
            };
        }
    }
}
