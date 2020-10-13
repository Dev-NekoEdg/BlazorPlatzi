using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using Entities;

namespace Business
{
    public class BusinessStorage
    {
        public List<StorageEntity> StorageList()
        {
            using (var contexto = new InventaryContext())
            {
                return contexto.Storages.ToList();
            }
        }

        public void StorageInsert(StorageEntity storageEntity)
        {
            using (var contexto = new InventaryContext())
            {
                contexto.Storages.Add(storageEntity);
                contexto.SaveChanges();
            }
        }

        public void StorageUpdate(StorageEntity storageEntity)
        {
            using (var contexto = new InventaryContext())
            {
                contexto.Storages.Update(storageEntity);
                contexto.SaveChanges();
            }
        }
    }
}
