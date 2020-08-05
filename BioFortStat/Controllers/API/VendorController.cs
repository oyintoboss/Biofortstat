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
    public class VendorController : ApiController
    {
        private ApplicationDbContext _context;

        public VendorController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/vendor
        public IHttpActionResult GetVendor()
        {
            var vendorDtos = _context.VendorUserz
                .Select(Mapper.Map<VendorUser, VendorDto>);
            return Ok(vendorDtos);
        }

        // GET  /api/vendor/1
        public IHttpActionResult GetUser(int id)
        {
            var vendor = _context.VendorUserz.SingleOrDefault(u => u.Id == id);

            if (vendor == null) return NotFound();

            return Ok(Mapper.Map<VendorUser, VendorDto>(vendor));
        }

        // DELETE /api/vendor/1
        [HttpDelete]
        public IHttpActionResult DeleteVendor(int id)
        {
            var vendorInDb = _context.VendorUserz.SingleOrDefault(u => u.Id == id);
            if (vendorInDb == null) return NotFound();

            _context.VendorUserz.Remove(vendorInDb);
            _context.SaveChanges();

            return Ok();
        }

    }
}
