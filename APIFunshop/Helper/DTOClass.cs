using APIFunshop.DataBaseFolder;
using APIFunshop.DTO;

namespace APIFunshop.Helper
{
    public static class DTOClass
    {
        public static DTOProduct ProductToDTO (Product Product)
        {
            return new DTOProduct()
            {
                Id = Product.Id,
                Title = Product.Title,
                Description = Product.Description,
                Price = Product.Price,
                IdCategory = Product.IdCategory,
            };
               
        }

        public static Product DTOProductToProduct (DTOProduct dtoProduct) 
        
        {
           return new Product()
            {
                Id = dtoProduct.Id,
                Title = dtoProduct.Title,
                Description = dtoProduct.Description,
                Price = dtoProduct.Price,
                IdCategory = dtoProduct.IdCategory,
            };
        }

        public static Category DTOCategoryToCategory (DTOCategory Category) 
        {
            return new Category()
            {
                Id = Category.Id,
                Title = Category.Title,
            };
        }
        public static DTOCategory CategoryTODTOCategory(Category Category)
        {
            return new DTOCategory()
            {
                Id = Category.Id,
                Title = Category.Title,
            };
        }

    }
}
