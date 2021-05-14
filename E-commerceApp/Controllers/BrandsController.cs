using EcommerceApp1.Data;
using EcommerceApp1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceApp1.Vm;

namespace EcommerceApp1.Controllers
{
    public class BrandsController : Controller
    {

        public EcommerceApp1Context _dbcontext { get; set; }

        public BrandsController(EcommerceApp1Context dbcontext)
        {
            _dbcontext = dbcontext;
        }




        public IActionResult Index()
        {
            var listBrands = _dbcontext.Brands.Where(brand => brand.IsDelete == false).Select(brand =>
                
                new BrandsVm()
                {
                    Name = brand.Name,
                    Id = brand.Id,
                    CreationDate = brand.CreationDate
                }
                ).ToList();
            return View(listBrands);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(BrandsVm brand, IFormFile file)
        {
            var newBrand = new Brands() { Name = brand.Name, Description = brand.Description };
            await _dbcontext.Brands.AddAsync(newBrand);
            await _dbcontext.SaveChangesAsync();
            return View();
        }
        
        
    }
}