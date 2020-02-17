using System.Collections.Generic;
using WebApplicationJS.Models;

namespace WebApplicationJS.ViewModels
{
    public class SiteViewModel
    {
        public SiteViewModel()
        {
            ListeDeHotel = new List<HotelModel>();
            ListeDeVol = new List<VolModel>();
        }
        public SiteViewModel(List<VolModel> listvol, List<HotelModel> listhotel)
        {
            ListeDeHotel = listhotel;
            ListeDeVol = listvol;
        }

        public List<VolModel> ListeDeVol { get; set; }
        public List<HotelModel> ListeDeHotel { get; set; }

    }
}
