using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using burgershack.Interfaces;
using burgershack.Models;
using burgershack.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace burgershack.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BurgersController : ControllerBase
  //   ICodeWorksRestfulController<Burger>
  {
    private readonly BurgersService _bs;

    public BurgersController(BurgersService bs)
    {
      _bs = bs;
    }

    // [HttpPost]

    // public ActionResult<Burger> Create([FromBody] Burger newBurger)
    // {
    //   try
    //   {
    //     Burger burger = _bs.Create(newBurger);
    //     return Ok(burger);
    //   }
    //   catch (Exception e)
    //   {
    //     return BadRequest(e.Message);
    //   }
    // }

    public ActionResult<Burger> Create([FromBody] Burger newBurger)
    {
      try
      {
        Burger burger = _bs.Create(newBurger);
        return Ok(burger);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    // [HttpDelete("{id}")]
    // public ActionResult<Burger> Delete(int id)
    // {
    //   try
    //   {
    //     _bs.Delete(id);
    //     return Ok("deleted");
    //   }
    //   catch (Exception e)
    //   {
    //     return BadRequest(e.Message);
    //   }
    // }

    [HttpDelete("{id}")]
    public ActionResult<Burger> Delete(int id)
    {
      try
      {
        _bs.Delete(id);
        return Ok("deleted");
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet]
    public ActionResult<IEnumerable<Burger>> GetAll()
    {
      try
      {
        IEnumerable<Burger> burgers = _bs.GetAll();
        return Ok(burgers);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    // [HttpGet("{id")]
    // public ActionResult<Burger> GetById(int id)
    // {
    //   try
    //   {
    //     Burger found = _bs.GetById(id);
    //     return Ok(found);
    //   }
    //   catch (Exception e)
    //   {
    //     return BadRequest(e.Message);
    //   }
    // }

    [HttpGet("{id")]
    public ActionResult<Burger> GetById(int id)
    {
      try
      {
        Burger found = _bs.GetById(id);
        return Ok(found);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    // [HttpPut("{id}")]
    // public ActionResult<Burger> Update(int id, [FromBody] Burger update)
    // {
    //   try
    //   {
    //     update.Id = id;
    //     Burger updated = _bs.Update(update);
    //     return Ok(updated);
    //   }
    //   catch (Exception e)
    //   {
    //     return BadRequest(e.Message);
    //   }
    // }

    [HttpPut("{id}")]
    public ActionResult<Burger> Update(int id, [FromBody] Burger update)
    {
      try
      {
        update.Id = id;
        Burger updated = _bs.Update(update);
        return Ok(updated);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}
