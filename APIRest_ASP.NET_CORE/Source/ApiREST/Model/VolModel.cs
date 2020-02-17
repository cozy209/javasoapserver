using System;
using System.Collections.Generic;

namespace ApiREST.Model
{
    #region AVION
    public class VolModel
    {
        public long ID { get; set; }
        public string Compagnie { get; set; }
        public List<PlaceModel> ListePlaces { get; set; }
        public DateTime DateVol { get; set; }
    }
    #endregion

    #region PLACE AVION
    public class PlaceModel
    {
        public string Nom { get; set; }
        public bool Etat { get; set; }
        public float Prix { get; set; }
    }
    #endregion
}
