using APIFunshop.DataBaseFolder;
using APIFunshop.DTO;
using APIFunshop.Helper;
using Microsoft.EntityFrameworkCore;

namespace APIFunshop.Logic
{
    public static class CategoryLogic
    {
        public static List<DTOCategory> GetAllCategories()
        {
            List<Category> Categories = DB.GetDB().Categories.ToList();

            List<DTOCategory> dto = new List<DTOCategory>();

            foreach (var item in Categories)
            {
                dto.Add(DTOClass.CategoryTODTOCategory(item));
            }
            return dto;
        }

        public static DTOCategory GetCategory(int id)
        {
            return DTOClass.CategoryTODTOCategory(DB.GetDB().Categories.FindAsync(id).Result);
        }

        public static void DeleteCategory(int id)
        {
            DB.GetDB().Categories.Remove(DB.GetDB().Categories.FirstOrDefault(s => s.Id == id));
            DB.GetDB().SaveChanges();
        }

        public static void AddCategory(DTOCategory category)
        {
            DB.GetDB().Categories.Add(DTOClass.DTOCategoryToCategory(category));
            DB.GetDB().SaveChanges();
        }

        public static void UpdateCategory(DTOCategory category)
        {
            Category category1 = DB.GetDB().Categories.FirstOrDefault(s => s.Id == category.Id); 

            category1.Title = category.Title;   
           
            DB.GetDB().Categories.Update(category1);
            DB.GetDB().SaveChanges();
        }
    }
}
