using System.Collections.Generic;
using System.Linq;
using WebApiStudios.Data.Context;
using WebApiStudios.Data.Models;

namespace WebApiStudios.Data.Repository
{
   public class StudiosRepository : IRepository<Studios>
   {
      private readonly WebApiStudiosContext context;
      public IEnumerable<Studios> All => context.Studios.ToList();
      public StudiosRepository(WebApiStudiosContext context)
      {
         this.context = context;
      }
      public void Add(Studios entity)
      {
         context.Studios.Add(entity);
      }
      public void Delete(Studios entity)
      {
         context.Studios.Remove(entity);
         context.SaveChanges();
      }
      public Studios FindByName(string name)
      {
         return context.Studios.FirstOrDefault(e => e.name == name);
      }
      public void Update(Studios entity)
      {
         context.Studios.Update(entity);
         context.SaveChanges();
      }
   }
}