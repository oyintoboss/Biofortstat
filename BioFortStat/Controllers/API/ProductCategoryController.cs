using AutoMapper;
using BioFortStat.Dto;
using BioFortStat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BioFortStat.Controllers.API
{
    public class ProductCategoryController : ApiController
    {
        private ApplicationDbContext _context;

        public ProductCategoryController()
        {
            _context = new ApplicationDbContext();
        }
        //  GET /api/productcategory
        public IHttpActionResult GetProductCategory()
        {
            var prodcate = _context.ProdCatez
                .Select(Mapper.Map<ProductCategory, ProductCategortDto>);
            return Ok(prodcate);
        }

        //  GET /api/productcategory/1
        public IHttpActionResult GetProductCategory(int id)
        {
            var prodcate = _context.ProdCatez.SingleOrDefault(r => r.Id == id);
            if (prodcate == null) return NotFound();

            return Ok(Mapper.Map<ProductCategory, ProductCategortDto>(prodcate));
        }

        //  POST /api/productcategory
        [HttpPost]
        public IHttpActionResult CreateProductCategory(ProductCategortDto PcategoryDto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest();
                var prodcate = Mapper.Map<ProductCategortDto, ProductCategory>(PcategoryDto);
                _context.ProdCatez.Add(prodcate);
                _context.SaveChanges();
                PcategoryDto.Id = prodcate.Id;
                return Created(new Uri(Request.RequestUri + "/" + prodcate.Id),  new { PcategoryDto, value = 1, msg= " The Product Category was successful!!!"});

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                throw;
            }
        }

        //  PUT /api/productcategory
        [HttpPut]
        public IHttpActionResult UpdateProductCategory(int id, ProductCategortDto PcategoryDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var prodcateInDb = _context.ProdCatez.SingleOrDefault(r => r.Id == id);

            if (prodcateInDb == null) return NotFound();

            Mapper.Map(PcategoryDto, prodcateInDb);

            _context.SaveChanges();
            return Ok();
        }

        //  DELETE /api/productcategory
        [HttpDelete]
        public IHttpActionResult DeleteProductCategory(int id)
        {
            var prodcateInDb = _context.ProdCatez.SingleOrDefault(r => r.Id == id);
            if (prodcateInDb == null) return NotFound();

            _context.ProdCatez.Remove(prodcateInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
