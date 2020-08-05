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
    public class PriceController : ApiController
    {
        private ApplicationDbContext _context;

        public PriceController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/price
        public IHttpActionResult GetPrice(string query = null)
        {
            var price = _context.Pricez.ToList()
                .Select(Mapper.Map<Price, PriceDto>);
            //if (!String.IsNullOrWhiteSpace(query)) product = product.Where(p => p.ProductName.Contains(query));
            return Ok(price);
        }

        // GET /api/price/1
        public IHttpActionResult GetPrice(int id)
        {
            var price = _context.Pricez.SingleOrDefault(p => p.Id == id);
            if (price == null) return NotFound();
            return Ok(Mapper.Map<Price, PriceDto>(price));
        }

        // POST /api/price/1
        [HttpPost]
        public IHttpActionResult SetupPrice(PriceDto priceDto)
        {
            priceDto.CreatedDate = DateTime.Now;
            try
            {
                if (!ModelState.IsValid) return BadRequest();
                
                var price = Mapper.Map<PriceDto, Price>(priceDto);
                _context.Pricez.Add(price);
                _context.SaveChanges();
                priceDto.Id = price.Id;
                return Created(new Uri(Request.RequestUri + "/" + price.Id), new { priceDto,value = 1 , msg = "Prices successfully Done !!!" });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                throw;
            }
        }

        // PUT /api/price/1
        [HttpPut]
        public IHttpActionResult UpdatePrice(int id, PriceDto priceDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var priceInDb = _context.Productz.SingleOrDefault(p => p.Id == id);
            if (priceInDb == null) return NotFound();
            Mapper.Map(priceDto, priceInDb);

            var product = Mapper.Map<PriceDto, Price>(priceDto);

            _context.SaveChanges();
            priceDto.Id = product.Id;
            return Created(new Uri(Request.RequestUri + "/" + product.Id), priceDto);

        }

        // DELETE /api/product/1
        [HttpDelete]
        public IHttpActionResult DeletePrice(int id)
        {
            var priceInDb = _context.Pricez.SingleOrDefault(p => p.Id == id);
            if (priceInDb == null) return NotFound();

            _context.Pricez.Remove(priceInDb);
            _context.SaveChanges();
            return Ok(Mapper.Map<Price, PriceDto>(priceInDb));

        }
    }
}
