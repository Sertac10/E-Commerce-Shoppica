﻿using ShoppicaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppicaAPI.Services
{
    public class CategoryServices
    {
        ShoppicaContext DB = new ShoppicaContext();

        public IEnumerable<Category> GetAll() => (from c in DB.Categories.Where(x => x.TopId == null)
                                                  select new Category
                                                  {
                                                      CategoryName = c.CategoryName,
                                                      Id = c.Id,
                                                      Top = c.Top,
                                                      TopId = c.TopId,
                                                      InverseTop = c.InverseTop.ToList(),
                                                      Products = c.Products.ToList()
                                                  }).ToList();
        public IEnumerable<Category> GetById(int id)
        {
            Category category = DB.Categories.Find(id);
            List<Category> liste;
            if (category.TopId == null)//ana kategori
            {
                liste = (from c in DB.Categories.Where(x => x.TopId == id)
                         select c).ToList();

            }
            else //alt kategori
            {
                liste = (from c in DB.Categories.Where(x => x.TopId == category.TopId) select c).ToList();

            }
            return liste;
        }
    }
}
