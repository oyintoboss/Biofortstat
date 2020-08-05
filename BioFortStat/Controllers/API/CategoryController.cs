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
    public class CategoryController : ApiController
    {
        private ApplicationDbContext _context;
        public CategoryController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/category
        public IHttpActionResult GetCategory(string query = null)
        {
            var category = _context.Categoryz.ToList()
                .Select(Mapper.Map<Category, CategoryDto>);
            //if (!String.IsNullOrWhiteSpace(query)) product = product.Where(p => p.ProductName.Contains(query));
            return Ok(category);
        }

        // GET /api/category/1
        public IHttpActionResult GetCategories(int id)
        {
            if (!ModelState.IsValid) return BadRequest();
            var category = _context.Categoryz.SingleOrDefault(c => c.Id == id);
            if (category == null) return NotFound();
               
            //if (!String.IsNullOrWhiteSpace(query)) product = product.Where(p => p.ProductName.Contains(query));
            return Ok(Mapper.Map<Category, CategoryDto>(category));
        }

        // POST /api/category
        [HttpPost]
        public IHttpActionResult CreateCategory(CategoryDto categoryDto)
        {
            if (!ModelState.IsValid) return BadRequest();
            var category = Mapper.Map<CategoryDto, Category>(categoryDto);
            _context.Categoryz.Add(category);
            _context.SaveChanges();

            categoryDto.Id = category.Id;
            return Created(new Uri(Request.RequestUri + "/" + category.Id),new { categoryDto, msg = "Category Saved Successfully" });
        }

        // PUT /api/category/1
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, CategoryDto categoryDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var categoryInDb = _context.Categoryz.SingleOrDefault(c => c.Id == id);
            if (categoryInDb == null)
                return NotFound();

            Mapper.Map(categoryDto, categoryInDb);


            var customer = Mapper.Map<CategoryDto, Category>(categoryDto);

            _context.SaveChanges();
            categoryDto.Id = customer.Id;
            return Created(new Uri(Request.RequestUri + "/" + customer.Id), categoryDto);

        }

        // DELETE /api/category/1
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var categoryInDb = _context.Categoryz.SingleOrDefault(c => c.Id == id);

            if (categoryInDb == null)
                return NotFound();

            _context.Categoryz.Remove(categoryInDb);
            _context.SaveChanges();
            return Ok(Mapper.Map<Category, CategoryDto>(categoryInDb));

        }
    }
}
