using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationJS.Models
{
    #region AVION
    public class VolModel
    {
        public long ID { get; set; }
        public string Compagnie { get; set; }
        [Display(Name = "Nombre de place")]
        public List<PlaceModel> ListePlaces { get; set; }
        [Display(Name = "Date du vol")]
        public DateTime DateVol { get; set; }
    }
    #endregion

    #region PLACE AVION
    public class PlaceModel
    {
        [Display(Name = "Numéro de place")]
        public string Nom { get; set; }
        public bool Etat { get; set; }
        public float Prix { get; set; }
    }
    #endregion
}
