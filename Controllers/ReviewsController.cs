using System;
using Contracting.Models;
using Contracting.Services;
using Microsoft.AspNetCore.Mvc;

namespace Contracting.Controllers
{
  [ApiController]
  [Route("api/[controller]")]4
  public class ReviewsController : ControllerBase
  {
    private readonly ReviewsService _service;

    public ReviewsController(ReviewsService service)
    {
      _service = service;
    }

    [HttpGet("{id}")]
    public ActionResult<Review> GetById(int id)
    {
      try
      {
        return Ok(_service.GetById(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message)
      }
    }

  }
}