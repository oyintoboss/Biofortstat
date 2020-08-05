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
    public class ProductController : ApiController
    {
        public ApplicationDbContext _context;
        public ProductController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/product
        public IHttpActionResult GetProduct(string query = null)
        {
            var product = _context.Productz.ToList()
                .Select(Mapper.Map<Product, ProductDto>);
            //if (!String.IsNullOrWhiteSpace(query)) product = product.Where(p => p.ProductName.Contains(query));
            return Ok( product );
        }

        // GET /api/product/1
        public IHttpActionResult GetProduct(int id)
        {
            var product = _context.Productz.SingleOrDefault(p => p.Id == id);
            if (product == null) return NotFound();
            return Ok(Mapper.Map<Product, ProductDto>(product));
        }

        // POST /api/product
        [HttpPost]
        public IHttpActionResult CreateProduct(ProductDto productDto)
        {
            productDto.CreatedDate = DateTime.Now;
            try
            {
                if (!ModelState.IsValid) return BadRequest();
                var product = Mapper.Map<ProductDto, Product>(productDto);
                _context.Productz.Add(product);
                _context.SaveChanges();
                productDto.Id = product.Id;
                return Created(new Uri(Request.RequestUri + "/" + productDto.Id), new { productDto, msg = "Product successfully Done !!!" });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                throw;
            }
        }

        // PUT /api/product/1
        [HttpPut]
        public IHttpActionResult UpdateProduct(int id, ProductDto productDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var productInDb = _context.Productz.SingleOrDefault(p => p.Id == id);
            if (productInDb == null) return NotFound();
            Mapper.Map(productDto, productInDb);

            var product = Mapper.Map<ProductDto, Product>(productDto);

            _context.SaveChanges();
            productDto.Id = product.Id;
            return Created(new Uri(Request.RequestUri + "/" + product.Id), productDto);

        }

        // DELETE /api/product/1
        [HttpDelete]
        public IHttpActionResult DeleteProduct(int id)
        {
            var productInDb = _context.Productz.SingleOrDefault(p => p.Id == id);
            if (productInDb == null) return NotFound();

            _context.Productz.Remove(productInDb);
            _context.SaveChanges();
            return Ok(Mapper.Map<Product, ProductDto>(productInDb));

        }
    }
}
