using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationJS.Models
{
    #region HOTEL
    public class HotelModel
    {
        [Display(Name = "Chambre disponible")]
        public List<ChambreModel> Rooms { get; set; }
        [Display(Name = "Nom de l'hotel")]
        public string Name { get; set; }
    }
    #endregion

    #region CHAMBRE DE HOTEL
    public class ChambreModel
    {
        [Display(Name = "Numéro de chambre")]
        public int RoomNumber { get; set; }
        [Display(Name = "Catégorie")]
        public string Category { get; set; }
        [Display(Name = "Etat")]
        public bool Available { get; set; }
        [Display(Name = "Prix")]
        public float Price { get; set; }
    }
    #endregion
}
