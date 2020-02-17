using ApiREST.Model;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    public class VolController : ControllerBase
    {
        #region VARIABLE
        private static List<VolModel> ListeDeVol;
        #endregion

        #region Constructeur
        public VolController()
        {
            if (ListeDeVol == null || !ListeDeVol.Any())
            {
                int valeurprix = 25;
                ListeDeVol = new List<VolModel>();
                List<PlaceModel> ListPlace = new List<PlaceModel>();
                for (int i = 1; i <= 30; i++)
                {
                    if ((i % 10) == 0)
                    {
                        valeurprix += 100;
                    }
                    PlaceModel UnePlace = new PlaceModel
                    {
                        Etat = false,
                        Nom = i.ToString(),
                        Prix = valeurprix
                    };
                    ListPlace.Add(UnePlace);
                }
                valeurprix = 50;
                List<PlaceModel> ListPlace1 = new List<PlaceModel>();
                for (int i = 1; i <= 30; i++)
                {
                    if ((i % 10) == 0)
                    {
                        valeurprix += 100;
                    }
                    PlaceModel UnePlace1 = new PlaceModel
                    {
                        Etat = false,
                        Nom = i.ToString(),
                        Prix = valeurprix
                    };
                    ListPlace1.Add(UnePlace1);
                }
                valeurprix = 75;
                List<PlaceModel> ListPlace2 = new List<PlaceModel>();
                for (int i = 1; i <= 30; i++)
                {
                    if ((i % 10) == 0)
                    {
                        valeurprix += 100;
                    }
                    PlaceModel UnePlace2 = new PlaceModel
                    {
                        Etat = false,
                        Nom = i.ToString(),
                        Prix = valeurprix
                    };
                    ListPlace2.Add(UnePlace2);
                }
                VolModel model = new VolModel
                {
                    Compagnie = "Air_Bastien",
                    DateVol = DateTime.Now.AddHours(1),
                    ID = 1,
                    ListePlaces = ListPlace
                };
                VolModel model2 = new VolModel
                {
                    Compagnie = "Air_Virginie",
                    DateVol = DateTime.Now.AddHours(3),
                    ID = 2,
                    ListePlaces = ListPlace1
                };
                VolModel model3 = new VolModel
                {
                    Compagnie = "Air_Paultes",
                    DateVol = DateTime.Now.AddHours(5),
                    ID = 3,
                    ListePlaces = ListPlace2
                };
                ListeDeVol.Add(model);
                ListeDeVol.Add(model2);
                ListeDeVol.Add(model3);
            }
        }
        #endregion

        #region GET ALL
        // GET: api/Vol
        [DisableCors]
        [Produces("application/json")]
        [HttpGet("GetAllVol")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public ActionResult<IEnumerable<VolModel>> Get()
        {
            return Ok(ListeDeVol);
        }
        #endregion

        #region GET ONE
        // GET: api/Vol/5
        [DisableCors]
        [Produces("application/json")]
        [HttpGet("{ide}", Name = "GetOneVol")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public VolModel Get(long ide)
        {
            return ListeDeVol.Where(x => x.ID == ide).FirstOrDefault();
        }
        #endregion

        #region PUT RESERVATION
        // PUT: api/Vol/5
        [HttpPut("{ID}/{nom}", Name = "PutOneVol")]
        [DisableCors]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public void Put(long ID, string nom)
        {
            foreach (VolModel x in ListeDeVol)
            {
                if (x.ID == ID)
                {
                    foreach (PlaceModel y in x.ListePlaces)
                    {
                        if (y.Nom == nom)
                        {
                            if (y.Etat)
                            {
                                y.Etat = false;
                            }
                            else
                            {
                                y.Etat = true;
                            }
                        }
                    }
                }
            }
        }
        #endregion
    }
}
