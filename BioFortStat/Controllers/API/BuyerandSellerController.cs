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
    public class BuyerandSellerController : ApiController
    {
        private ApplicationDbContext _context;
        public BuyerandSellerController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/product
        public IHttpActionResult GetBuyerAndSeller()
        {
            var buyerandseller = _context.BuyerAndSellerz
                .Select(Mapper.Map<BuyerAndSeller, BuyerAndSellerDto>);
            return Ok(buyerandseller);
        }

        // GET /api/product/1
        public IHttpActionResult GetBuyerAndSeller(int id)
        {
            var buyerandseller = _context.BuyerAndSellerz.SingleOrDefault(r => r.Id == id);
            if (buyerandseller == null) return NotFound();
            
            return Ok(Mapper.Map<BuyerAndSeller, BuyerAndSellerDto>(buyerandseller));
        }


        // POST /api/product
        [HttpPost]
        public IHttpActionResult CreateBuyerAndSeller(BuyerAndSellerDto buyandsellDto)
        {
            buyandsellDto.CreatedDate = DateTime.Now;

            try
            {
                if (!ModelState.IsValid) return BadRequest();
                var buyerandseller = Mapper.Map<BuyerAndSellerDto, BuyerAndSeller>(buyandsellDto);
                _context.BuyerAndSellerz.Add(buyerandseller);
                _context.SaveChanges();
                buyandsellDto.Id = buyerandseller.Id;
                return Created(new Uri(Request.RequestUri + "/" + buyandsellDto.Id), new { buyandsellDto, msg = "Buyers And Sellers successfully Done !!!" });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                throw;
            }
        }

        // PUT /api/product
        [HttpPut]
        public IHttpActionResult UpdateBuyerAndSeller(int id, BuyerAndSellerDto buyandsellDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var renterInDb = _context.BuyerAndSellerz.SingleOrDefault(r => r.Id == id);

            if (renterInDb == null) return NotFound();

            Mapper.Map(buyandsellDto, renterInDb);

            _context.SaveChanges();
            return Ok(buyandsellDto);
        }

        // DELETE /api/renterproduct
        [HttpDelete]
        public IHttpActionResult DeleteBuyerAndSeller(int id)
        {
            var renterInDb = _context.BuyerAndSellerz.SingleOrDefault(r => r.Id == id);
            if (renterInDb == null) return NotFound();

            _context.BuyerAndSellerz.Remove(renterInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
