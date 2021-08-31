using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using c_greglist.Models;
using c_greglist.Services;

namespace c_greglist.Controllers
{
  [ApiController]
  [Route("/api/[controller]")]
    public class CarController :ControllerBase
    {
    [HttpGet()]
    public ActionResult<IEnumerable<Car>> Get()
    {
      try
      {
        IEnumerable<Car> cars = _carsService.Get();
        return ok(cars);
      }
      catch(Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Car> Get(string id)
    {
      try
      {
        Car found = _carsService.Get(id);
        return Ok(found);
      }
      catch(Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpPost]
    public ActionResult<Car> Create([FromBody] Car newCar)
    {
      try
      {
        Car car = _carsService.Create(newCar);
        return Ok(car);
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
        _carsService.Delete(id);
        return Ok("Car has been sold!");
      }
      catch (Exception)
      {
        return BadRequest(err.Message);
      }

    }
  }
}