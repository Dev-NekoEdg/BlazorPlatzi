using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using Entities;

namespace Business
{
    public class BusinessWereHouse
    {
        public static List<WerehouseEntity> WereHouseList()
        {
            using (var contexto = new InventaryContext())
            {
                return contexto.Werehouses.ToList();
            }
        }

        public static WerehouseEntity WereHouseById(string id)
        {
            using (var contexto = new InventaryContext())
            {
                return contexto.Werehouses.ToList().FirstOrDefault(wh=> wh.WerehouseId == id);
            }
        }

        public static void WereHouseInsert(WerehouseEntity werehouseEntity)
        {
            using (var contexto = new InventaryContext())
            {
                contexto.Werehouses.Add(werehouseEntity);
                contexto.SaveChanges();
            }
        }

        public static void WereHouseUpdate(WerehouseEntity werehouseEntity)
        {
            using (var contexto = new InventaryContext())
            {
                contexto.Werehouses.Update(werehouseEntity);
                contexto.SaveChanges();
            }
        }
    }
}
