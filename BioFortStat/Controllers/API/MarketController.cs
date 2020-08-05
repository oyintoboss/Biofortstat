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
    public class MarketController : ApiController
    {
        private ApplicationDbContext _context;
        public MarketController()
        {
            _context = new ApplicationDbContext();
        }

        //  GET /api/market
        public IHttpActionResult GetMarket()
        {
            var market = _context.Marketz.ToList()
                .Select(Mapper.Map<Market, MarketDto>);

            //if (!String.IsNullOrWhiteSpace(query)) product = product.Where(p => p.ProductName.Contains(query));

            return Ok(market);
        }

        //  GET /api/market/1
        public IHttpActionResult GetMarkets(int id)
        {
            var market = _context.Marketz.SingleOrDefault(c => c.Id == id);
            if (market == null)
                return NotFound();
            return Ok(Mapper.Map<Market, MarketDto>(market));
        }

        //  POST /api/market
        [HttpPost]
        public IHttpActionResult CreateMarket(MarketDto marketDto)
        {
            if (!ModelState.IsValid) return BadRequest();
           
                var market = Mapper.Map<MarketDto, Market>(marketDto);
                _context.Marketz.Add(market);
                _context.SaveChanges();

                marketDto.Id = market.Id;
                return Created(new Uri(Request.RequestUri + "/" + marketDto.Id), new { marketDto, msg = "Market successfully Saved !!!" });
                   
           

        }

        //  PUT /api/market
        [HttpPut]
        public IHttpActionResult UpdateMarket(int id, MarketDto marketDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var productInDb = _context.Productz.SingleOrDefault(p => p.Id == id);
            if (productInDb == null) return NotFound();
            Mapper.Map(marketDto, productInDb);

            var product = Mapper.Map<MarketDto, Market>(marketDto);

            _context.SaveChanges();
            marketDto.Id = product.Id;
            return Created(new Uri(Request.RequestUri + "/" + product.Id), marketDto);


        }

        //  DELETE /api/market
        [HttpDelete]
        public IHttpActionResult DeleteMarket(int id)
        {
            var marketrInDb = _context.Marketz.SingleOrDefault(c => c.Id == id);

            if (marketrInDb == null)
                return NotFound();

            _context.Marketz.Remove(marketrInDb);
            _context.SaveChanges();
            return Ok(Mapper.Map<Market, MarketDto>(marketrInDb));

        }
    }
}
