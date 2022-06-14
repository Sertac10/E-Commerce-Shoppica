using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShoppicaMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppicaMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProduct(int id)
        {
            var response = GlobalConfig.webClient.GetAsync("Product/" + id).Result;
            var json = response.Content.ReadAsStringAsync().Result;
            List<ProductVM> productVMs = JsonConvert.DeserializeObject<List<ProductVM>>(json);
           
            return View(productVMs);
        }
    }
}
