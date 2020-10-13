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
        public List<WerehouseEntity> WereHouseList()
        {
            using (var contexto = new InventaryContext())
            {
                return contexto.Werehouses.ToList();
            }
        }

        public void WereHouseInsert(WerehouseEntity werehouseEntity)
        {
            using (var contexto = new InventaryContext())
            {
                contexto.Werehouses.Add(werehouseEntity);
                contexto.SaveChanges();
            }
        }

        public void WereHouseUpdate(WerehouseEntity werehouseEntity)
        {
            using (var contexto = new InventaryContext())
            {
                contexto.Werehouses.Update(werehouseEntity);
                contexto.SaveChanges();
            }
        }
    }
}
