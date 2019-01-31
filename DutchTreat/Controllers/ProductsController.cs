using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DutchTreat.Data;
using DutchTreat.Data.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DutchTreat.Controllers
{
    [Route("api/[Controller]")]
    public class ProductsController : Controller
    {
        private readonly IDutchRepository _repository;

        public ProductsController(IDutchRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _repository.GetAllProducts();
        }
    }
}
   


