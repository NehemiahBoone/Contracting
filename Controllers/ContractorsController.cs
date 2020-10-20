using System;
using Contracting.Models;
using Contracting.Services;
using Microsoft.AspNetCore.Mvc;

namespace Contracting.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ContractorsController : ControllerBase
  {
    private readonly ContractorsService _service;
    public ContractorsController(ContractorsService cs)
    {
      _service = cs;
    }

    [HttpGet]
    public ActionResult<string> GetAll()
    {
      try
      {
        return Ok(_service.GetAll());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Contractor> GetById(int id)
    {
      try
      {
        return Ok(_service.GetById(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Contractor> Create([FromBody] Contractor newContractor)
    {
      try
      {
        return Ok(_service.Create(newContractor));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPut("{id}")]
    public ActionResult<Contractor> Edit([FromBody] Contractor updated, int id)
    {
      try
      {
        updated.Id = id;
        return Ok(_service.Edit(updated));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<Contractor> Delete(int id)
    {
      try
      {
        return Ok(_service.Delete(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}