using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShoppicaMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppicaMVC.ViewComponents
{
    public class SliderVC : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var response = GlobalConfig.webClient.GetAsync("ContentProducts/1").Result;
            var json = response.Content.ReadAsStringAsync().Result;
            List<ProductVM> productVMs = JsonConvert.DeserializeObject<List<ProductVM>>(json);
            return View(productVMs);
        }
    }
}
