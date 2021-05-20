using Business.Abstract;
using DataAccess.Abstract;
using Entitites.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        IColorService _colorService;

        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _colorService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("add")]
        public IActionResult Post(Color color)
        {
            var result = _colorService.Add(color);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
