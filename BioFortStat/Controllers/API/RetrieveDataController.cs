using BioFortStat.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BioFortStat.Controllers.API
{

    //public class GetproductpiController : ApiController
    //{
    //    private ApplicationDbContext _context;

    //    public GetproductpiController()
    //    {
    //        _context = new ApplicationDbContext();
    //    }

    //    public IHttpActionResult GetPict()
    //    {
    //        try
    //        {
    //            _context.Configuration.ProxyCreationEnabled = false;

    //            var picz = _context.BuyerAndSellerz.Select(x => x.ProductPicture).ToList();
    //            return Ok(new { picz });  // 

    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //            Console.WriteLine(ex.StackTrace);
    //            Console.WriteLine(ex.InnerException);
    //            return Ok(new { msg = "Crops Not successful !!!" });
    //        }
    //    }

    //}

    public class GetproductpiczController : ApiController
    {
        private ApplicationDbContext _context;

        public GetproductpiczController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetPict()
        {
            try
            {
                _context.Configuration.ProxyCreationEnabled = false;

                var picz = _context.Productz.Select(x => x.ProductPicture).ToList();
                return Ok(new { picz });  // 

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException);
                return Ok(new { msg = "Crops Not successful !!!" });
            }
        }

    }

    public class GetGeoController : ApiController
    {
        private ApplicationDbContext _context;

        public GetGeoController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetGeoz()
        {
            try
            {             
                
                _context.Configuration.ProxyCreationEnabled = false;
                var northeast = _context.Regionz.Where(a => a.ZoneName == "North East").Select(a => a.State).ToList();
                var southeast = _context.Regionz.Where(a => a.ZoneName == "South East").Select(a => a.State).ToList();
                var northcent = _context.Regionz.Where(a => a.ZoneName == "North Central").Select(a => a.State).ToList();
                var northwest = _context.Regionz.Where(a => a.ZoneName == "North West").Select(a => a.State).ToList();
                var southsouth = _context.Regionz.Where(a =>a.ZoneName == "South South").Select(a => a.State).ToList();
                var southwest = _context.Regionz.Where(a => a.ZoneName == "South West").Select(a => a.State).ToList();
                return Ok(new { northeast, southeast, northcent, northwest, southsouth, southwest });  // 

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException);
                return Ok(new { msg = "Crops Not successful !!!" });
            }
        }

    }

    public class GetYear_And_IndicatorController : ApiController
    {
        private ApplicationDbContext _context;

        public GetYear_And_IndicatorController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetYearzandIndicator()
        {
            try
            {

                _context.Configuration.ProxyCreationEnabled = false;
                var yearandindicator = _context.DistributionRecordsz.Distinct().ToList();
                
                return Ok(new { yearandindicator });  // 

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException);
                return Ok(new { msg = "Crops Not successful !!!" });
            }
        }

    }
    public class GetCropController : ApiController
    {
        private ApplicationDbContext _context;

        public GetCropController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetCropzandIndicator()
        {
            try
            {

                _context.Configuration.ProxyCreationEnabled = false;
                var crop = _context.Cropz.ToList();
                return Ok(new { crop });  // 

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException);
                return Ok(new {msg = "Crops Not successful !!!"});
            }
        }

    }

    public class GetUserRoleController : ApiController
    {
        private ApplicationDbContext _context;

        public GetUserRoleController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetRoleUser()
        {
            try
            {

                _context.Configuration.ProxyCreationEnabled = false;
                var rolez = _context.Roles.ToList();
                return Ok(new { value = 1, rolez });  

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException);
                return Ok(new { value = 0 });
            }
        }

    }

    public class GetBuyerandSellerController : ApiController
    {
        private ApplicationDbContext _context;

        public GetBuyerandSellerController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetBuyerSeller()
        {
            try
            {

                _context.Configuration.ProxyCreationEnabled = false;
                var buyer = _context.BuyerAndSellerz.ToList();                
                return Ok(new { value = 1, buyer });  // 

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException);
                return Ok(new { value = 0 });
            }
        }

    }

    public class RetrieveDataController : ApiController
    {
        private ApplicationDbContext _context;

        public RetrieveDataController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetUnitandstate()
        {
            try
            {

                _context.Configuration.ProxyCreationEnabled = false;
                var unit = _context.Unitz.ToList();
                var state = _context.Statez.ToList();
                return Ok(new { unit, state, value = 1 });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException);
                return Ok(new { value = 0 });
            }
        }

    }

    public class GetCrop_Indicator_StateController : ApiController
    {
        private ApplicationDbContext _context;

        public GetCrop_Indicator_StateController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetCropIndicatorState()
        {
            try
            {

                _context.Configuration.ProxyCreationEnabled = false;
                var crop = _context.Cropz.ToList();
                var indicator = _context.Indicatorz.ToList();
                var state = _context.Statez.ToList();
                return Ok(new { crop, indicator, state, value = 1 });  // 

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException);
                return Ok(new { value = 0 });
            }
        }

    }

    public class ProductNameController : ApiController
    {
        private ApplicationDbContext _context;

        public ProductNameController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetProductName()
        {
            try
            {

                _context.Configuration.ProxyCreationEnabled = false;
                var prodName = _context.Productz.ToList();
                return Ok(new { prodName, value = 1 });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException);
                return Ok(new { value = 0 });
            }
        }

    }

    public class Get_State_Gender_TitleController : ApiController
    {
        private ApplicationDbContext _context;
        public Get_State_Gender_TitleController()
        {
            _context = new ApplicationDbContext();
        }
        // For CreateUser.cshtml page 
        public IHttpActionResult GetStateGenderTitle()

        {
            try
            {
                _context.Configuration.ProxyCreationEnabled = false;
                var state = _context.Statez.ToList();
                var gender = _context.Genderz.ToList();
                var title = _context.Titlez.ToList();
                return Ok(new { state, gender, title, value = 1 });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException);
                return Ok(new { value = 0 });
            }
        }
    }

    public class Get_State_Product_DaysController : ApiController
    {
        private ApplicationDbContext _context;
        public Get_State_Product_DaysController()
        {
            _context = new ApplicationDbContext();
        }
        // For Createmarket.cshtml page
        public IHttpActionResult GetStateProductDays()
        {
            try
            {
                _context.Configuration.ProxyCreationEnabled = false;
                var state = _context.Statez.ToList();
                var product = _context.Productz.ToList();
                var days = _context.MarketDaysz.ToList();
                return Ok(new { state, product, days, value = 1 });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException);
                return Ok(new { value = 0 });
            }
        }

    }

    public class GetCategory_Unit_Lga_StateController : ApiController
    {
        private ApplicationDbContext _context;
        public GetCategory_Unit_Lga_StateController()
        {
            _context = new ApplicationDbContext();
        }
        // For CreateBuyerAndSeller.cshtml page
        public IHttpActionResult GetCategoryUnitLgaState()
        {
            try
            {
                _context.Configuration.ProxyCreationEnabled = false;
                var category = _context.Categoryz.ToList();  //category,
                var unit = _context.Unitz.ToList();
                var lga = _context.LGAz.ToList();
                var state = _context.Statez.ToList();
                return Ok(new { category, unit, state, lga, value = 1 });  //category, unit,state, lga,
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException);
                return Ok(new { value = 0 });
            }
        }

    }

    public class GetMarketName_ProdName_UnitController : ApiController
    {
        private ApplicationDbContext _context;
        public GetMarketName_ProdName_UnitController()
        {
            _context = new ApplicationDbContext();
        }
        // For CreatePrice.cshtml page
        public IHttpActionResult GetMarketNameProdNameUnit()
        {
            try
            {
                _context.Configuration.ProxyCreationEnabled = false;
                var marketName = _context.Marketz.ToList();
                var prodName = _context.Productz.ToList();
                var unit = _context.Unitz.ToList();
                return Ok(new { unit, prodName, marketName, value = 1 });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException);
                return Ok(new { value = 0 });
            }
        }

    }

}
