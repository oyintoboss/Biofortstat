using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BioFortStat.Dto
{
    public class MarketDto
    {
        public int Id { get; set; }
        public string MarketName { get; set; }
        public string MarketDescription { get; set; }
        public string MarketDays { get; set; }
        public string MainProducts { get; set; }
        public string MarketState { get; set; }
        public string MarketLGA { get; set; }
    }
}