using APIFunshop.DataBaseFolder;
using APIFunshop.DTO;
using APIFunshop.Helper;

namespace APIFunshop.Logic
{
    public static class ProductLogic
    {
        public static List<DTOProduct> GetAllProducts()
        {
            List<Product> product = DB.GetDB().Products.ToList();

            List<DTOProduct> dto = new List<DTOProduct>();  

            foreach (var item in product)
            {
                dto.Add(DTOClass.ProductToDTO(item));
            }
            return dto;
        }

        public static DTOProduct GetProduct(int id) 
        { 

            return DTOClass.ProductToDTO(DB.GetDB().Products.FindAsync(id).Result);
        }

        public static void DeleteProduct(int id) 
        {
            DB.GetDB().Products.Remove(DB.GetDB().Products.FirstOrDefault(s => s.Id == id));
            DB.GetDB().SaveChanges();
        }

        public static void AddProduct(DTOProduct product)
        {
            DB.GetDB().Products.Add(DTOClass.DTOProductToProduct(product));
            DB.GetDB().SaveChanges();
        }

        public static void UpdateProduct (DTOProduct product) 
        {
            Product product1 = DB.GetDB().Products.First(s => s.Id == product.Id);

            product1.Title = product.Title;
            product1.Description = product.Description;
            product1.Price = product.Price;
            product1.IdCategory = product.IdCategory;   

            DB.GetDB().Products.Update(product1);
            DB.GetDB().SaveChanges();
        }

    }
}
