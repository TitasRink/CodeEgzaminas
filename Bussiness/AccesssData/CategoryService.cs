using FrameworkData.DataContext;
using FrameworkData.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Bussiness.AccesssData
{
    public class CategoryService 
    {
        public DataConection context = new DataConection() ;

        public CategoryService()
        {
            
        }
        public void CreatCat(string name)
        {
            
            context.Categories.Add(new Category(name));
            
            context.SaveChanges();
        }
        public void EditCat( string newCategoryName, string oldName)
        {

            var dep = context.Categories.Where(x => x.Name == oldName).FirstOrDefault();
            dep.Name = newCategoryName;
            context.SaveChanges();
        }
        public List<Category> GetCatAll()
        {
            var result = context.Categories.ToList();
            return result;
        }
        public void RemoveCategory(string category)
        {
            var cate = context.Categories.Where(x=>x.Name == category).FirstOrDefault();
            context.Categories.Remove(cate);
            context.SaveChanges();
        }
    }
}
