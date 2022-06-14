using ShoppicaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppicaAPI.Services
{
    public class ProductServices
    {
        ShoppicaContext DB = new ShoppicaContext();
        public IEnumerable<Product> GetProducts(int id)
        {

            Category category = DB.Categories.Find(id);
            List<Product> liste;
            if (category.TopId == null)//ana kategori
            {
                liste = (from p in DB.Products
                         join c in DB.Categories on p.CategoryId equals c.Id
                         where c.TopId == id
                         select p).ToList();

            }
            else //alt kategori
            {
                liste = (from p in DB.Products.Where(x => x.CategoryId == id)
                         select p).ToList();
            }
            return liste;
        }

        public IEnumerable<Product> GetContentProducts(int id)
        {
            if (id==1)//slider
            {
                return DB.Products.OrderBy(x => Guid.NewGuid()).Take(5).ToList();
            }
            else if (id==2)//special
            {
                return DB.Products.Where(x=>x.IsSpecial==true).OrderBy(x=>Guid.NewGuid()).Take(6).ToList();
            }
            else//last added
            {
                return DB.Products.OrderByDescending(x => x.CreatedDate).Take(6).ToList();

            }
        }
    }
}
