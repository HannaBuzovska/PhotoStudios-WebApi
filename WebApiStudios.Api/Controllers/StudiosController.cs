using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApiStudios.Data.Context;
using WebApiStudios.Data.Models;
using WebApiStudios.Data.Repository;

namespace WebApiStudios.Api.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class StudiosController : ControllerBase
   {
      public IRepository<Studios> contextStudios { get; private set; }
      public StudiosController(IRepository<Studios> contextStudios)
      {
         this.contextStudios = contextStudios;
      }

      [HttpGet]
      public IEnumerable<Studios> Get()
      {
         return contextStudios.All;
      }

      [HttpGet("{name}")]
      public ActionResult<Studios> Get(string name)
      {
         return contextStudios.FindByName(name);
      }

      [HttpPost]
      public void Post([FromQuery] Studios value)
      {
         contextStudios.Update(value);
      }

      [HttpPut("{name}")]
      public void Put(string name, [FromBody] Studios value)
      {
         contextStudios.Add(value);
      }

      [HttpDelete("{name}")]
      public void Delete(string name)
      {
         var entity = contextStudios.FindByName(name);
         contextStudios.Delete(entity);
      }

   }
}