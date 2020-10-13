using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using Entities;

namespace Business
{
    public class BusinessCategory
    {

        public static List<CategoryEntity> CategoryList() 
        {
            using (var contexto = new InventaryContext())
            {
                return contexto.Categories.ToList();
            }
        }

        public void CategoryInsert(CategoryEntity categoryEntity)
        {
            using (var contexto = new InventaryContext())
            {
                contexto.Categories.Add(categoryEntity);
                contexto.SaveChanges();
            }
        }

        public void CategoryUpdate(CategoryEntity categoryEntity)
        {
            using (var contexto = new InventaryContext())
            {
                contexto.Categories.Update(categoryEntity);
                contexto.SaveChanges();
            }
        }
    }
}
