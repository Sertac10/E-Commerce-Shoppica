using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppicaAPI.Models;
using ShoppicaAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppicaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ProductServices ps = new ProductServices();
        [HttpGet("{id}")]
        public IEnumerable<Product> GetMainCategories(int id)
        {
            return ps.GetProducts(id);
        }
    }
}
