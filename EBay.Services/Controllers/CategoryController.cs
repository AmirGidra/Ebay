using Contracts;
using Ebay.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EBay.Services.Controllers
{
    public class CategoryController : ApiController
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        [ActionName("GetCategory")]

        public IHttpActionResult GetCategory(int id)
        {
           CategoryDto category= _categoryRepository.GetCategoryById(id);

            return Ok(category);

        }
        


    }
}
