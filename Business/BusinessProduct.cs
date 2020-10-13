using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using Entities;

namespace Business
{
    public class BusinessProduct
    {
        public static List<ProductEntity> ProductList()
        {
            using (var contexto = new InventaryContext())
            {
                return contexto.Products.ToList();
            }
        }

        public static void ProductInsert(ProductEntity productEntity)
        {
            using (var contexto = new InventaryContext())
            {
                contexto.Products.Add(productEntity);
                contexto.SaveChanges();
            }
        }

        public static void ProductUpdate(ProductEntity productEntity)
        {
            using (var contexto = new InventaryContext())
            {
                contexto.Products.Update(productEntity);
                contexto.SaveChanges();
            }
        }
    }
}
