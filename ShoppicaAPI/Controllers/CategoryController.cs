using Microsoft.AspNetCore.Mvc;
using ShoppicaAPI.Models;
using ShoppicaAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoppicaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        CategoryServices cs = new CategoryServices();
        // GET: api/<CategoryController>
        [HttpGet]
        public IEnumerable<Category> GetMainCategories()
        {
            return cs.GetAll();
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public IEnumerable<Category> GetAltCategories(int id)
        {
            return cs.GetById(id);
        }

    }
}
