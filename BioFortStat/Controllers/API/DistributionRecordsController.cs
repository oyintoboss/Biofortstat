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
    public class DistributionRecordsController : ApiController
    {
        private ApplicationDbContext _context;

        public DistributionRecordsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/distributionrecords
        public IHttpActionResult GetRenter()
        {
            var distrec = _context.DistributionRecordsz
                .Select(Mapper.Map<DistributionRecords, DistributionRecordsDto>);
            return Ok(distrec);
        }

        // GET /api/distributionrecords/1
        public IHttpActionResult GetRenter(int id)
        {
            var distrec = _context.DistributionRecordsz.SingleOrDefault(r => r.Id == id);
            if (distrec == null) return NotFound();

            return Ok(Mapper.Map<DistributionRecords, DistributionRecordsDto>(distrec));
        }

        // POST /api/distributionrecords
        [HttpPost]
        public IHttpActionResult CreateDistRecords(DistributionRecordsDto distributionrecordsDto)
        {
            distributionrecordsDto.CreatedDate = DateTime.Now;
            try
            {
                if (!ModelState.IsValid) return BadRequest();
                var distrec = Mapper.Map<DistributionRecordsDto, DistributionRecords>(distributionrecordsDto);
                _context.DistributionRecordsz.Add(distrec);
                _context.SaveChanges();
                distributionrecordsDto.Id = distrec.Id;
                return Created(new Uri(Request.RequestUri + "/" + distrec.Id), new { distributionrecordsDto , value = 1, msg = "Distribution Records Saved!!! "});


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                throw;
            }
        }

        // PUT /api/distributionrecords
        [HttpPut]
        public IHttpActionResult UpdateRenter(int id, DistributionRecordsDto distributionrecordsDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var distrecInDb = _context.DistributionRecordsz.SingleOrDefault(r => r.Id == id);

            if (distrecInDb == null) return NotFound();

            Mapper.Map(distributionrecordsDto, distrecInDb);

            _context.SaveChanges();
            return Ok();
        }

        // DELETE /api/distributionrecords
        [HttpDelete]

        public IHttpActionResult DeleteRenter(int id)
        {
            var distrecInDb = _context.DistributionRecordsz.SingleOrDefault(r => r.Id == id);
            if (distrecInDb == null) return NotFound();

            _context.DistributionRecordsz.Remove(distrecInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
