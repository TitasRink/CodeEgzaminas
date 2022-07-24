using FrameworkData.Model;
using System.Collections.Generic;

namespace Bussiness.AccesssData
{
    public interface ICategoryService
    {
        void CreatCat(string name);
        void EditCat(string newCategoryName, string oldName);
        List<Category> GetCatAll(int catId);
        void RemoveCategory(string category);
    }
}