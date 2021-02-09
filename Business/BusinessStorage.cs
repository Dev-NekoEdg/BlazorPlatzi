using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class BusinessStorage
    {
        public static List<StorageEntity> StorageList()
        {
            using (var contexto = new InventaryContext())
            {
                return contexto.Storages.ToList();
            }
        }

        public static List<StorageEntity> StorageListByWerehouse(string werehouse)
        {
            using (var contexto = new InventaryContext())
            {
                return contexto.Storages.
                    Include(s=> s.Product). // para que el include funcione necesita de la libreria Microsoft.EntityFrameworkCore;
                    Include(s => s.Werehouses).
                    Where(s=> s.WerehouseId == werehouse).
                    ToList();
            }
        }

        public static bool IsProductOnWerehouse(string id) 
        {
            using (var contexto = new InventaryContext())
            {
                var product = contexto.Storages.ToList().Where(p => p.StoregeId == id);

                return product.Any();
            }
        }

        public static void StorageInsert(StorageEntity storageEntity)
        {
            using (var contexto = new InventaryContext())
            {
                contexto.Storages.Add(storageEntity);
                contexto.SaveChanges();
            }
        }

        public static void StorageUpdate(StorageEntity storageEntity)
        {
            using (var contexto = new InventaryContext())
            {
                contexto.Storages.Update(storageEntity);
                contexto.SaveChanges();
            }
        }
    }
}
