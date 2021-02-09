using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using Entities;

namespace Business
{
    public class BusinessInputOutput
    {
        public List<InputOutputEntity> InputOutputList()
        {
            using (var contexto = new InventaryContext())
            {
                return contexto.InputOutputs.ToList();
            }
        }

        public static void InputOutputInsert(InputOutputEntity inputOutputEntity)
        {
            using (var contexto = new InventaryContext())
            {
                contexto.InputOutputs.Add(inputOutputEntity);
                contexto.SaveChanges();
            }
        }

        public void InputOutputUpdate(InputOutputEntity inputOutputEntity)
        {
            using (var contexto = new InventaryContext())
            {
                contexto.InputOutputs.Update(inputOutputEntity);
                contexto.SaveChanges();
            }
        }
    }
}
