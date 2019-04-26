using Contracts;
using Ebay.BLL;
using Ebay.DAL;
using System.Collections.Generic;
using System.Web.Http;

namespace EBay.Services.Controllers
{
    public class ProductController : ApiController
    {
        private readonly IProductBLL _productBLL;
        private readonly IProductRepository _productRepository;
        public ProductController(IProductBLL itemBLL, IProductRepository itemRepository)
        {
            _productBLL = itemBLL; // _itemBLL is null until I receive info from Contstructor argument _itemBll becomes itemBLL
            _productRepository = itemRepository;
        }

        [HttpGet]
        [ActionName("GetAllItems")]
        public IHttpActionResult GetAllItems()
        {
            return Ok();
        }
        //Second method
        [HttpGet]
        [HttpOptions]
        [ActionName("GetItem")]
        public IHttpActionResult GetItem(int id)
        {

            //ProductDto item = _productRepository.GetProductById(id);
            // var item = items.FirstOrDefault((p) => p.id == id); _itemRepository.GetItemById(id);
             return Ok("GetItem");
        }

        [HttpGet]
        [HttpOptions]
        [ActionName("GetItems")]
        //api/{controller}/{action}/{id}"
        public IHttpActionResult GetItemsOfSearchValue(SearchValueDto filter)
        {
            filter = new SearchValueDto
            {
                SearchValue = "",
                CategoryId = 0,
                Condition = 1,
                FreeShipping = false,
                Price = 10
            };

            IEnumerable<ProductDto> items = _productRepository.GetItemsOfSearchValue(filter);
            //ProductDto item = _productRepository.GetProductById(id);
            // var item = items.FirstOrDefault((p) => p.id == id); _itemRepository.GetItemById(id);
            return Ok(items);
        }

        [HttpPost]
        [ActionName("SaveItem")]
        public IHttpActionResult SaveItem()
       {
            _productBLL.ValidatePrice(3);
            return Ok();
        }

    }

   
}
