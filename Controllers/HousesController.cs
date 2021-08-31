using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using c_greglist.Model;
using c_greglist.Services;

namespace c_greglist.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class HousesController :ControllerBase
    {
    private readonly HousesService _housesService;
    public HousesController(HousesService housesService)
    {
      _housesService = housesService;
    }
    
    [HttpGet]
    public ActionResult<IEnumerable<House>> Get()
    {
        try
        {
        IEnumerable<House> houses = _housesService.Get();
        return Ok(houses);
      }
        catch (System.Exception err)
        {

        return BadRequest(err.Message);
      }
    }
[HttpGet("{id}")]
    public ActionResult<House> Get(string id)
    {
      try
      {
        House found = _housesService.Get(id);
        return Ok(found);
      }
      catch(Exception err)
      {
        return BadRequest(err.Message);
      }
    }

[HttpPost]
    public ActionResult<House> Create([FromBody] House newHouse)
    {
      try
      {
        House house = _housesService.Create(newHouse);
        return Ok(house);
      }
      catch(Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<String> Delete(string id)
    {
      try
      {
        _housesService.Delete(id);
        return Ok("House has been sold!");
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }

    }



  }
}