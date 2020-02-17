
using HotelServiceReference;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiREST.Controllers
{
    [DisableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        #region VARIABLES
        private readonly HotelServiceClient hotelclient = new HotelServiceClient();
        private static List<hotel> ListeDhotel;
        #endregion

        #region Constructeur
        public HotelController()
        {
            if (ListeDhotel == null)
            {
                ListeDhotel = new List<hotel>();
                try
                {
                    getHotelsResponse reponse = hotelclient.getHotelsAsync().Result;
                    ListeDhotel = new List<hotel>(reponse.@return);
                }
                catch (Exception e)
                {

                }
            }
            else if (!ListeDhotel.Any())
            {
                ListeDhotel = new List<hotel>();
                try
                {
                    getHotelsResponse reponse = hotelclient.getHotelsAsync().Result;
                    ListeDhotel = new List<hotel>(reponse.@return);
                }
                catch (Exception e)
                {

                }
            }
        }
        #endregion

        #region GET ALL
        // GET: api/Hotel
        [DisableCors]
        [Produces("application/json")]
        [HttpGet("GetAllHotel")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public ActionResult<IEnumerable<hotel>> Get()
        {
            return Ok(ListeDhotel);
        }
        #endregion

        #region GET ONE
        // GET: api/Hotel/5
        [DisableCors]
        [Produces("application/json")]
        [HttpGet("{ide}", Name = "GetOneHotel")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public hotel Get(string ide)
        {
            return ListeDhotel.Where(x => x.name == ide).FirstOrDefault();
        }
        #endregion

        #region PUT RESERVATION
        // PUT: api/Hotel/5
        [HttpPut("{ID}/{roomNumber}", Name = "PutOneHotel")]
        [DisableCors]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public void Put(string ID, int roomNumber)
        {
            foreach (hotel x in ListeDhotel)
            {
                if (x.name == ID)
                {
                    foreach (room y in x.rooms)
                    {
                        if (y.roomNumber == roomNumber)
                        {
                            if (y.available)
                            {
                                y.available = false;
                            }
                            else
                            {
                                y.available = true;
                            }
                        }
                    }
                }
            }
        }
        #endregion
    }
}
